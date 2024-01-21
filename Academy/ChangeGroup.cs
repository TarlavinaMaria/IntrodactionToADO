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
using System.Collections;

namespace Academy
{
    public partial class ChangeGroup : Form
    {
        string connectionString;
        SqlConnection connection;
        SqlDataReader reader;
        DataTable table;
        public ChangeGroup()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            Load_group_select();
            Load_stud_select();
            LoadStudChange();
        }
        void Load_group_select()
        {
            string commandLine = @"SELECT group_name FROM Groups";
            SqlCommand cmd = new SqlCommand(commandLine, connection);
            connection.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbChangeGroup.Items.Add(reader[0]);
            }
            reader.Close();
            connection.Close();
        }
        void Load_stud_select()
        {
            string commandLine = @"SELECT last_name, first_name, middle_name FROM Students";
            SqlCommand cmd = new SqlCommand(commandLine, connection);
            connection.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBoxSelentStudentChange.Items.Add($"{reader[0]} {reader[1]} {reader[2]}");
            }
            reader.Close();
            connection.Close();
        }
        private void bnChange_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string group_select = cbChangeGroup.SelectedItem.ToString();
                string commandGroup = $"SELECT group_id FROM Groups WHERE group_name = '{group_select}'";
                SqlCommand cmd_group = new SqlCommand(commandGroup, connection);
                int group = Convert.ToInt32(cmd_group.ExecuteScalar());

                string last_name = comboBoxSelentStudentChange.Text.Split(' ')[0];
                string first_name = comboBoxSelentStudentChange.Text.Split(' ')[1];
                string middle_name = comboBoxSelentStudentChange.Text.Split(' ')[2];

                string commandStudent = $"SELECT stud_id FROM Students WHERE last_name LIKE '{last_name}' AND first_name LIKE '{first_name}' AND middle_name LIKE '{middle_name}' ";
                SqlCommand cmd = new SqlCommand(commandStudent, connection);
                int student = Convert.ToInt32(cmd.ExecuteScalar());

                string checkQuery = "SELECT COUNT (*) FROM Students WHERE [group] = @group AND last_name = @last_name AND first_name = @first_name AND middle_name = @middle_name";
                SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@group", group);
                checkCommand.Parameters.AddWithValue("@last_name", last_name);
                checkCommand.Parameters.AddWithValue("@first_name", first_name);
                checkCommand.Parameters.AddWithValue("@middle_name", middle_name);

                int count = (int)checkCommand.ExecuteScalar();
                if (count > 0)
                {
                    Console.WriteLine("Запись уже существует.");
                    return;
                }

                string change = "UPDATE Students SET [group] = @group WHERE stud_id = @student";
                SqlCommand cmdChange = new SqlCommand(change, connection);
                cmdChange.Parameters.AddWithValue("@group", group);
                cmdChange.Parameters.AddWithValue("@student", student);
                cmdChange.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show(this, "Успешно группа изменена");
                LoadStudChange();
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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        void LoadStudChange()
        {
            string commandLine = @"SELECT 
                                    last_name, first_name, middle_name, birth_date, group_name 
                                    FROM Students JOIN Groups ON [group] = group_id";
            SqlCommand cmd = new SqlCommand(commandLine, connection);
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
            dgvGroupChange.DataSource = table;

            reader.Close();
            connection.Close();
        }
    }
}
