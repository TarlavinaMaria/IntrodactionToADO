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
using System.IO;

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
            Load_Grade(data);
            Load_Photo(data);
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

                string checkQuery = "SELECT COUNT(student) FROM Attendance JOIN Students ON stud_id = student WHERE last_name = @last_name";
                SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@last_name", last_name);
                int count = (int)checkCommand.ExecuteScalar();
                if (count == 0)
                {
                    rtbAttendance.Text = $"Процент посещаемости 0%";
                    return;
                }
                else
                {
                    string count_all = "SELECT (CAST(COUNT(CASE WHEN present = 1 THEN 1 END) AS float) / COUNT(present)) * 100.0 AS AttendancePercentage" +
                        " FROM Students, Attendance WHERE last_name = @last_name AND stud_id = student";
                    SqlCommand cmd = new SqlCommand(count_all, connection);
                    cmd.Parameters.AddWithValue("@last_name", last_name);
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        double attendancePercentage = Convert.ToDouble(reader["AttendancePercentage"]);
                        if (attendancePercentage > 0)
                        {
                            rtbAttendance.Text = $"Процент посещаемости {attendancePercentage}%";
                        }
                        else
                        {
                            rtbAttendance.Text = $"Процент посещаемости 0%";
                        }
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
            void Load_Grade(string last_name)
            {
                try
                {
                    connection.Open();

                    string checkQuery = "SELECT COUNT(student) FROM Grades JOIN Students ON stud_id = student WHERE last_name = @last_name";
                    SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                    checkCommand.Parameters.AddWithValue("@last_name", last_name);
                    int count = (int)checkCommand.ExecuteScalar();
                    if (count == 0)
                    {
                        pictureBoxStudent.Text = $"Средний балл 0";
                        return;
                    }
                    else
                    {
                        string sum_all1 = "SELECT AVG(grade1), AVG(grade2) FROM Students, Grades WHERE last_name = @last_name AND stud_id = student";
                        SqlCommand cmd = new SqlCommand(sum_all1, connection);
                        cmd.Parameters.AddWithValue("@last_name", last_name);
                        reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            int grade1 = reader.GetInt32(0);
                            int grade2 = reader.GetInt32(1);

                            int averageGrade = (grade1 + grade2);
                            if (averageGrade > 0)
                            {
                                rtbGrade.Text = $"Средний балл {averageGrade}";
                            }
                            else
                            {
                                rtbGrade.Text = $"Средний балл 0";
                            }
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
        void Load_Photo(string last_name)
        {
            try
            {
                connection.Open();

                string checkQuery = "SELECT COUNT(photo) FROM Students WHERE last_name = @last_name";
                SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@last_name", last_name);
                int count = (int)checkCommand.ExecuteScalar();
                if (count == 0)
                {
                    pictureBoxStudent.Text = $"Нет данных";
                    return;
                }
                else
                {
                    string photo = "SELECT photo FROM Students WHERE last_name = @last_name";
                    SqlCommand cmd = new SqlCommand(photo, connection);
                    cmd.Parameters.AddWithValue("@last_name", last_name);
                    byte[] photoData = (byte[])cmd.ExecuteScalar();
                    if (photoData != null)
                    {
                        using (MemoryStream ms = new MemoryStream(photoData))
                        {
                            Image img = Image.FromStream(ms);
                            pictureBoxStudent.Image = img;
                        }
                    }
                    connection.Close();
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
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private byte[] OpenAndReadImage()
        {
            byte[] imageData = null;

            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg, *.png)|*.jpg;*.png";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var imageStream = openFileDialog.OpenFile();
                        using (var memoryStream = new MemoryStream())
                        {
                            imageStream.CopyTo(memoryStream);
                            imageData = memoryStream.ToArray();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return imageData;
        }
        private void UpdatePhoto(byte[] photoData, string last_name)
        {
            string query = "UPDATE Students SET photo = @photoData WHERE last_name = @last_name";

            connection.Open();

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@photoData", photoData);
                command.Parameters.AddWithValue("@last_name", last_name);
                command.ExecuteNonQuery();
            }
            
        }
        private void buttonAddPhoto_Click(object sender, EventArgs e)
        {
            
            try
            {
                var photo_add = OpenAndReadImage();
                UpdatePhoto(photo_add, CellValue);
                connection.Close();
                Load_Photo(CellValue);

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
