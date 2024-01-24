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
    public partial class AddGroup : Form
    {
        string connectionString;
        SqlConnection connection;
        SqlDataReader reader;
        DataTable table;
        public AddGroup()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            LoadDirection();
            LoadSchedule();
        }
        public void LoadDirection()
        {
            string commandLine = @"SELECT direction_name FROM Directions";
            SqlCommand cmd = new SqlCommand(commandLine, connection);
            connection.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbSpecSelect.Items.Add(reader[0]);
            }
            reader.Close();
            connection.Close();
        }
        private void btAddGroup_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string group_name = rtbGroupName.Text;
                string spec = cbSpecSelect.SelectedItem.ToString();
                string commandspec = $"SELECT direction_id FROM Directions WHERE direction_name LIKE '{spec}'";
                SqlCommand cmd = new SqlCommand(commandspec, connection);
                int direction = Convert.ToInt32(cmd.ExecuteScalar());

                string checkQuery = "SELECT COUNT (*) FROM Groups WHERE group_name = @group_name AND direction = @direction";
                SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@group_name", group_name);
                checkCommand.Parameters.AddWithValue("@direction", direction);

                int count = (int)checkCommand.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show(this, "Запись уже существует");
                    return;
                }

                string query = "INSERT INTO Groups (group_name, direction) VALUES (@group_name, @direction)";
                SqlCommand cmdAdd = new SqlCommand(query, connection);
                cmdAdd.Parameters.AddWithValue("@group_name", group_name);
                cmdAdd.Parameters.AddWithValue("@direction", direction);
                cmdAdd.ExecuteNonQuery();
                MessageBox.Show(this, "Успешно добавлено");
                rtbGroupName.Clear();
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
                LoadSchedule();
        }

        private void bnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        void LoadSchedule()
        {
            string commandLine = @"SELECT 
                                    group_name, direction_name
                                    FROM Groups, Directions WHERE direction = direction_id";
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
            dgvGroup.DataSource = table;

            reader.Close();
            connection.Close();
        }
    }
}
