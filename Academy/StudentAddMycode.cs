using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
    public partial class StudentAddMycode : Form
    {
        string connectionString;
        SqlConnection connection;
        SqlDataReader reader;
        DataTable table;
        public StudentAddMycode()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }
        

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                string last_name = last_name_input.Text;
                string first_name = first_name_input.Text;
                string middle_name = middle_name_input.Text;
                string birth_date = birth_date_input.Text;
                string group = group_input.Text;

                connection.Open();
                string checkQuery = "SELECT COUNT (*) FROM Students WHERE last_name = @last_name AND first_name = @first_name AND middle_name = @middle_name AND birth_date = @birth_date AND [group] = @group";
                SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@last_name", last_name);
                checkCommand.Parameters.AddWithValue("@first_name", first_name);
                checkCommand.Parameters.AddWithValue("@middle_name", middle_name);
                checkCommand.Parameters.AddWithValue("@birth_date", birth_date);
                checkCommand.Parameters.AddWithValue("@group", group);

                int count = (int)checkCommand.ExecuteScalar();
                if (count > 0) 
                {
                    Console.WriteLine("Запись уже существует.");
                    return;
                }

                string query = "INSERT INTO Students (last_name, first_name, middle_name, birth_date, [group]) VALUES (@last_name, @first_name, @middle_name, @birth_date, @group)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@last_name", last_name);
                cmd.Parameters.AddWithValue("@first_name", first_name);
                cmd.Parameters.AddWithValue("@middle_name", middle_name);
                cmd.Parameters.AddWithValue("@birth_date", birth_date);
                cmd.Parameters.AddWithValue("@group", group);
                cmd.ExecuteNonQuery();
                MessageBox.Show(this, "Успешно добавлено");

                first_name_input.Clear();
                last_name_input.Clear();
                middle_name_input.Clear();
                birth_date_input.Clear();
                group_input.Clear();
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
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
