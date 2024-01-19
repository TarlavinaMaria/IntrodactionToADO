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

        }
    }
}
