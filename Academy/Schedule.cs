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
            string commandLine = @"SELECT last_name FROM Teachers";
            SqlCommand cmd = new SqlCommand(commandLine, connection);
            connection.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                teacher_select.Items.Add(reader[0]);
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
                string discipline_schedule_name = discipline_select.Text;
                string query = $"SELECT discipline_id FROM Disciplines WHERE discipline_name = '{discipline_schedule_name}'";
                SqlCommand command = new SqlCommand(query, connection);
                int disciplineId = (int)command.ExecuteScalar();

                
                string teacher_schedule_name = teacher_select.Text;
                string query2 = $"SELECT discipline_id FROM Teachers WHERE last_name = '{teacher_schedule_name}'";
                SqlCommand command2 = new SqlCommand(query2, connection);
                int teachereId = (int)command2.ExecuteScalar();

                string date = date_select.Text;
                string time = time_select.Text;

                string group_schedule_name = group_select.Text;
                string query3 = $"SELECT group_id FROM Groups WHERE group_name = '{group_schedule_name}'";
                SqlCommand command3 = new SqlCommand(query3, connection);
                int groupId = (int)command3.ExecuteScalar();

                int interval = 2;
                string number_of_lessons = $"SELECT number_of_lessons FROM Disciplines WHERE discipline_id = '{disciplineId}'";
                

                int counter = 0;

                while (counter < Convert.ToInt32(number_of_lessons)) 
                {
                    string checkQuery = $"SELECT COUNT (*) FROM Schedule WHERE [group] = '{groupId}' AND discipline = '{disciplineId}' AND [date] = @date AND [time] = @time";
                    SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                    checkCommand.Parameters.AddWithValue("@date", date);
                    checkCommand.Parameters.AddWithValue("@time", TimeSpan.Parse(time));
                    //для работы с Min, Max, Sum, Count функциями в SqlCommand определен специальный метод ExecuteScalar
                    int count = (int)checkCommand.ExecuteScalar();
                    if (count > 0)
                    {
                        Console.WriteLine("Запись уже существует.");
                        return;
                    }
                    string queryAdd = $"INSERT INTO Schedule (discipline, teacher, date, [time], spent, [group]) VALUES ({disciplineId}, {teachereId}, @date, @time, @date < GETDATE() ? 1 : 0, {groupId})";
                    SqlCommand cmd = new SqlCommand(queryAdd, connection);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@time", TimeSpan.Parse(time));
                    cmd.ExecuteNonQuery();
                    counter = counter + 1;
                    //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    string checkQuery2 = $"SELECT COUNT (*) FROM Schedule WHERE [group] = '{groupId}' AND discipline = '{disciplineId}' AND [date] = @date AND [time] = DATEADD(mi, 90, CONVERT(TIME, @time)";
                    SqlCommand checkCommand2 = new SqlCommand(checkQuery2, connection);
                    checkCommand2.Parameters.AddWithValue("@date", date);
                    //для работы с Min, Max, Sum, Count функциями в SqlCommand определен специальный метод ExecuteScalar
                    int count2 = (int)checkCommand.ExecuteScalar();
                    if (count > 0)
                    {
                        Console.WriteLine("Запись уже существует.");
                        return;
                    }
                    string queryAdd2 = $"INSERT INTO Schedule (discipline, teacher, date, [time], spent, [group]) VALUES ({disciplineId}, {teachereId}, @date, CONVERT(TIME, @time), @date < GETDATE() ? 1 : 0, {groupId})";
                    SqlCommand cmd2 = new SqlCommand(query2, connection);
                    cmd2.Parameters.AddWithValue("@date", date);
                    cmd2.Parameters.AddWithValue("@time", TimeSpan.Parse(time));
                    cmd2.ExecuteNonQuery();
                    counter = counter + 1;
                    interval = interval == 2 ? 5 : 2;
                }
               MessageBox.Show(this, "Успешно добавлено");
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
