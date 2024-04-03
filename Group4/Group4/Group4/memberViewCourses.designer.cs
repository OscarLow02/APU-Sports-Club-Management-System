namespace Group4
{
    partial class memberViewCourses
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
            this.btnPay = new System.Windows.Forms.Button();
            this.btnUnenrol = new System.Windows.Forms.Button();
            this.btnEnrol = new System.Windows.Forms.Button();
            this.lblEnrol = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(586, 131);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(324, 50);
            this.btnPay.TabIndex = 11;
            this.btnPay.Text = "Make Payment";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnUnenrol
            // 
            this.btnUnenrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnenrol.Location = new System.Drawing.Point(746, 199);
            this.btnUnenrol.Name = "btnUnenrol";
            this.btnUnenrol.Size = new System.Drawing.Size(169, 50);
            this.btnUnenrol.TabIndex = 10;
            this.btnUnenrol.Text = "Unenrol";
            this.btnUnenrol.UseVisualStyleBackColor = true;
            this.btnUnenrol.Click += new System.EventHandler(this.btnUnenrol_Click);
            // 
            // btnEnrol
            // 
            this.btnEnrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnrol.Location = new System.Drawing.Point(586, 199);
            this.btnEnrol.Name = "btnEnrol";
            this.btnEnrol.Size = new System.Drawing.Size(140, 50);
            this.btnEnrol.TabIndex = 9;
            this.btnEnrol.Text = "Enrol";
            this.btnEnrol.UseVisualStyleBackColor = true;
            this.btnEnrol.Click += new System.EventHandler(this.btnEnrol_Click);
            // 
            // lblEnrol
            // 
            this.lblEnrol.AutoSize = true;
            this.lblEnrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnrol.Location = new System.Drawing.Point(41, 306);
            this.lblEnrol.Name = "lblEnrol";
            this.lblEnrol.Size = new System.Drawing.Size(405, 51);
            this.lblEnrol.TabIndex = 8;
            this.lblEnrol.Text = "You are enrolled in: ";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(43, 66);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(158, 42);
            this.lblCourse.TabIndex = 7;
            this.lblCourse.Text = "Courses";
            // 
            // lstCourses
            // 
            this.lstCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.ItemHeight = 38;
            this.lstCourses.Items.AddRange(new object[] {
            "Beginner (RM50 / month)",
            "Intermediate (RM70 / month)",
            "Advanced (RM90 / month)"});
            this.lstCourses.Location = new System.Drawing.Point(50, 131);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(490, 118);
            this.lstCourses.TabIndex = 6;
            // 
            // memberViewCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(983, 424);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnUnenrol);
            this.Controls.Add(this.btnEnrol);
            this.Controls.Add(this.lblEnrol);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lstCourses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "memberViewCourses";
            this.Text = "memberViewCourses";
            this.Load += new System.EventHandler(this.memberViewCourses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnUnenrol;
        private System.Windows.Forms.Button btnEnrol;
        private System.Windows.Forms.Label lblEnrol;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ListBox lstCourses;
    }
}