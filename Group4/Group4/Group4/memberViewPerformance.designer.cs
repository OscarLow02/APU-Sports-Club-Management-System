namespace Group4
{
    partial class memberViewPerformance
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
            this.listCompetition = new System.Windows.Forms.ListView();
            this.clmMemberID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listCompetition
            // 
            this.listCompetition.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmMemberID,
            this.clmName,
            this.clmScore,
            this.clmDate,
            this.clmDescription});
            this.listCompetition.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCompetition.HideSelection = false;
            this.listCompetition.Location = new System.Drawing.Point(21, 40);
            this.listCompetition.Name = "listCompetition";
            this.listCompetition.Size = new System.Drawing.Size(1140, 420);
            this.listCompetition.TabIndex = 1;
            this.listCompetition.UseCompatibleStateImageBehavior = false;
            this.listCompetition.View = System.Windows.Forms.View.Details;
            this.listCompetition.SelectedIndexChanged += new System.EventHandler(this.listCompetition_SelectedIndexChanged);
            // 
            // clmMemberID
            // 
            this.clmMemberID.DisplayIndex = 1;
            this.clmMemberID.Text = "MemberID";
            this.clmMemberID.Width = 225;
            // 
            // clmName
            // 
            this.clmName.DisplayIndex = 0;
            this.clmName.Text = "Name";
            this.clmName.Width = 164;
            // 
            // clmScore
            // 
            this.clmScore.Text = "Score";
            this.clmScore.Width = 158;
            // 
            // clmDate
            // 
            this.clmDate.Text = "Date";
            this.clmDate.Width = 118;
            // 
            // clmDescription
            // 
            this.clmDescription.Text = "Description";
            this.clmDescription.Width = 185;
            // 
            // memberViewPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1173, 502);
            this.Controls.Add(this.listCompetition);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "memberViewPerformance";
            this.Text = "memberViewPerformance";
            this.Load += new System.EventHandler(this.memberViewPerformance_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listCompetition;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader clmMemberID;
        private System.Windows.Forms.ColumnHeader clmScore;
        private System.Windows.Forms.ColumnHeader clmDate;
        private System.Windows.Forms.ColumnHeader clmDescription;
    }
}