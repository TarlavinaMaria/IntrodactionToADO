using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Academy
{
    public partial class AddGroupClass : Form
    {
        private string connectionString;
        SqlConnection connection;
        SqlDataAdapter adapter;// вытягивает результаты запросов из базы и сохраняет их в DataSet
        DataSet set;
        SqlCommandBuilder builder;
        public System.Windows.Forms.ComboBox CBDirection { get => cbDirection; }
        public System.Windows.Forms.ComboBox CBLearningForm { get => cbLearningForm; }
        public System.Windows.Forms.ComboBox CBLearningTime { get => cbTime; }
        string[] week = new string[] { "Пн", "Вт", "Ср","Чт","Пт","Сб", "Вс"};
        CheckBox[] cbWeek;
        public AddGroupClass()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            GetDataFromBase();
            //((Form1)Parent).LoadDataToComboBox(cbDirection, "Directions", "direction_name", "Выберите направление обучения");
            //((Form1)Parent).LoadDataToComboBox(cbLearningForm, "LearningForms", "form_name", "Выберите форму обучения");
            //((Form1)Parent).LoadDataToComboBox(cbTime, "LearningTimes", "time_name", "Выберите время обучения");
            cbWeek = new CheckBox[7];
        }
        void GetDataFromBase()
        {
            try 
            {
                set = new DataSet();
                string cmd = $@"SELECT * FROM Directions";
                adapter = new SqlDataAdapter(cmd, connection);
                builder = new SqlCommandBuilder(adapter);
                adapter.Fill(set, "Directions");
                adapter.SelectCommand.CommandText = $@"SELECT * FROM LearningTimes";
                builder.DataAdapter = adapter;
                adapter.Fill(set, "LearningTimes");
            }
            catch (Exception e) 
            {
                MessageBox.Show(this, e.Message);
            }
        }
        string GenerateGroupName()
        {
            string group_name = "";
            if(cbLearningForm.SelectedItem.ToString() == "Стационар")
            {
                if (cbDirection.SelectedItem.ToString() == "Разработка программного обеспечения")
                {
                    //DataRow[] rows = set.Tables["Directions"].Select("direction_name = 'Разработка программного обеспечения'");
                    //DataRow row = rows[0];
                    //group_name += row["direction_code_name"];
                    group_name += set.Tables["Directions"].Select($"direction_name = '{cbDirection.SelectedItem.ToString()}'")[0]["direction_code_name"];
                    group_name += set.Tables["LearningTimes"].Select($"time_name = '{cbTime.SelectedItem.ToString()}'")[0]["time_code_name"];

                }
            }
            return group_name;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            tbGroupName.Text = GenerateGroupName();
        }
    }
}
