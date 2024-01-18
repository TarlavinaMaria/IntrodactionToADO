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
            LoadTablesToComboBox();
        }
        void LoadTablesToComboBox()
        {
            string commandLine = @"SELECT table_name FROM information_schema.tables";
            SqlCommand cmd = new SqlCommand(commandLine, connection);
            connection.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbTables.Items.Add(reader[0]);
            }
            reader.Close();
            connection.Close();
        }

        private void cbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            string commandLine = $@"SELECT * FROM {cbTables.SelectedItem}";
            SqlCommand cmd = new SqlCommand(commandLine, connection);
            connection.Open();
            reader = cmd.ExecuteReader();
            //создаем таблицу, которая будет хранить результаты выборки
            table = new DataTable();
            //создаем шапку этой таблицы
            for (int i = 0; i < reader.FieldCount; i++) table.Columns.Add(reader.GetName(i));
            //заполняем строки содержимым
            while (reader.Read())
            {
                //создаем новуб строку с заданным набором полей
                DataRow row = table.NewRow();
                // заполняем строку данными
                for (int i = 0; i < reader.FieldCount; i++) row[i] = reader[i];
                //добавляе заполненную строку в таблицу
                table.Rows.Add(row);
            }
            dgwResults.DataSource = table;

            reader.Close();
            connection.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            StudentAdd studentAdd = new StudentAdd();
            studentAdd.Show();
        }

        private void buttonAddShedule_Click(object sender, EventArgs e)
        {
            Shedule shedule = new Shedule();
            shedule.Show();
        }
    }
}
