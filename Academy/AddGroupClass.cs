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
using System.Runtime.InteropServices; 

namespace Academy
{
    public partial class AddGroupClass : Form
    {
        Form1 mainForm;
        private string connectionString;
        SqlConnection connection;
        SqlDataAdapter adapter;// вытягивает результаты запросов из базы и сохраняет их в DataSet
        DataSet set;
        SqlCommandBuilder builder;
        public System.Windows.Forms.ComboBox CBDirection { get => cbDirection; }
        public System.Windows.Forms.ComboBox CBLearningForm { get => cbLearningForm; }
        public System.Windows.Forms.ComboBox CBLearningTime { get => cbTime; }
        string[] week = new string[] { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };
        CheckBox[] cbWeek;
        public AddGroupClass(Form1 mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            GetDataFromBase();
            mainForm.LoadDataToComboBox(cbLearningForm, "LearningForms", "form_name", "Выберите форму обучения");
            //mainForm.LoadDataToComboBox(cbDirection, "Directions", "direction_name", "Выберите направление обучения");
            mainForm.LoadDataToComboBox(cbTime, "LearningTimes", "time_name", "Выберите время обучения");
            cbWeek = new CheckBox[7];
            
        }
        public AddGroupClass(Form1 mainForm, string group_name, byte direction, byte learning_time, byte learning_days):this(mainForm)
        {
            TableStorage storage = new TableStorage();
            storage.GetDataFromBase("Directions");
            storage.GetDataFromBase("LearningFormsDirectionsRelation");

            tbGroupName.Text = group_name;
            cbLearningForm.SelectedIndex = Convert.ToInt32(storage.Set.Tables["LearningFormsDirectionsRelation"].Select($"direction = {direction}")[0]["learning_form"]);
            
            cbDirection.SelectedItem = storage.Set.Tables["Directions"].Select($"direction_id = {direction}")[0]["direction_name"];
            cbTime.SelectedIndex = learning_time;
            btnCreateGroup.Text = "Сохранить";
        }

