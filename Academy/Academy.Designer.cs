namespace Academy
{
    partial class Form1
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
            this.buttonAddShedule = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageStudents = new System.Windows.Forms.TabPage();
            this.cbSpecSelect = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStudCountSpec = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.richTextBoxSearchStudent = new System.Windows.Forms.RichTextBox();
            this.lblStudCount = new System.Windows.Forms.Label();
            this.buttoAdd2 = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.tabPageTeachers = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddShedule
            // 
            this.buttonAddShedule.Location = new System.Drawing.Point(797, 22);
            this.buttonAddShedule.Name = "buttonAddShedule";
            this.buttonAddShedule.Size = new System.Drawing.Size(129, 21);
            this.buttonAddShedule.TabIndex = 3;
            this.buttonAddShedule.Text = "Добавить расписание";
            this.buttonAddShedule.UseVisualStyleBackColor = true;
            this.buttonAddShedule.Click += new System.EventHandler(this.buttonAddShedule_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageStudents);
            this.tabControl1.Controls.Add(this.tabPageTeachers);
            this.tabControl1.Location = new System.Drawing.Point(12, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(951, 532);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPageStudents
            // 
            this.tabPageStudents.Controls.Add(this.button1);
            this.tabPageStudents.Controls.Add(this.cbSpecSelect);
            this.tabPageStudents.Controls.Add(this.label4);
            this.tabPageStudents.Controls.Add(this.label3);
            this.tabPageStudents.Controls.Add(this.label2);
            this.tabPageStudents.Controls.Add(this.lblStudCountSpec);
            this.tabPageStudents.Controls.Add(this.buttonAddShedule);
            this.tabPageStudents.Controls.Add(this.buttonSearch);
            this.tabPageStudents.Controls.Add(this.richTextBoxSearchStudent);
            this.tabPageStudents.Controls.Add(this.lblStudCount);
            this.tabPageStudents.Controls.Add(this.buttoAdd2);
            this.tabPageStudents.Controls.Add(this.dgvStudents);
            this.tabPageStudents.Controls.Add(this.cbGroup);
            this.tabPageStudents.Location = new System.Drawing.Point(4, 22);
            this.tabPageStudents.Name = "tabPageStudents";
            this.tabPageStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudents.Size = new System.Drawing.Size(943, 506);
            this.tabPageStudents.TabIndex = 0;
            this.tabPageStudents.Text = "Студенты";
            this.tabPageStudents.UseVisualStyleBackColor = true;
            // 
            // cbSpecSelect
            // 
            this.cbSpecSelect.FormattingEnabled = true;
            this.cbSpecSelect.Location = new System.Drawing.Point(7, 118);
            this.cbSpecSelect.Name = "cbSpecSelect";
            this.cbSpecSelect.Size = new System.Drawing.Size(525, 21);
            this.cbSpecSelect.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Поиск студента:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Выбор группы для специальности: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Выбор группы: ";
            // 
            // lblStudCountSpec
            // 
            this.lblStudCountSpec.AutoSize = true;
            this.lblStudCountSpec.Location = new System.Drawing.Point(551, 118);
            this.lblStudCountSpec.Name = "lblStudCountSpec";
            this.lblStudCountSpec.Size = new System.Drawing.Size(101, 13);
            this.lblStudCountSpec.TabIndex = 8;
            this.lblStudCountSpec.Text = "Кол-во студентов: ";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(544, 70);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(146, 23);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Поиск студента";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // richTextBoxSearchStudent
            // 
            this.richTextBoxSearchStudent.Location = new System.Drawing.Point(3, 72);
            this.richTextBoxSearchStudent.Name = "richTextBoxSearchStudent";
            this.richTextBoxSearchStudent.Size = new System.Drawing.Size(529, 23);
            this.richTextBoxSearchStudent.TabIndex = 5;
            this.richTextBoxSearchStudent.Text = "";
            // 
            // lblStudCount
            // 
            this.lblStudCount.AutoSize = true;
            this.lblStudCount.Location = new System.Drawing.Point(541, 23);
            this.lblStudCount.Name = "lblStudCount";
            this.lblStudCount.Size = new System.Drawing.Size(101, 13);
            this.lblStudCount.TabIndex = 4;
            this.lblStudCount.Text = "Кол-во студентов: ";
            // 
            // buttoAdd2
            // 
            this.buttoAdd2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttoAdd2.Location = new System.Drawing.Point(661, 21);
            this.buttoAdd2.Name = "buttoAdd2";
            this.buttoAdd2.Size = new System.Drawing.Size(130, 23);
            this.buttoAdd2.TabIndex = 3;
            this.buttoAdd2.Text = "Добавить студента";
            this.buttoAdd2.UseVisualStyleBackColor = true;
            this.buttoAdd2.Click += new System.EventHandler(this.buttoAdd2_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(6, 145);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(930, 355);
            this.dgvStudents.TabIndex = 1;
            // 
            // cbGroup
            // 
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.Location = new System.Drawing.Point(6, 20);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(529, 21);
            this.cbGroup.TabIndex = 0;
            this.cbGroup.SelectedIndexChanged += new System.EventHandler(this.cbGroup_SelectedIndexChanged);
            // 
            // tabPageTeachers
            // 
            this.tabPageTeachers.Location = new System.Drawing.Point(4, 22);
            this.tabPageTeachers.Name = "tabPageTeachers";
            this.tabPageTeachers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTeachers.Size = new System.Drawing.Size(943, 506);
            this.tabPageTeachers.TabIndex = 1;
            this.tabPageTeachers.Text = "Преподаватели";
            this.tabPageTeachers.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(661, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Добавить группу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 544);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Academy PD_212";
            this.tabControl1.ResumeLayout(false);
            this.tabPageStudents.ResumeLayout(false);
            this.tabPageStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAddShedule;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageStudents;
        private System.Windows.Forms.TabPage tabPageTeachers;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.ComboBox cbGroup;
        private System.Windows.Forms.Button buttoAdd2;
        private System.Windows.Forms.Label lblStudCount;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.RichTextBox richTextBoxSearchStudent;
        private System.Windows.Forms.Label lblStudCountSpec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSpecSelect;
        private System.Windows.Forms.Button button1;
    }
}

