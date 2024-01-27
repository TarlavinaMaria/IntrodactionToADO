﻿namespace Academy
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
            this.tbGroupName = new System.Windows.Forms.TextBox();
            this.lcbWeek = new System.Windows.Forms.CheckedListBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbDirection
            // 
            this.cbDirection.FormattingEnabled = true;
            this.cbDirection.Location = new System.Drawing.Point(13, 44);
            this.cbDirection.Name = "cbDirection";
            this.cbDirection.Size = new System.Drawing.Size(409, 21);
            this.cbDirection.TabIndex = 0;
            this.cbDirection.Text = "Направление обучения";
            // 
            // cbLearningForm
            // 
            this.cbLearningForm.FormattingEnabled = true;
            this.cbLearningForm.Location = new System.Drawing.Point(12, 12);
            this.cbLearningForm.Name = "cbLearningForm";
            this.cbLearningForm.Size = new System.Drawing.Size(409, 21);
            this.cbLearningForm.TabIndex = 1;
            this.cbLearningForm.Text = "Форма обучения";
            // 
            // cbTime
            // 
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Location = new System.Drawing.Point(12, 71);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(409, 21);
            this.cbTime.TabIndex = 2;
            this.cbTime.Text = "Время обучения";
            // 
            // tbGroupName
            // 
            this.tbGroupName.Location = new System.Drawing.Point(12, 130);
            this.tbGroupName.Name = "tbGroupName";
            this.tbGroupName.Size = new System.Drawing.Size(409, 20);
            this.tbGroupName.TabIndex = 3;
            this.tbGroupName.Text = "Название группы";
            // 
            // lcbWeek
            // 
            this.lcbWeek.CheckOnClick = true;
            this.lcbWeek.ColumnWidth = 55;
            this.lcbWeek.FormattingEnabled = true;
            this.lcbWeek.Items.AddRange(new object[] {
            "Пн",
            "Вт",
            "Ср",
            "Чт",
            "Пт",
            "Сб",
            "Вс"});
            this.lcbWeek.Location = new System.Drawing.Point(12, 98);
            this.lcbWeek.MultiColumn = true;
            this.lcbWeek.Name = "lcbWeek";
            this.lcbWeek.Size = new System.Drawing.Size(409, 19);
            this.lcbWeek.TabIndex = 5;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(316, 156);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(107, 23);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Сгенерировать";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // AddGroupClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 191);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lcbWeek);
            this.Controls.Add(this.tbGroupName);
            this.Controls.Add(this.cbTime);
            this.Controls.Add(this.cbLearningForm);
            this.Controls.Add(this.cbDirection);
            this.Name = "AddGroupClass";
            this.Text = "AddGroupClass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDirection;
        private System.Windows.Forms.ComboBox cbLearningForm;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.TextBox tbGroupName;
        private System.Windows.Forms.CheckedListBox lcbWeek;
        private System.Windows.Forms.Button btnGenerate;
    }
}