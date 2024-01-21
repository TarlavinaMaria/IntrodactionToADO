namespace Academy
{
    partial class ChangeGroup
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
            this.comboBoxSelentStudentChange = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbChangeGroup = new System.Windows.Forms.ComboBox();
            this.bnChange = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvGroupChange = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupChange)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSelentStudentChange
            // 
            this.comboBoxSelentStudentChange.FormattingEnabled = true;
            this.comboBoxSelentStudentChange.Location = new System.Drawing.Point(24, 33);
            this.comboBoxSelentStudentChange.Name = "comboBoxSelentStudentChange";
            this.comboBoxSelentStudentChange.Size = new System.Drawing.Size(292, 21);
            this.comboBoxSelentStudentChange.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите студента";
            // 
            // cbChangeGroup
            // 
            this.cbChangeGroup.FormattingEnabled = true;
            this.cbChangeGroup.Location = new System.Drawing.Point(24, 78);
            this.cbChangeGroup.Name = "cbChangeGroup";
            this.cbChangeGroup.Size = new System.Drawing.Size(292, 21);
            this.cbChangeGroup.TabIndex = 2;
            // 
            // bnChange
            // 
            this.bnChange.Location = new System.Drawing.Point(24, 115);
            this.bnChange.Name = "bnChange";
            this.bnChange.Size = new System.Drawing.Size(292, 23);
            this.bnChange.TabIndex = 3;
            this.bnChange.Text = "Поменять группу";
            this.bnChange.UseVisualStyleBackColor = true;
            this.bnChange.Click += new System.EventHandler(this.bnChange_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(24, 145);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(292, 23);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выберите группу";
            // 
            // dgvGroupChange
            // 
            this.dgvGroupChange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupChange.Location = new System.Drawing.Point(24, 174);
            this.dgvGroupChange.Name = "dgvGroupChange";
            this.dgvGroupChange.Size = new System.Drawing.Size(764, 303);
            this.dgvGroupChange.TabIndex = 6;
            // 
            // ChangeGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.dgvGroupChange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.bnChange);
            this.Controls.Add(this.cbChangeGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSelentStudentChange);
            this.Name = "ChangeGroup";
            this.Text = "ChangeGroup";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupChange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSelentStudentChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbChangeGroup;
        private System.Windows.Forms.Button bnChange;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvGroupChange;
    }
}