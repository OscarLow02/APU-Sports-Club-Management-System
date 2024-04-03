namespace Group4
{
    partial class memberViewSchedule
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
            this.lstSchedule = new System.Windows.Forms.ListView();
            this.CoachName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CoachPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Level = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCourse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Location = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstSchedule
            // 
            this.lstSchedule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CoachName,
            this.CoachPhone,
            this.Level,
            this.clmCourse,
            this.Date,
            this.Time,
            this.Location});
            this.lstSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSchedule.HideSelection = false;
            this.lstSchedule.Location = new System.Drawing.Point(45, 60);
            this.lstSchedule.Name = "lstSchedule";
            this.lstSchedule.Size = new System.Drawing.Size(971, 398);
            this.lstSchedule.TabIndex = 4;
            this.lstSchedule.UseCompatibleStateImageBehavior = false;
            this.lstSchedule.View = System.Windows.Forms.View.Details;
            // 
            // CoachName
            // 
            this.CoachName.Text = "CoachName";
            this.CoachName.Width = 172;
            // 
            // CoachPhone
            // 
            this.CoachPhone.Text = "CoachPhone";
            this.CoachPhone.Width = 177;
            // 
            // Level
            // 
            this.Level.Text = "Level";
            this.Level.Width = 112;
            // 
            // clmCourse
            // 
            this.clmCourse.Text = "Course";
            this.clmCourse.Width = 160;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 116;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 118;
            // 
            // Location
            // 
            this.Location.Text = "Location";
            this.Location.Width = 138;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Training";
            // 
            // memberViewSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1057, 482);
            this.Controls.Add(this.lstSchedule);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "memberViewSchedule";
            this.Text = "memberViewSchedule";
            this.Load += new System.EventHandler(this.memberViewSchedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstSchedule;
        private System.Windows.Forms.ColumnHeader CoachName;
        private System.Windows.Forms.ColumnHeader CoachPhone;
        private System.Windows.Forms.ColumnHeader Level;
        private System.Windows.Forms.ColumnHeader clmCourse;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader Location;
        private System.Windows.Forms.Label label1;
    }
}