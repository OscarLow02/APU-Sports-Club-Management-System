namespace Group4
{
    partial class Members_Home_Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCompetition = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.btnPerformance = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnCourse = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAdmExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCompetition);
            this.panel1.Controls.Add(this.btnFeedback);
            this.panel1.Controls.Add(this.btnPerformance);
            this.panel1.Controls.Add(this.btnSchedule);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnCourse);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(27, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 389);
            this.panel1.TabIndex = 10;
            // 
            // btnCompetition
            // 
            this.btnCompetition.BackColor = System.Drawing.SystemColors.Control;
            this.btnCompetition.FlatAppearance.BorderSize = 0;
            this.btnCompetition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompetition.Location = new System.Drawing.Point(0, 19);
            this.btnCompetition.Name = "btnCompetition";
            this.btnCompetition.Size = new System.Drawing.Size(169, 55);
            this.btnCompetition.TabIndex = 0;
            this.btnCompetition.Text = "Competitions";
            this.btnCompetition.UseVisualStyleBackColor = false;
            this.btnCompetition.Click += new System.EventHandler(this.btnCompetition_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.FlatAppearance.BorderSize = 0;
            this.btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeedback.Location = new System.Drawing.Point(0, 329);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(172, 38);
            this.btnFeedback.TabIndex = 5;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // btnPerformance
            // 
            this.btnPerformance.FlatAppearance.BorderSize = 0;
            this.btnPerformance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerformance.Location = new System.Drawing.Point(3, 91);
            this.btnPerformance.Name = "btnPerformance";
            this.btnPerformance.Size = new System.Drawing.Size(169, 35);
            this.btnPerformance.TabIndex = 1;
            this.btnPerformance.Text = "Performance";
            this.btnPerformance.UseVisualStyleBackColor = true;
            this.btnPerformance.Click += new System.EventHandler(this.btnPerformance_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.FlatAppearance.BorderSize = 0;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.Location = new System.Drawing.Point(0, 145);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(164, 47);
            this.btnSchedule.TabIndex = 2;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Location = new System.Drawing.Point(3, 271);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(169, 36);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnCourse
            // 
            this.btnCourse.FlatAppearance.BorderSize = 0;
            this.btnCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourse.Location = new System.Drawing.Point(0, 211);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(169, 35);
            this.btnCourse.TabIndex = 3;
            this.btnCourse.Text = "Course";
            this.btnCourse.UseVisualStyleBackColor = true;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(236, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1018, 519);
            this.panel3.TabIndex = 11;
            // 
            // btnAdmExit
            // 
            this.btnAdmExit.Location = new System.Drawing.Point(15, 535);
            this.btnAdmExit.Margin = new System.Windows.Forms.Padding(1);
            this.btnAdmExit.Name = "btnAdmExit";
            this.btnAdmExit.Size = new System.Drawing.Size(80, 28);
            this.btnAdmExit.TabIndex = 37;
            this.btnAdmExit.Text = "Logout";
            this.btnAdmExit.UseVisualStyleBackColor = true;
            this.btnAdmExit.Click += new System.EventHandler(this.btnAdmExit_Click);
            // 
            // Members_Home_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1266, 578);
            this.Controls.Add(this.btnAdmExit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Members_Home_Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Members_Home_Menu_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCompetition;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button btnPerformance;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAdmExit;
    }
}

