namespace Academy
{
    partial class AddGroupClass
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
            this.cbDirection = new System.Windows.Forms.ComboBox();
            this.cbLearningForm = new System.Windows.Forms.ComboBox();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.groupBoxDaysofWeek = new System.Windows.Forms.GroupBox();
            this.cbMon = new System.Windows.Forms.CheckBox();
            this.checkBoxTew = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBoxDaysofWeek.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbDirection
            // 
            this.cbDirection.FormattingEnabled = true;
            this.cbDirection.Location = new System.Drawing.Point(13, 28);
            this.cbDirection.Name = "cbDirection";
            this.cbDirection.Size = new System.Drawing.Size(408, 21);
            this.cbDirection.TabIndex = 0;
            this.cbDirection.Text = "Направление обучения";
            // 
            // cbLearningForm
            // 
            this.cbLearningForm.FormattingEnabled = true;
            this.cbLearningForm.Location = new System.Drawing.Point(12, 55);
            this.cbLearningForm.Name = "cbLearningForm";
            this.cbLearningForm.Size = new System.Drawing.Size(409, 21);
            this.cbLearningForm.TabIndex = 1;
            this.cbLearningForm.Text = "Форма обучения";
            // 
            // cbTime
            // 
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Location = new System.Drawing.Point(12, 83);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(409, 21);
            this.cbTime.TabIndex = 2;
            this.cbTime.Text = "Время обучения";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 221);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(409, 20);
            this.tbName.TabIndex = 3;
            this.tbName.Text = "Название группы";
            // 
            // groupBoxDaysofWeek
            // 
            this.groupBoxDaysofWeek.Controls.Add(this.cbMon);
            this.groupBoxDaysofWeek.Controls.Add(this.checkBox2);
            this.groupBoxDaysofWeek.Controls.Add(this.checkBoxTew);
            this.groupBoxDaysofWeek.Location = new System.Drawing.Point(13, 111);
            this.groupBoxDaysofWeek.Name = "groupBoxDaysofWeek";
            this.groupBoxDaysofWeek.Size = new System.Drawing.Size(408, 104);
            this.groupBoxDaysofWeek.TabIndex = 4;
            this.groupBoxDaysofWeek.TabStop = false;
            this.groupBoxDaysofWeek.Text = "Дни обучения";
            // 
            // cbMon
            // 
            this.cbMon.AutoSize = true;
            this.cbMon.Location = new System.Drawing.Point(6, 19);
            this.cbMon.Name = "cbMon";
            this.cbMon.Size = new System.Drawing.Size(94, 17);
            this.cbMon.TabIndex = 0;
            this.cbMon.Text = "Понедельник";
            this.cbMon.UseVisualStyleBackColor = true;
            // 
            // checkBoxTew
            // 
            this.checkBoxTew.AutoSize = true;
            this.checkBoxTew.Location = new System.Drawing.Point(6, 42);
            this.checkBoxTew.Name = "checkBoxTew";
            this.checkBoxTew.Size = new System.Drawing.Size(68, 17);
            this.checkBoxTew.TabIndex = 5;
            this.checkBoxTew.Text = "Вторник";
            this.checkBoxTew.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 65);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(94, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Понедельник";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // AddGroupClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 304);
            this.Controls.Add(this.groupBoxDaysofWeek);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.cbTime);
            this.Controls.Add(this.cbLearningForm);
            this.Controls.Add(this.cbDirection);
            this.Name = "AddGroupClass";
            this.Text = "AddGroupClass";
            this.groupBoxDaysofWeek.ResumeLayout(false);
            this.groupBoxDaysofWeek.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDirection;
        private System.Windows.Forms.ComboBox cbLearningForm;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox groupBoxDaysofWeek;
        private System.Windows.Forms.CheckBox cbMon;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBoxTew;
    }
}