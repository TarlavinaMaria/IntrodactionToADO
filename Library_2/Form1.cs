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

namespace Library_2
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        SqlDataReader reader;
        DataTable table;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            string cmdLine = rtbQuery.Text;
            SqlCommand cmd = new SqlCommand(cmdLine, connection);

            connection.Open();
            reader = cmd.ExecuteReader();

            //создаем таблицу, которая будет хранить результаты выборки
            table = new DataTable();
            //создаем шапку этой таблицы, FieldCount счетчик
            for (int i = 0; i < reader.FieldCount; i++) table.Columns.Add(reader.GetName(i));
            while (reader.Read())
            {
                //загрузка данных из результатов в таблицу
                DataRow row = table.NewRow();
                for (int i = 0; i < reader.FieldCount; i++) row[i] = reader[i];
                table.Rows.Add(row);
            }
            dgwResults.DataSource = table;

            reader.Close();
            connection.Close();
        }
    }
}
