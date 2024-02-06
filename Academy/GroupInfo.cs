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
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;

namespace Academy
{
    public partial class GroupInfo : Form
    {
        string connectionString;
        SqlConnection connection;
        SqlDataReader reader;
        DataTable table;

        private string CellValue;
        public GroupInfo(string data)
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            CellValue = data;
            Load_GroupInfo(data);
            Load_Spec(data);
            Load_Time(data);
            Load_Days(data);
        }
    void Load_GroupInfo(string group_name)
    {
        try
        {
            connection.Open();
            string FullName = @"SELECT group_name FROM Groups WHERE group_name = @group_name";
            SqlCommand cmd = new SqlCommand(FullName, connection);
            cmd.Parameters.AddWithValue("@group_name", group_name);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                 rtbGroupInfo.Text = $"{reader[0]}";
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
        void Load_Spec(string group_name)
        {
            try
            {
                connection.Open();
                string spec = @"SELECT direction_name FROM Groups, Directions WHERE group_name = @group_name AND direction = direction_id";
                SqlCommand cmd = new SqlCommand(spec, connection);
                cmd.Parameters.AddWithValue("@group_name", group_name);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    rtbSpecInfo.Text = $"{reader[0]}";
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
        void Load_Time(string group_name)
        {
            try
            {
                connection.Open();
                string spec = @"SELECT time_name FROM Groups, LearningTimes WHERE group_name = @group_name AND learning_time = time_id";
                SqlCommand cmd = new SqlCommand(spec, connection);
                cmd.Parameters.AddWithValue("@group_name", group_name);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    rtbTime.Text = $"{reader[0]}";
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
        private string BitSetToDays(byte bitset)
        {
            string[] week = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };
            string days = "";
            for (int i = 0; i < week.Length; i++)
            {
                byte day = 1;
                day <<= i;
                int day_index = (int)Math.Log(day & bitset, 2);
                if ((day & bitset) != 0)
                    days += week[day_index] + ",";
            }
            return days;
        }
        void Load_Days(string group_name)
        {
            try
            {
                connection.Open();
                string spec = @"SELECT learning_days FROM Groups WHERE group_name = @group_name";
                SqlCommand cmd = new SqlCommand(spec, connection);
                cmd.Parameters.AddWithValue("@group_name", group_name);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    rtbDayInfo.Text = BitSetToDays(Convert.ToByte(reader["learning_days"]));
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

        private void btnGroupChange_Click(object sender, EventArgs e)
        {

        }
    }
}
