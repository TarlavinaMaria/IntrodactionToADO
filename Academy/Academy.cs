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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            LoadDirectionsToComboBox();
            rbStudent.Checked = true;
            LoadDataToComboBox(cbDirectionOnGroupTab, "Directions", "direction_name", "Выберите направление");
        }
        public void LoadDataToComboBox(System.Windows.Forms.ComboBox comboBox ,
            string sourceTable, string sourceColumn, string invite = "Выберите значение", 
            string condition = null)
        {
            string commandLine = $@"SELECT {sourceColumn} FROM {sourceTable} ";
            if (condition != null) commandLine += condition;
            SqlCommand cmd = new SqlCommand(commandLine, connection);

            //cmd.Connection = connection;
            //cmd.Parameters.Add("@table_name", sourceTable);
            //cmd.Parameters.Add("@column_name", sourceColumn);
            //cmd.CommandText = @"SELECT @column_name FROM @table_name";
            connection.Open();
            reader = cmd.ExecuteReader();
            comboBox.Items.Add(invite);
            while (reader.Read())
            {
                comboBox.Items.Add(reader[0]);
            }
            reader.Close();
            connection.Close();
            comboBox.SelectedItem = invite;
        }
        public void LoadDataFromStorageToComboBox
            (
            System.Windows.Forms.ComboBox comboBox,
             
             string table_name, 
             string column_name,
             string invite = "Выберите значение",
            string condition = null
            )
        {
            TableStorage storage = new TableStorage();
            storage.GetDataFromBase(table_name, column_name, condition);
            DataRow[] rows = storage.Set.Tables[0].Select();
            for(int i = 0; i < rows.Length; i++)
            {
                comboBox.Items.Add(rows[i][column_name]);
            }
        }
        public void SelectDataFromTable(System.Windows.Forms.DataGridView dataGridView,
            string commandLine)
            //string tableName, params string[] columns)
        {
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = connection;
            //cmd.CommandText = "SELECT ";
            //for (int i = 0; i < columns.Length; i++)
            //{
            //    cmd.Parameters.Add($"{columns[i]}", columns[i]);
            //    cmd.CommandText += $"{columns[i]}";
            //    cmd.CommandText += i == columns.Length - 1 ? " " : ", ";
            //}

            //cmd.CommandText += $"FROM {tableName}";
            SqlCommand cmd = new SqlCommand(commandLine, connection);
            connection.Open();
            reader = cmd.ExecuteReader();
            table = new DataTable();
            for (int i = 0; i < reader.FieldCount; i++)
            {
                table.Columns.Add(reader.GetName(i));
            }
            while(reader.Read())
            {
                DataRow row = table.NewRow();
                for(int i = 0; i < reader.FieldCount; i++)
                {
                    row[i] = reader[i];
                }
                table.Rows.Add(row);
            }
            dataGridViewGroups.DataSource = table;
            reader.Close();
            connection.Close();

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
        public void LoadDirectionsToComboBox()
        {
            string commandLine = @"SELECT direction_name FROM Directions";
            SqlCommand cmd = new SqlCommand(commandLine, connection);
            connection.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbDirection.Items.Add(reader[0]);
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
                if (reader != null) reader.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddGroup addGroup = new AddGroup();
            addGroup.Show();
        }

        private void btChangeGroup_Click(object sender, EventArgs e)
        {
            ChangeGroup changeGroup = new ChangeGroup();
            changeGroup.Show();
        }

        private void dgvStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string collumName = dgvStudents.Columns[e.ColumnIndex].Name;
                if(collumName == "last_name")
                {
                     // Получаем значение ячейки, на которую был сделан двойной щелчок
                     string cellValue = dgvStudents.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                     StudentInfo studentInfo = new StudentInfo(cellValue);
                     studentInfo.ShowDialog();
                }
                else
                { 
                    MessageBox.Show(this, "Нажмите на фамилию"); 
                }
                
            }
        }

        private void cbDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvStudents.DataSource = null;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            if(cbDirection.SelectedItem != null) cmd.Parameters.Add("@direction", cbDirection.SelectedItem.ToString());
            if (rbStudent.Checked)
            {
                cmd.CommandText = @"SELECT last_name, first_name, middle_name, birth_date, group_name, direction_name
            FROM Students 
            JOIN Groups ON [group] = group_id
            JOIN Directions ON direction = direction_id"; 
                if(cbDirection.SelectedItem != null)
                {
                    cmd.CommandText += " WHERE direction_name = @direction";
                }
            }
            if(rbGroups.Checked)
            {
                cmd.CommandText = @"SELECT group_name, direction_name
            FROM Groups 
            JOIN Directions ON direction = direction_id";
                if(cbDirection.SelectedItem != null)
                {
                    cmd.CommandText += " WHERE direction_name = @direction";
                }
            }
            connection.Open();
            reader = cmd.ExecuteReader();
            table = new DataTable();
            for (int i = 0; i < reader.FieldCount; i++) table.Columns.Add(reader.GetName(i));
            while (reader.Read())
            {
                DataRow row = table.NewRow();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row[i] = reader[i];
                }
                table.Rows.Add(row);
            }
            dgvStudents.DataSource = table;
            reader.Close();
            int studebtsCount = dgvStudents.RowCount - 1;
            lblStudCount.Text = $"Кол-во студентов: {studebtsCount}";
            connection.Close();
        }

        private void rbGroups_CheckedChanged(object sender, EventArgs e)
        {
            if(rbGroups.Checked) 
            {
                cbDirection_SelectedIndexChanged(sender, e);
            }
        }

        private void rbStudent_CheckedChanged(object sender, EventArgs e)
        {
            if(rbStudent.Checked) 
            {
                cbDirection_SelectedIndexChanged(sender, e);
            }
        }

        private void cbDirectionOnGroupTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SelectDataFromTable(dataGridViewGroups, "Groups", "group_name", "direction");   
            string commandLine = $@"
                                    SELECT group_name, direction_name 
                                    FROM Groups JOIN Directions ON direction = direction_id
                                    ";
            if(cbDirectionOnGroupTab.SelectedIndex != 0)  
               commandLine += $@"WHERE direction_name = '{cbDirectionOnGroupTab.SelectedItem}'";
            SelectDataFromTable(dataGridViewGroups, commandLine);
            lblGroupsCount.Text = $"Кол-во групп: {dataGridViewGroups.Rows.Count - 1}";
        }

        private void btnGroupAdd_Click(object sender, EventArgs e)
        {
            AddGroupClass add = new AddGroupClass(this);
            //LoadDataToComboBox(add.CBDirection, "Directions", "direction_name", "Выберите направление обучения");
            //LoadDataToComboBox(add.CBLearningForm, "LearningForms", "form_name", "Выберите форму обучения");
            //LoadDataToComboBox(add.CBLearningTime, "LearningTimes", "time_name", "Выберите время обучения");
            DialogResult result = add.ShowDialog();
            if (result == DialogResult.OK)
            {

            }

        }

        private void richTextBoxSearchStudent_TextChanged(object sender, EventArgs e)
        {
            string searchText = richTextBoxSearchStudent.Text;;
            string query = "SELECT * FROM Students WHERE CONCAT(last_name, ' ', first_name, ' ', middle_name) LIKE @searchText";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
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
            reader.Close();
            connection.Close();
        }
    }
    
}
