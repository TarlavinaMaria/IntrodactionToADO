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
            Load_lesson_select_Selected();
        }
        void Load_lesson_select_Selected()
        {
            string commandLine = @"SELECT lesson_id FROM Schedule";
            SqlCommand cmd = new SqlCommand(commandLine, connection);
            connection.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lesson_select.Items.Add(reader[0]);
            }
            reader.Close();
            connection.Close();
        }
        private void lesson_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string commandLine = @"SELECT table_name FROM information_schema.tables";
            //SqlCommand cmd = new SqlCommand(commandLine, connection);
            //connection.Open();
            //reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    lesson_select.Items.Add(reader[0]);
            //}
            //reader.Close();
            //connection.Close();
        }

        private void buttonExit_Shedule_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddShedule_Click(object sender, EventArgs e)
        {

        }
    }
}
