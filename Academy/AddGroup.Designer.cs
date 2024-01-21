namespace Academy
{
    partial class AddGroup
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
            this.rtbGroupName = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSpecSelect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btAddGroup = new System.Windows.Forms.Button();
            this.bnExit = new System.Windows.Forms.Button();
            this.dgvGroup = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbGroupName
            // 
            this.rtbGroupName.Location = new System.Drawing.Point(12, 29);
            this.rtbGroupName.Name = "rtbGroupName";
            this.rtbGroupName.Size = new System.Drawing.Size(175, 27);
            this.rtbGroupName.TabIndex = 0;
            this.rtbGroupName.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите название группы";
            // 
            // cbSpecSelect
            // 
            this.cbSpecSelect.FormattingEnabled = true;
            this.cbSpecSelect.Location = new System.Drawing.Point(12, 86);
            this.cbSpecSelect.Name = "cbSpecSelect";
            this.cbSpecSelect.Size = new System.Drawing.Size(175, 21);
            this.cbSpecSelect.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите специальность";
            // 
            // btAddGroup
            // 
            this.btAddGroup.Location = new System.Drawing.Point(12, 122);
            this.btAddGroup.Name = "btAddGroup";
            this.btAddGroup.Size = new System.Drawing.Size(163, 23);
            this.btAddGroup.TabIndex = 4;
            this.btAddGroup.Text = "Добавить специальность";
            this.btAddGroup.UseVisualStyleBackColor = true;
            this.btAddGroup.Click += new System.EventHandler(this.btAddGroup_Click);
            // 
            // bnExit
            // 
            this.bnExit.Location = new System.Drawing.Point(12, 151);
            this.bnExit.Name = "bnExit";
            this.bnExit.Size = new System.Drawing.Size(161, 23);
            this.bnExit.TabIndex = 5;
            this.bnExit.Text = "Выход";
            this.bnExit.UseVisualStyleBackColor = true;
            this.bnExit.Click += new System.EventHandler(this.bnExit_Click);
            // 
            // dgvGroup
            // 
            this.dgvGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroup.Location = new System.Drawing.Point(214, 13);
            this.dgvGroup.Name = "dgvGroup";
            this.dgvGroup.Size = new System.Drawing.Size(526, 161);
            this.dgvGroup.TabIndex = 6;
            // 
            // AddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 191);
            this.Controls.Add(this.dgvGroup);
            this.Controls.Add(this.bnExit);
            this.Controls.Add(this.btAddGroup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSpecSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbGroupName);
            this.Name = "AddGroup";
            this.Text = "AddGroup";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbGroupName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSpecSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAddGroup;
        private System.Windows.Forms.Button bnExit;
        private System.Windows.Forms.DataGridView dgvGroup;
    }
}