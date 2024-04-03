namespace Group4
{
    partial class frmViewStudent
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
            this.lstStudent = new System.Windows.Forms.ListView();
            this.student_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.student_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstStudent
            // 
            this.lstStudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.student_id,
            this.student_name});
            this.lstStudent.HideSelection = false;
            this.lstStudent.Location = new System.Drawing.Point(12, 52);
            this.lstStudent.Name = "lstStudent";
            this.lstStudent.Size = new System.Drawing.Size(476, 455);
            this.lstStudent.TabIndex = 0;
            this.lstStudent.UseCompatibleStateImageBehavior = false;
            this.lstStudent.View = System.Windows.Forms.View.Details;
            // 
            // student_id
            // 
            this.student_id.Text = "Student ID";
            this.student_id.Width = 163;
            // 
            // student_name
            // 
            this.student_name.Text = "Name";
            this.student_name.Width = 786;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(135, 27);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Student List";
            // 
            // frmViewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(508, 531);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lstStudent);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmViewStudent";
            this.Text = "View Student List";
            this.Load += new System.EventHandler(this.frmViewStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstStudent;
        private System.Windows.Forms.ColumnHeader student_id;
        private System.Windows.Forms.ColumnHeader student_name;
        private System.Windows.Forms.Label lblTitle;
    }
}