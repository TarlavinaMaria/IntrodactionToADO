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
            this.rbGroups = new System.Windows.Forms.RadioButton();
            this.rbStudent = new System.Windows.Forms.RadioButton();
            this.btChangeGroup = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbDirection = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxSearchStudent = new System.Windows.Forms.RichTextBox();
            this.lblStudCount = new System.Windows.Forms.Label();
            this.buttoAdd2 = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.tabPageGroups = new System.Windows.Forms.TabPage();
            this.lblGroupsCount = new System.Windows.Forms.Label();
            this.cbDirectionOnGroupTab = new System.Windows.Forms.ComboBox();
            this.btnGroupAdd = new System.Windows.Forms.Button();
            this.dataGridViewGroups = new System.Windows.Forms.DataGridView();
            this.tabPageTeachers = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.tabPageGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).BeginInit();
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
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageStudents);
            this.tabControl1.Controls.Add(this.tabPageGroups);
            this.tabControl1.Controls.Add(this.tabPageTeachers);
            this.tabControl1.Location = new System.Drawing.Point(12, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(951, 532);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPageStudents
            // 
            this.tabPageStudents.Controls.Add(this.rbGroups);
            this.tabPageStudents.Controls.Add(this.rbStudent);
            this.tabPageStudents.Controls.Add(this.btChangeGroup);
            this.tabPageStudents.Controls.Add(this.button1);
            this.tabPageStudents.Controls.Add(this.cbDirection);
            this.tabPageStudents.Controls.Add(this.label4);
            this.tabPageStudents.Controls.Add(this.label3);
            this.tabPageStudents.Controls.Add(this.label2);
            this.tabPageStudents.Controls.Add(this.buttonAddShedule);
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
            // rbGroups
            // 
            this.rbGroups.AutoSize = true;
            this.rbGroups.Location = new System.Drawing.Point(544, 118);
            this.rbGroups.Name = "rbGroups";
            this.rbGroups.Size = new System.Drawing.Size(62, 17);
            this.rbGroups.TabIndex = 15;
            this.rbGroups.TabStop = true;
            this.rbGroups.Text = "Группы";
            this.rbGroups.UseVisualStyleBackColor = true;
            this.rbGroups.CheckedChanged += new System.EventHandler(this.rbGroups_CheckedChanged);
            // 
            // rbStudent
            // 
            this.rbStudent.AutoSize = true;
            this.rbStudent.Location = new System.Drawing.Point(617, 119);
            this.rbStudent.Name = "rbStudent";
            this.rbStudent.Size = new System.Drawing.Size(73, 17);
            this.rbStudent.TabIndex = 15;
            this.rbStudent.TabStop = true;
            this.rbStudent.Text = "Студенты\r\n";
            this.rbStudent.UseVisualStyleBackColor = true;
            this.rbStudent.CheckedChanged += new System.EventHandler(this.rbStudent_CheckedChanged);
            // 
            // btChangeGroup
            // 
            this.btChangeGroup.Location = new System.Drawing.Point(798, 46);
            this.btChangeGroup.Name = "btChangeGroup";
            this.btChangeGroup.Size = new System.Drawing.Size(128, 23);
            this.btChangeGroup.TabIndex = 14;
            this.btChangeGroup.Text = "Смена группы";
            this.btChangeGroup.UseVisualStyleBackColor = true;
            this.btChangeGroup.Click += new System.EventHandler(this.btChangeGroup_Click);
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
            // cbDirection
            // 
            this.cbDirection.FormattingEnabled = true;
            this.cbDirection.Location = new System.Drawing.Point(7, 118);
            this.cbDirection.Name = "cbDirection";
            this.cbDirection.Size = new System.Drawing.Size(525, 21);
            this.cbDirection.TabIndex = 12;
            this.cbDirection.SelectedIndexChanged += new System.EventHandler(this.cbDirection_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Поиск студента:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 98);
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
            // richTextBoxSearchStudent
            // 
            this.richTextBoxSearchStudent.Location = new System.Drawing.Point(6, 72);
            this.richTextBoxSearchStudent.Name = "richTextBoxSearchStudent";
            this.richTextBoxSearchStudent.Size = new System.Drawing.Size(529, 23);
            this.richTextBoxSearchStudent.TabIndex = 5;
            this.richTextBoxSearchStudent.Text = "";
            this.richTextBoxSearchStudent.TextChanged += new System.EventHandler(this.richTextBoxSearchStudent_TextChanged);
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
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.Size = new System.Drawing.Size(930, 355);
            this.dgvStudents.TabIndex = 1;
            this.dgvStudents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellDoubleClick);
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
            // tabPageGroups
            // 
            this.tabPageGroups.Controls.Add(this.lblGroupsCount);
            this.tabPageGroups.Controls.Add(this.cbDirectionOnGroupTab);
            this.tabPageGroups.Controls.Add(this.btnGroupAdd);
            this.tabPageGroups.Controls.Add(this.dataGridViewGroups);
            this.tabPageGroups.Location = new System.Drawing.Point(4, 22);
            this.tabPageGroups.Name = "tabPageGroups";
            this.tabPageGroups.Size = new System.Drawing.Size(943, 506);
            this.tabPageGroups.TabIndex = 2;
            this.tabPageGroups.Text = "Группы";
            this.tabPageGroups.UseVisualStyleBackColor = true;
            // 
            // lblGroupsCount
            // 
            this.lblGroupsCount.AutoSize = true;
            this.lblGroupsCount.Location = new System.Drawing.Point(474, 11);
            this.lblGroupsCount.Name = "lblGroupsCount";
            this.lblGroupsCount.Size = new System.Drawing.Size(72, 13);
            this.lblGroupsCount.TabIndex = 3;
            this.lblGroupsCount.Text = "Кол-во групп";
            // 
            // cbDirectionOnGroupTab
            // 
            this.cbDirectionOnGroupTab.FormattingEnabled = true;
            this.cbDirectionOnGroupTab.Location = new System.Drawing.Point(4, 4);
            this.cbDirectionOnGroupTab.Name = "cbDirectionOnGroupTab";
            this.cbDirectionOnGroupTab.Size = new System.Drawing.Size(463, 21);
            this.cbDirectionOnGroupTab.TabIndex = 2;
            this.cbDirectionOnGroupTab.SelectedIndexChanged += new System.EventHandler(this.cbDirectionOnGroupTab_SelectedIndexChanged);
            // 
            // btnGroupAdd
            // 
            this.btnGroupAdd.Location = new System.Drawing.Point(854, 4);
            this.btnGroupAdd.Name = "btnGroupAdd";
            this.btnGroupAdd.Size = new System.Drawing.Size(75, 23);
            this.btnGroupAdd.TabIndex = 1;
            this.btnGroupAdd.Text = "Добавить";
            this.btnGroupAdd.UseVisualStyleBackColor = true;
            this.btnGroupAdd.Click += new System.EventHandler(this.btnGroupAdd_Click);
            // 
            // dataGridViewGroups
            // 
            this.dataGridViewGroups.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroups.Location = new System.Drawing.Point(4, 33);
            this.dataGridViewGroups.Name = "dataGridViewGroups";
            this.dataGridViewGroups.Size = new System.Drawing.Size(936, 473);
            this.dataGridViewGroups.TabIndex = 0;
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
            this.tabPageGroups.ResumeLayout(false);
            this.tabPageGroups.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).EndInit();
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
        private System.Windows.Forms.RichTextBox richTextBoxSearchStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDirection;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btChangeGroup;
        private System.Windows.Forms.RadioButton rbGroups;
        private System.Windows.Forms.RadioButton rbStudent;
        private System.Windows.Forms.TabPage tabPageGroups;
        private System.Windows.Forms.DataGridView dataGridViewGroups;
        private System.Windows.Forms.Button btnGroupAdd;
        private System.Windows.Forms.ComboBox cbDirectionOnGroupTab;
        private System.Windows.Forms.Label lblGroupsCount;
    }
}

