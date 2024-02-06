namespace Academy
{
    partial class GroupInfo
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
            this.rtbGroupInfo = new System.Windows.Forms.RichTextBox();
            this.rtbSpecInfo = new System.Windows.Forms.RichTextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.rtbDayInfo = new System.Windows.Forms.RichTextBox();
            this.rtbTime = new System.Windows.Forms.RichTextBox();
            this.btnGroupChange = new System.Windows.Forms.Button();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.clbWeekChange = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // rtbGroupInfo
            // 
            this.rtbGroupInfo.Location = new System.Drawing.Point(12, 12);
            this.rtbGroupInfo.Name = "rtbGroupInfo";
            this.rtbGroupInfo.Size = new System.Drawing.Size(510, 28);
            this.rtbGroupInfo.TabIndex = 5;
            this.rtbGroupInfo.Text = "Группа";
            // 
            // rtbSpecInfo
            // 
            this.rtbSpecInfo.Location = new System.Drawing.Point(12, 46);
            this.rtbSpecInfo.Name = "rtbSpecInfo";
            this.rtbSpecInfo.Size = new System.Drawing.Size(510, 28);
            this.rtbSpecInfo.TabIndex = 4;
            this.rtbSpecInfo.Text = "Специальность";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(12, 134);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(240, 23);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // rtbDayInfo
            // 
            this.rtbDayInfo.Location = new System.Drawing.Point(12, 80);
            this.rtbDayInfo.Name = "rtbDayInfo";
            this.rtbDayInfo.Size = new System.Drawing.Size(240, 21);
            this.rtbDayInfo.TabIndex = 8;
            this.rtbDayInfo.Text = "Дни обучения";
            // 
            // rtbTime
            // 
            this.rtbTime.Location = new System.Drawing.Point(12, 107);
            this.rtbTime.Name = "rtbTime";
            this.rtbTime.Size = new System.Drawing.Size(240, 21);
            this.rtbTime.TabIndex = 7;
            this.rtbTime.Text = "Время";
            // 
            // btnGroupChange
            // 
            this.btnGroupChange.Location = new System.Drawing.Point(259, 134);
            this.btnGroupChange.Name = "btnGroupChange";
            this.btnGroupChange.Size = new System.Drawing.Size(263, 23);
            this.btnGroupChange.TabIndex = 9;
            this.btnGroupChange.Text = "Изменить";
            this.btnGroupChange.UseVisualStyleBackColor = true;
            this.btnGroupChange.Click += new System.EventHandler(this.btnGroupChange_Click);
            // 
            // cbTime
            // 
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Location = new System.Drawing.Point(258, 107);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(263, 21);
            this.cbTime.TabIndex = 10;
            this.cbTime.Text = "Нажмите, чтобы поменять время обучения";
            // 
            // clbWeekChange
            // 
            this.clbWeekChange.CheckOnClick = true;
            this.clbWeekChange.ColumnWidth = 35;
            this.clbWeekChange.FormattingEnabled = true;
            this.clbWeekChange.Items.AddRange(new object[] {
            "Пн",
            "Вт",
            "Ср",
            "Чт",
            "Пт",
            "Сб",
            "Вс"});
            this.clbWeekChange.Location = new System.Drawing.Point(259, 80);
            this.clbWeekChange.MultiColumn = true;
            this.clbWeekChange.Name = "clbWeekChange";
            this.clbWeekChange.Size = new System.Drawing.Size(262, 19);
            this.clbWeekChange.TabIndex = 11;
            // 
            // GroupInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 165);
            this.Controls.Add(this.clbWeekChange);
            this.Controls.Add(this.cbTime);
            this.Controls.Add(this.btnGroupChange);
            this.Controls.Add(this.rtbDayInfo);
            this.Controls.Add(this.rtbTime);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.rtbGroupInfo);
            this.Controls.Add(this.rtbSpecInfo);
            this.Name = "GroupInfo";
            this.Text = "GroupInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbGroupInfo;
        private System.Windows.Forms.RichTextBox rtbSpecInfo;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.RichTextBox rtbDayInfo;
        private System.Windows.Forms.RichTextBox rtbTime;
        private System.Windows.Forms.Button btnGroupChange;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.CheckedListBox clbWeekChange;
    }
}