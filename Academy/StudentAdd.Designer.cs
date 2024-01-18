namespace Academy
{
    partial class StudentAdd
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
            this.last_name_text = new System.Windows.Forms.Label();
            this.first_name_text = new System.Windows.Forms.Label();
            this.last_name_input = new System.Windows.Forms.TextBox();
            this.first_name_input = new System.Windows.Forms.TextBox();
            this.middle_name_input = new System.Windows.Forms.TextBox();
            this.middle_name_text = new System.Windows.Forms.Label();
            this.birth_date_text = new System.Windows.Forms.Label();
            this.birth_date_input = new System.Windows.Forms.TextBox();
            this.group_input = new System.Windows.Forms.TextBox();
            this.group_text = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // last_name_text
            // 
            this.last_name_text.AutoSize = true;
            this.last_name_text.Location = new System.Drawing.Point(12, 9);
            this.last_name_text.Name = "last_name_text";
            this.last_name_text.Size = new System.Drawing.Size(56, 13);
            this.last_name_text.TabIndex = 1;
            this.last_name_text.Text = "Фамилия";
            // 
            // first_name_text
            // 
            this.first_name_text.AutoSize = true;
            this.first_name_text.Location = new System.Drawing.Point(12, 51);
            this.first_name_text.Name = "first_name_text";
            this.first_name_text.Size = new System.Drawing.Size(29, 13);
            this.first_name_text.TabIndex = 2;
            this.first_name_text.Text = "Имя";
            // 
            // last_name_input
            // 
            this.last_name_input.Location = new System.Drawing.Point(15, 26);
            this.last_name_input.Name = "last_name_input";
            this.last_name_input.Size = new System.Drawing.Size(303, 20);
            this.last_name_input.TabIndex = 3;
            // 
            // first_name_input
            // 
            this.first_name_input.Location = new System.Drawing.Point(15, 67);
            this.first_name_input.Name = "first_name_input";
            this.first_name_input.Size = new System.Drawing.Size(303, 20);
            this.first_name_input.TabIndex = 4;
            // 
            // middle_name_input
            // 
            this.middle_name_input.Location = new System.Drawing.Point(15, 109);
            this.middle_name_input.Name = "middle_name_input";
            this.middle_name_input.Size = new System.Drawing.Size(301, 20);
            this.middle_name_input.TabIndex = 5;
            // 
            // middle_name_text
            // 
            this.middle_name_text.AutoSize = true;
            this.middle_name_text.Location = new System.Drawing.Point(12, 90);
            this.middle_name_text.Name = "middle_name_text";
            this.middle_name_text.Size = new System.Drawing.Size(54, 13);
            this.middle_name_text.TabIndex = 6;
            this.middle_name_text.Text = "Отчество";
            // 
            // birth_date_text
            // 
            this.birth_date_text.AutoSize = true;
            this.birth_date_text.Location = new System.Drawing.Point(12, 132);
            this.birth_date_text.Name = "birth_date_text";
            this.birth_date_text.Size = new System.Drawing.Size(146, 13);
            this.birth_date_text.TabIndex = 7;
            this.birth_date_text.Text = "Дата рождения, YY-MM-DD";
            // 
            // birth_date_input
            // 
            this.birth_date_input.Location = new System.Drawing.Point(15, 148);
            this.birth_date_input.Name = "birth_date_input";
            this.birth_date_input.Size = new System.Drawing.Size(301, 20);
            this.birth_date_input.TabIndex = 8;
            // 
            // group_input
            // 
            this.group_input.Location = new System.Drawing.Point(15, 187);
            this.group_input.Name = "group_input";
            this.group_input.Size = new System.Drawing.Size(303, 20);
            this.group_input.TabIndex = 10;
            // 
            // group_text
            // 
            this.group_text.AutoSize = true;
            this.group_text.Location = new System.Drawing.Point(12, 171);
            this.group_text.Name = "group_text";
            this.group_text.Size = new System.Drawing.Size(42, 13);
            this.group_text.TabIndex = 9;
            this.group_text.Text = "Группа";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(15, 226);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(303, 23);
            this.Add.TabIndex = 11;
            this.Add.Text = "Добавить студента";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(15, 255);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(301, 23);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // StudentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 289);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.group_input);
            this.Controls.Add(this.group_text);
            this.Controls.Add(this.birth_date_input);
            this.Controls.Add(this.birth_date_text);
            this.Controls.Add(this.middle_name_text);
            this.Controls.Add(this.middle_name_input);
            this.Controls.Add(this.first_name_input);
            this.Controls.Add(this.last_name_input);
            this.Controls.Add(this.first_name_text);
            this.Controls.Add(this.last_name_text);
            this.Name = "StudentAdd";
            this.Text = "StudentAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label last_name_text;
        private System.Windows.Forms.Label first_name_text;
        private System.Windows.Forms.TextBox last_name_input;
        private System.Windows.Forms.TextBox first_name_input;
        private System.Windows.Forms.TextBox middle_name_input;
        private System.Windows.Forms.Label middle_name_text;
        private System.Windows.Forms.Label birth_date_text;
        private System.Windows.Forms.TextBox birth_date_input;
        private System.Windows.Forms.TextBox group_input;
        private System.Windows.Forms.Label group_text;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button buttonExit;
    }
}