using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;

namespace Academy
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        SqlDataReader reader;
        DataTable table;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            LoadGroupsToComboBox(cbGroup);
            SelectStudents();
            LoadSpecialization();
            SelectStudentsSpec();
        }
        public void LoadGroupsToComboBox(System.Windows.Forms.ComboBox comboBox)
        {
            string commandLine = @"SELECT group_name FROM Groups";
            SqlCommand cmd = new SqlCommand(commandLine, connection);
            connection.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox.Items.Add(reader[0]);
            }
            reader.Close();
            connection.Close();
        }
        public void LoadSpecialization()
        {
            string commandLine = @"SELECT direction_name FROM Directions";
            SqlCommand cmd = new SqlCommand(commandLine, connection);
            connection.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBoxCountSpecialization.Items.Add(reader[0]);
            }
            reader.Close();
            connection.Close();
        }
        void SelectStudents(string group = "")
        {
            string commandLine = @"SELECT 
                                    last_name, first_name, middle_name, birth_date, group_name 
                                    FROM Students JOIN Groups ON [group] = group_id";
            if (group.Length != 0) commandLine += $" WHERE [group_name] = '{group}'";
            SqlCommand cmd = new SqlCommand(commandLine, connection);
            connection.Open();
            reader = cmd.ExecuteReader();
            //создаем таблицу, которая будет хранить результаты выборки
            table = new DataTable();
            //создаем шапку этой таблицы
            for (int i = 0; i < reader.FieldCount; i++) table.Columns.Add(reader.GetName(i));
            //заполняем строки содержимым
            while (reader.Read())
            {
                //создаем новуб строку с заданным набором полей
                DataRow row = table.NewRow();
                // заполняем строку данными
                for (int i = 0; i < reader.FieldCount; i++)
                { 
                    row[i] = reader[i]; 
                }
                //исправление строки с датой формат вывода
                row["birth_date"] = Convert.ToDateTime(reader["birth_date"]).ToString("yyyy.MM.dd");
                //добавляе заполненную строку в таблицу
                table.Rows.Add(row);
            }
            dgvStudents.DataSource = table;
            reader.Close();
            if (group.Length > 0)
            {
                cmd.CommandText = $@"
                            SELECT COUNT(stud_id) 
                            FROM Students JOIN Groups ON [group] = group_id
                            WHERE [group_name] = '{group}' GROUP BY group_name"; 
            }
            else
            {
                cmd.CommandText = $@"
                            SELECT COUNT(stud_id) 
                            FROM Students JOIN Groups ON [group] = group_id";
            }
            lblStudCount.Text = $"Кол-во студентов: {Convert.ToInt32(cmd.ExecuteScalar()).ToString()}";
            connection.Close();
        }
        void SelectStudentsSpec(string specialities = "") 
        {
            try
            {
                specialities = comboBoxCountSpecialization.SelectedItem.ToString();
                connection.Open();
                string commandLine;
                if (specialities.Length > 0) 
                {
                    commandLine = $@"
                                SELECT COUNT(stud_id) 
                                FROM Students JOIN Groups ON [group] = group_id 
                                JOIN Directions ON direction = direction_id
                                WHERE direction_name = '{specialities}'
                                GROUP BY direction_id
                                ";
                }
                else
                {
                    commandLine = $@"
                                SELECT COUNT(stud_id) 
                                FROM Students JOIN Groups ON [group] = group_id 
                                JOIN Directions ON direction = direction_id
                                
                                ";
                }
                SqlCommand cmd = new SqlCommand(commandLine, connection);
                int count = (int)cmd.ExecuteScalar();
                lblStudCountSpec.Text = "Количество студентов на выбранной специальности: " + count.ToString();
                connection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (reader != null) reader.Close();

            }

        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            StudentAddMycode studentAdd = new StudentAddMycode();
            studentAdd.Show();
        }

        private void buttonAddShedule_Click(object sender, EventArgs e)
        {
            Schedule shedule = new Schedule();
            shedule.Show();
        }

        private void cbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectStudents(cbGroup.SelectedItem.ToString().Trim());
        }

        private void buttoAdd2_Click(object sender, EventArgs e)
        {
            try
            {
                AddStudent add_student = new AddStudent();
                LoadGroupsToComboBox(add_student.GroupCombo);
                DialogResult result = add_student.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.Parameters.Add("@last_name", add_student.FullName.Split(' ')[0]);
                    cmd.Parameters.Add("@first_name", add_student.FullName.Split(' ')[1]);
                    if (add_student.FullName.Split(' ').Length == 3)
                        cmd.Parameters.Add("@middle_name", add_student.FullName.Split(' ')[2]);
                    cmd.Parameters.Add("@birth_date", add_student.BirthDate.ToString("yyyy.MM.dd"));
                    cmd.Parameters.Add("@group", add_student.Group);
                    cmd.CommandText = @"
                                IF NOT EXISTS
                                (SELECT stud_id FROM Students WHERE last_name = @last_name AND first_name = @first_name AND middle_name = @middle_name)
                                BEGIN
                                INSERT INTO 
                                Students(last_name, first_name, middle_name, birth_date, [group])
                                VALUES (@last_name, @first_name, @middle_name, @birth_date, (SELECT group_id FROM Groups WHERE group_name = @group))
                                END
                                ";
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    cbGroup.SelectedItem = add_student.Group;
                    SelectStudents();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null) connection.Close();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
                try
                {
                    string fullName = richTextBoxSearchStudent.Text;
                    string last_name = richTextBoxSearchStudent.Text.Split(' ')[0];
                    string first_name = richTextBoxSearchStudent.Text.Split(' ')[1];
                    string middle_name = richTextBoxSearchStudent.Text.Split(' ')[2];
                    
                    string commandStudent = $"SELECT last_name, first_name, middle_name, birth_date, [group] FROM Students WHERE last_name = '{last_name}' AND first_name = '{first_name}' AND middle_name = '{middle_name}'";
                    SqlCommand cmd = new SqlCommand(commandStudent, connection);
                    
                    connection.Open();
                    reader = cmd.ExecuteReader();

                    table = new DataTable();
                    for (int i = 0; i < reader.FieldCount; i++) table.Columns.Add(reader.GetName(i));
                    while (reader.Read())
                    {
                        DataRow row = table.NewRow();
                        for (int i = 0; i < reader.FieldCount; i++) row[i] = reader[i];
                        table.Rows.Add(row);
                    }
                    dgvStudents.DataSource = table;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (reader != null) reader.Close();
                    if (connection != null) connection.Close();
                }
        }
    }
    
}
