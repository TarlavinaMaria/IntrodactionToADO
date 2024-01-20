namespace Academy
{
    partial class Schedule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.discipline_select = new System.Windows.Forms.ComboBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.teacher_select = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.group_select = new System.Windows.Forms.ComboBox();
            this.buttonAddShedule = new System.Windows.Forms.Button();
            this.buttonExit_Shedule = new System.Windows.Forms.Button();
            this.time_select = new System.Windows.Forms.TextBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дисциплина";
            // 
            // discipline_select
            // 
            this.discipline_select.FormattingEnabled = true;
            this.discipline_select.Location = new System.Drawing.Point(12, 25);
            this.discipline_select.Name = "discipline_select";
            this.discipline_select.Size = new System.Drawing.Size(339, 21);
            this.discipline_select.TabIndex = 2;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(12, 49);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(49, 13);
            this.lb2.TabIndex = 5;
            this.lb2.Text = "Учитель";
            // 
            // teacher_select
            // 
            this.teacher_select.FormattingEnabled = true;
            this.teacher_select.Location = new System.Drawing.Point(12, 65);
            this.teacher_select.Name = "teacher_select";
            this.teacher_select.Size = new System.Drawing.Size(339, 21);
            this.teacher_select.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Время";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Группа";
            // 
            // group_select
            // 
            this.group_select.FormattingEnabled = true;
            this.group_select.Location = new System.Drawing.Point(12, 185);
            this.group_select.Name = "group_select";
            this.group_select.Size = new System.Drawing.Size(339, 21);
            this.group_select.TabIndex = 10;
            // 
            // buttonAddShedule
            // 
            this.buttonAddShedule.Location = new System.Drawing.Point(12, 212);
            this.buttonAddShedule.Name = "buttonAddShedule";
            this.buttonAddShedule.Size = new System.Drawing.Size(339, 23);
            this.buttonAddShedule.TabIndex = 12;
            this.buttonAddShedule.Text = "Добавить в расписание";
            this.buttonAddShedule.UseVisualStyleBackColor = true;
            this.buttonAddShedule.Click += new System.EventHandler(this.buttonAddShedule_Click);
            // 
            // buttonExit_Shedule
            // 
            this.buttonExit_Shedule.Location = new System.Drawing.Point(12, 242);
            this.buttonExit_Shedule.Name = "buttonExit_Shedule";
            this.buttonExit_Shedule.Size = new System.Drawing.Size(339, 23);
            this.buttonExit_Shedule.TabIndex = 13;
            this.buttonExit_Shedule.Text = "Выход";
            this.buttonExit_Shedule.UseVisualStyleBackColor = true;
            this.buttonExit_Shedule.Click += new System.EventHandler(this.buttonExit_Shedule_Click);
            // 
            // time_select
            // 
            this.time_select.Location = new System.Drawing.Point(12, 146);
            this.time_select.Name = "time_select";
            this.time_select.Size = new System.Drawing.Size(339, 20);
            this.time_select.TabIndex = 15;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(15, 106);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(336, 20);
            this.dateTimePickerDate.TabIndex = 26;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 269);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.time_select);
            this.Controls.Add(this.buttonExit_Shedule);
            this.Controls.Add(this.buttonAddShedule);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.group_select);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.teacher_select);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.discipline_select);
            this.Name = "Schedule";
            this.Text = "Shedule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox discipline_select;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.ComboBox teacher_select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox group_select;
        private System.Windows.Forms.Button buttonAddShedule;
        private System.Windows.Forms.Button buttonExit_Shedule;
        private System.Windows.Forms.TextBox time_select;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
    }
}