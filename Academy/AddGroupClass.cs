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
    public partial class AddGroupClass : Form
    {
        string[] week = new string[] { "Пн", "Вт", "Ср","Чт","Пт","Сб", "Вс"};
        public AddGroupClass()
        {
            InitializeComponent();
            
            //((Form1)Parent).LoadDataToComboBox(cbDirection, "Directions", "direction_name", "Выберите направление обучения");
            //((Form1)Parent).LoadDataToComboBox(cbLearningForm, "LearningForms", "form_name", "Выберите форму обучения");
            //((Form1)Parent).LoadDataToComboBox(cbTime, "LearningTimes", "time_name", "Выберите время обучения");
        }
        
    }
}
