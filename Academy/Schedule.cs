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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Academy
{
    public partial class Schedule : Form
    {
        string connectionString;
        SqlConnection connection;
        SqlDataReader reader;
        DataTable table;
        
        public Schedule()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            Load_discipline_select();
            Load_teacher_select();
            Load_group_select();
        }
        void Load_discipline_select()
        {
            string commandLine = @"SELECT discipline_name FROM Disciplines";
            SqlCommand cmd = new SqlCommand(commandLine, connection);
            connection.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                discipline_select.Items.Add(reader[0]);
            }
            reader.Close();
            connection.Close();
        }
        void Load_teacher_select()
        {
            string commandLine = @"SELECT last_name, first_name, middle_name FROM Teachers";
            SqlCommand cmd = new SqlCommand(commandLine, connection);
            connection.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                teacher_select.Items.Add($"{reader[0]} {reader[1]} {reader[2]}");
            }
            reader.Close();
            connection.Close();
        }
        void Load_group_select()
        {
            string commandLine = @"SELECT group_name FROM Groups";
            SqlCommand cmd = new SqlCommand(commandLine, connection);
            connection.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                group_select.Items.Add(reader[0]);
            }
            reader.Close();
            connection.Close();
        }
        private void buttonExit_Shedule_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddShedule_Click(object sender, EventArgs e)
        {
            try
            {
                
                connection.Open();
                string discipline = discipline_select.SelectedItem.ToString();
                string group = discipline_select.SelectedItem.ToString();
     
                string last_name = teacher_select.Text.Split(' ')[0];
                string first_name = teacher_select.Text.Split(' ')[1];
                string middle_name = teacher_select.Text.Split(' ')[2];

                string commandTeacher = $"SELECT teacher_id FROM Teachers WHERE last_name LIKE '{last_name}' AND first_name LIKE '{first_name}' AND middle_name LIKE '{middle_name}'";
                SqlCommand cmd = new SqlCommand(commandTeacher, connection);
                int teacher = Convert.ToInt32(cmd.ExecuteScalar());

                DateTime start_date = dateTimePickerDate.Value;
                string time = time_select.Text;
                //Хранимая процедура
                SqlCommand command = new SqlCommand("addToSchedule", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@group_name", group);
                command.Parameters.AddWithValue("@discipline", discipline);
                command.Parameters.AddWithValue("@teacher", teacher);
                command.Parameters.AddWithValue("@start_date", start_date);
                command.Parameters.AddWithValue("@time", time);
                command.ExecuteNonQuery();
                MessageBox.Show(this, "Успешно добавлено расписание");
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
    }
}
