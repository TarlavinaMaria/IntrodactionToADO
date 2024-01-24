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
    public partial class StudentInfo : Form
    {
        string connectionString;
        SqlConnection connection;
        SqlDataReader reader;
        DataTable table;

        private string CellValue;
        public StudentInfo(string data)
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            CellValue = data;
            Load_StudentInfo(data);
            Load_Group(data);
            Load_Spec(data);
            Load_Attendance(data);
        }
        void Load_StudentInfo(string last_name)
        {
            try
            {
                connection.Open();
                string FullName = @"SELECT last_name, first_name, middle_name FROM Students WHERE last_name = @last_name";
                SqlCommand cmd = new SqlCommand(FullName, connection);
                cmd.Parameters.AddWithValue("@last_name", last_name);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    rtbFullName.Text = $"{reader[0]} {reader[1]} {reader[2]}";
                }
                reader.Close();
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
        void Load_Group(string last_name)
        {
            try
            {
                connection.Open();
                string FullName = @"SELECT group_name FROM Students, Groups WHERE last_name = @last_name AND [group] = group_id";
                SqlCommand cmd = new SqlCommand(FullName, connection);
                cmd.Parameters.AddWithValue("@last_name", last_name);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    rtbGroup.Text = $"{reader[0]}";
                }
                reader.Close();
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
        void Load_Spec(string last_name)
        {
            try
            {
                connection.Open();
                string spec = @"SELECT direction_name FROM Students, Groups, Directions WHERE last_name = @last_name AND [group] = group_id AND direction = direction_id";
                SqlCommand cmd = new SqlCommand(spec, connection);
                cmd.Parameters.AddWithValue("@last_name", last_name);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    rtbSpec.Text = $"{reader[0]}";
                }
                reader.Close();
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
        void Load_Attendance(string last_name)
        {
            try
            {
                connection.Open();
                string count_all = "SELECT (CAST(COUNT(CASE WHEN present = 1 THEN 1 END) AS float) / COUNT(present)) * 100.0 AS AttendancePercentage" +
                    " FROM Students, Attendance WHERE last_name = @last_name AND stud_id = student";
                SqlCommand cmd = new SqlCommand(count_all, connection);
                cmd.Parameters.AddWithValue("@last_name", last_name);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    double attendancePercentage = Convert.ToDouble(reader["AttendancePercentage"]);
                    if(attendancePercentage > 0)
                    {
                        rtbAttendance.Text = $"{attendancePercentage}%";
                    }
                    else
                    {
                        rtbAttendance.Text = $"0%";
                    }
                }

                reader.Close();
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
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
