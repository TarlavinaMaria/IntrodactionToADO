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
    public partial class StudentInfo : Form
    {
        string connectionString;
        SqlConnection connection;
        SqlDataReader reader;
        DataTable table;
        public string CellValue { get; set; }
        public StudentInfo()
        {
            InitializeComponent();
            Load_StudentInfo();
        }
        void Load_StudentInfo()
        {
            string commandLine = $@"SELECT
                                    last_name, first_name, middle_name FROM Students WHERE last_name = '{CellValue}'
                                        ";
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
            dgvSudentInfo.DataSource = table;

            reader.Close();
            connection.Close();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
