namespace Academy
{
    partial class StudentInfo
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.rtbFullName = new System.Windows.Forms.RichTextBox();
            this.rtbSpec = new System.Windows.Forms.RichTextBox();
            this.rtbGroup = new System.Windows.Forms.RichTextBox();
            this.rtbAttendance = new System.Windows.Forms.RichTextBox();
            this.rtbGrade = new System.Windows.Forms.RichTextBox();
            this.pictureBoxStudent = new System.Windows.Forms.PictureBox();
            this.buttonAddPhoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(12, 183);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // rtbFullName
            // 
            this.rtbFullName.Location = new System.Drawing.Point(13, 13);
            this.rtbFullName.Name = "rtbFullName";
            this.rtbFullName.Size = new System.Drawing.Size(261, 28);
            this.rtbFullName.TabIndex = 1;
            this.rtbFullName.Text = "ФИО";
            // 
            // rtbSpec
            // 
            this.rtbSpec.Location = new System.Drawing.Point(12, 81);
            this.rtbSpec.Name = "rtbSpec";
            this.rtbSpec.Size = new System.Drawing.Size(262, 28);
            this.rtbSpec.TabIndex = 2;
            this.rtbSpec.Text = "Специальность";
            // 
            // rtbGroup
            // 
            this.rtbGroup.Location = new System.Drawing.Point(12, 47);
            this.rtbGroup.Name = "rtbGroup";
            this.rtbGroup.Size = new System.Drawing.Size(262, 28);
            this.rtbGroup.TabIndex = 3;
            this.rtbGroup.Text = "Группа";
            // 
            // rtbAttendance
            // 
            this.rtbAttendance.Location = new System.Drawing.Point(12, 115);
            this.rtbAttendance.Name = "rtbAttendance";
            this.rtbAttendance.Size = new System.Drawing.Size(262, 28);
            this.rtbAttendance.TabIndex = 4;
            this.rtbAttendance.Text = "Посещаемость";
            // 
            // rtbGrade
            // 
            this.rtbGrade.Location = new System.Drawing.Point(12, 149);
            this.rtbGrade.Name = "rtbGrade";
            this.rtbGrade.Size = new System.Drawing.Size(262, 28);
            this.rtbGrade.TabIndex = 5;
            this.rtbGrade.Text = "Успеваемость";
            // 
            // pictureBoxStudent
            // 
            this.pictureBoxStudent.Location = new System.Drawing.Point(301, 13);
            this.pictureBoxStudent.Name = "pictureBoxStudent";
            this.pictureBoxStudent.Size = new System.Drawing.Size(244, 176);
            this.pictureBoxStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStudent.TabIndex = 6;
            this.pictureBoxStudent.TabStop = false;
            // 
            // buttonAddPhoto
            // 
            this.buttonAddPhoto.Location = new System.Drawing.Point(301, 196);
            this.buttonAddPhoto.Name = "buttonAddPhoto";
            this.buttonAddPhoto.Size = new System.Drawing.Size(244, 23);
            this.buttonAddPhoto.TabIndex = 7;
            this.buttonAddPhoto.Text = "Добавить фото";
            this.buttonAddPhoto.UseVisualStyleBackColor = true;
            this.buttonAddPhoto.Click += new System.EventHandler(this.buttonAddPhoto_Click);
            // 
            // StudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 221);
            this.Controls.Add(this.buttonAddPhoto);
            this.Controls.Add(this.pictureBoxStudent);
            this.Controls.Add(this.rtbGrade);
            this.Controls.Add(this.rtbAttendance);
            this.Controls.Add(this.rtbGroup);
            this.Controls.Add(this.rtbSpec);
            this.Controls.Add(this.rtbFullName);
            this.Controls.Add(this.buttonExit);
            this.Name = "StudentInfo";
            this.Text = "StudentInfo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.RichTextBox rtbFullName;
        private System.Windows.Forms.RichTextBox rtbSpec;
        private System.Windows.Forms.RichTextBox rtbGroup;
        private System.Windows.Forms.RichTextBox rtbAttendance;
        private System.Windows.Forms.RichTextBox rtbGrade;
        private System.Windows.Forms.PictureBox pictureBoxStudent;
        private System.Windows.Forms.Button buttonAddPhoto;
    }
}