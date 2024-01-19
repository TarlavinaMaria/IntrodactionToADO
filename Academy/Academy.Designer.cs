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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonAddShedule = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageStudents = new System.Windows.Forms.TabPage();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.tabPageTeachers = new System.Windows.Forms.TabPage();
            this.buttoAdd2 = new System.Windows.Forms.Button();
            this.lblStudCount = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(23, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(102, 21);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add Student";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonAddShedule
            // 
            this.buttonAddShedule.Location = new System.Drawing.Point(120, 12);
            this.buttonAddShedule.Name = "buttonAddShedule";
            this.buttonAddShedule.Size = new System.Drawing.Size(92, 21);
            this.buttonAddShedule.TabIndex = 3;
            this.buttonAddShedule.Text = "Add Schedule";
            this.buttonAddShedule.UseVisualStyleBackColor = true;
            this.buttonAddShedule.Click += new System.EventHandler(this.buttonAddShedule_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageStudents);
            this.tabControl1.Controls.Add(this.tabPageTeachers);
            this.tabControl1.Location = new System.Drawing.Point(12, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 493);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPageStudents
            // 
            this.tabPageStudents.Controls.Add(this.lblStudCount);
            this.tabPageStudents.Controls.Add(this.buttoAdd2);
            this.tabPageStudents.Controls.Add(this.dgvStudents);
            this.tabPageStudents.Controls.Add(this.cbGroup);
            this.tabPageStudents.Location = new System.Drawing.Point(4, 22);
            this.tabPageStudents.Name = "tabPageStudents";
            this.tabPageStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudents.Size = new System.Drawing.Size(767, 467);
            this.tabPageStudents.TabIndex = 0;
            this.tabPageStudents.Text = "Студенты";
            this.tabPageStudents.UseVisualStyleBackColor = true;
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(7, 35);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(754, 426);
            this.dgvStudents.TabIndex = 1;
            // 
            // cbGroup
            // 
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.Location = new System.Drawing.Point(7, 7);
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
            this.tabPageTeachers.Size = new System.Drawing.Size(767, 439);
            this.tabPageTeachers.TabIndex = 1;
            this.tabPageTeachers.Text = "Преподаватели";
            this.tabPageTeachers.UseVisualStyleBackColor = true;
            // 
            // buttoAdd2
            // 
            this.buttoAdd2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttoAdd2.Location = new System.Drawing.Point(686, 5);
            this.buttoAdd2.Name = "buttoAdd2";
            this.buttoAdd2.Size = new System.Drawing.Size(75, 23);
            this.buttoAdd2.TabIndex = 3;
            this.buttoAdd2.Text = "Добавить";
            this.buttoAdd2.UseVisualStyleBackColor = true;
            this.buttoAdd2.Click += new System.EventHandler(this.buttoAdd2_Click);
            // 
            // lblStudCount
            // 
            this.lblStudCount.AutoSize = true;
            this.lblStudCount.Location = new System.Drawing.Point(542, 10);
            this.lblStudCount.Name = "lblStudCount";
            this.lblStudCount.Size = new System.Drawing.Size(101, 13);
            this.lblStudCount.TabIndex = 4;
            this.lblStudCount.Text = "Кол-во студентов: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonAddShedule);
            this.Controls.Add(this.buttonAdd);
            this.Name = "Form1";
            this.Text = "Academy PD_212";
            this.tabControl1.ResumeLayout(false);
            this.tabPageStudents.ResumeLayout(false);
            this.tabPageStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonAddShedule;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageStudents;
        private System.Windows.Forms.TabPage tabPageTeachers;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.ComboBox cbGroup;
        private System.Windows.Forms.Button buttoAdd2;
        private System.Windows.Forms.Label lblStudCount;
    }
}

