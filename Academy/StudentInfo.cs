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

                //rtbFullName.Text = last_name;


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