        byte GetBitSet()
        {
            byte days = 0;
            #region PrintInConsole
            //AllocConsole();
            //Console.Write("Days:\t");
            //for (int i = 0; i < clbWeek.CheckedItems.Count; i++)
            //{
            //    Console.Write(clbWeek.CheckedItems[i] + "\t");
            //}
            //Console.WriteLine();
            //Console.Write("Nums:\t");

            //for (int i = 0; i < clbWeek.CheckedIndices.Count; i++)
            //{
            //    Console.Write(clbWeek.CheckedIndices[i] + "\t");
            //}
            //Console.WriteLine();
            //Console.WriteLine("\n-----------------------------------------------------------------------\n"); 
            #endregion
            for (int i = 0; i < clbWeek.CheckedIndices.Count; i++)
            {
                //byte day = (byte)Math.Pow(2, clbWeek.CheckedIndices[i]);
                //days += day;
                byte day = 1;
                day <<= clbWeek.CheckedIndices[i];
                days |= day;
                /*
                 << побитовый сдвиг влево - бинарный оператор, который сдвигает число на заданнное кол-во бит влево
                                            сдвиг числа на 1 бит влево увеличивает число в 2 раза(умножеение)
                                            сдвиг числа на 2 бит влево увеличивает число в 4 раза(умножеение)
                                            сдвиг числа на 3 бит влево увеличивает число в 8 раза(умножеение)
                | побитовое сложение - если соответ бит хотя бы в одном операнде равен 1, (Составное условие истинно, если истинно, хотя бы одно из простых условий)
                
                 */
            }

            return days;
        }
        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
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
            if (!AllCombosOK()) return "Что-то пошло не так";
            string group_name = "";
            if (cbLearningForm.SelectedItem.ToString() != "Годичные курсы")
            {
                if (cbLearningForm.SelectedItem.ToString() == "Полустационар") group_name += clbWeek.SelectedItem.ToString() == "Сб" ? "S":"V";
                //if (cbDirection.SelectedItem.ToString() == "Разработка программного обеспечения")
                {
                    //DataRow[] rows = set.Tables["Directions"].Select("direction_name = 'Разработка программного обеспечения'");
                    //DataRow row = rows[0];
                    //group_name += row["direction_code_name"];
                    group_name += set.Tables["Directions"].Select($"direction_name = '{cbDirection.SelectedItem.ToString()}'")[0]["direction_code_name"];
                    group_name += set.Tables["LearningTimes"].Select($"time_name = '{cbTime.SelectedItem.ToString()}'")[0]["time_code_name"];

                }
            }
            group_name += "_";
            return group_name;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            tbGroupName.Text = GenerateGroupName();
        }
        void Direction_nameLoad() 
        {
            string selectedValue = cbLearningForm.SelectedItem.ToString();
            string query = "SELECT direction_name FROM Directions, LearningForms, LearningFormsDirectionsRelation WHERE form_name = @learning_form AND form_id = learning_form AND direction = direction_id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@learning_form", selectedValue);
            adapter = new SqlDataAdapter(command);
            cbDirection.Items.Clear();
            DataTable directionsTable = new DataTable();
            adapter.Fill(directionsTable);
            foreach (DataRow row in directionsTable.Rows)
            {
                cbDirection.Items.Add(row["direction_name"]);
            }
        }

       

        private void cbLearningForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Direction_nameLoad();
            //mainForm.LoadDataToComboBox
            //    (
            //    cbDirection,
            //    "Directions, LearningForms, LearningFormsDirectionsRelation ",
            //    "direction_name",
            //    "Выберите форму обучения",
            //    $"WHERE learning_form = form_id AND direction = direction_id AND form_name = {CBLearningForm.SelectedItem.ToString()}"
            //    );
            int selectedIndexInDirection = cbDirection.SelectedIndex;
            string directionName = cbDirection.SelectedItem?.ToString();
            cbDirection.Items.Clear();
            if(cbLearningForm.SelectedIndex != 0)
            mainForm.LoadDataFromStorageToComboBox
            (
            cbDirection,
            "Directions, LearningForms, LearningFormsDirectionsRelation ",
            "direction_name",
            "Выберите форму обучения",
            $"learning_form = form_id AND direction = direction_id AND form_name = '{CBLearningForm.SelectedItem.ToString()}'"
            );
            // cbDirection.SelectedIndex = selectedIndexInDirection < cbDirection.Items.Count ? selectedIndexInDirection : -1;
            bool badDirection = false;
            if (selectedIndexInDirection < cbDirection.Items.Count)
            {
                cbDirection.SelectedIndex = selectedIndexInDirection;
            }
            else
            {
                badDirection = true;
            }
            if(directionName != cbDirection.SelectedItem?.ToString())
            {
                badDirection = true;
            }
            if(badDirection) 
            {
                cbDirection.SelectedIndex = -1;
                cbDirection.Text = "Выберите направление обучения";
                MessageBox.Show(this, "На данной форме обучения нет такого направления", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        bool ComboBoxOK(ComboBox comboBox)
        {
            if (comboBox.SelectedItem == null) return false;
            if (comboBox.SelectedItem.ToString().Contains(" обучения")) return false;
            return true;
        }
        bool AllCombosOK()
        {
            string message = "";
            if (cbLearningForm.SelectedIndex.ToString() == "Выберите форму обучения") message =  "Выберите форму обучения";
            else if (cbDirection.SelectedItem == null || cbDirection.SelectedItem.ToString() == "Выберите направление обучения") message = "Выберите направление обучения";
            else if (cbTime.SelectedIndex.ToString() == "Выберите время обучения") message = "Выберите время обучения";
            if(message.Length > 0) 
            {
                MessageBox.Show(this, message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void clbWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblLearningDays.Text = $"Дни обучения: {GetBitSet()}";
        }

        private void btnCreateGroup_Click(object sender, EventArgs e)
        {
            if (AllCombosOK() == false) return;
            //if(
            //    !ComboBoxOK(cbLearningForm)||
            //    !ComboBoxOK(cbDirection) ||
            //    !ComboBoxOK(cbTime)
            //    )
            //{
            //    MessageBox.Show(this, "Ничего не выбрано", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            bool wrong_days = false;
            if (cbLearningForm.SelectedItem.ToString() == "Стационар" && clbWeek.CheckedItems.Count != 3) wrong_days = true;
            if (cbLearningForm.SelectedItem.ToString() == "Полустационар" && clbWeek.CheckedItems.Count != 1) wrong_days = true;
            if (cbLearningForm.SelectedItem.ToString() == "Годичные курсы" && clbWeek.CheckedItems.Count != 2) wrong_days = true;
            if(wrong_days)MessageBox.Show(this, "Проверьте дни обучения", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //else MessageBox.Show(this, "Все хорошо", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (wrong_days) return;

            TableStorage storage = new TableStorage();
            storage.GetDataFromBase("Directions");
            storage.GetDataFromBase("LearningTimes");
            storage.GetDataFromBase("Groups");

            //string insert_cmd = $@"
            //    INSERT INTO Groups(group_name, direction, learning_time, learning_days)
            //    VALUES (
            //        '{tbGroupName.Text}', 
            //        {set.Tables["Directions"].Select($"direction_name='{cbDirection.SelectedItem.ToString()}'")[0]["direction_id"]},
            //        {set.Tables["LearningTimes"].Select($"time_name = '{cbTime.SelectedItem.ToString()}'")[0]["time_id"]},
            //        {GetBitSet()}
            //        )";
            ////storage.Adapter.Update(storage.Set);
            ////storage.Adapter.InsertCommand.ExecuteNonQuery();
            //storage.Insert(insert_cmd);

            if (storage.Set.Tables["Groups"].Select($"group_name = '{tbGroupName.Text}'").Length == 0)
            {
                DataRow row = storage.Set.Tables["Groups"].NewRow();
                row["group_name"] = tbGroupName.Text;
                row["direction"] = storage.Set.Tables["Directions"].Select($"direction_name = '{cbDirection.SelectedItem.ToString()}'")[0]["direction_id"];
                row["learning_time"] = storage.Set.Tables["LearningTimes"].Select($"time_name = '{cbTime.SelectedItem.ToString()}'")[0]["time_id"];
                row["learning_days"] = GetBitSet();
                storage.Set.Tables["Groups"].Rows.Add(row);
                storage.Adapter.Update(storage.Set, "Groups"); 
                this.Close();
            }
            else
            {
                MessageBox.Show(this, "Такая группа уже есть", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
