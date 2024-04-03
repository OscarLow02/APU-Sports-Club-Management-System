namespace Group4
{
    partial class memberViewCompetitions
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
            this.listCompetitions = new System.Windows.Forms.ListView();
            this.clmCompetitionID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmVenue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listCompetitions
            // 
            this.listCompetitions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listCompetitions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmCompetitionID,
            this.clmName,
            this.clmDateTime,
            this.clmVenue});
            this.listCompetitions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCompetitions.HideSelection = false;
            this.listCompetitions.Location = new System.Drawing.Point(54, 43);
            this.listCompetitions.Name = "listCompetitions";
            this.listCompetitions.Size = new System.Drawing.Size(1019, 460);
            this.listCompetitions.TabIndex = 1;
            this.listCompetitions.UseCompatibleStateImageBehavior = false;
            this.listCompetitions.View = System.Windows.Forms.View.Details;
            this.listCompetitions.SelectedIndexChanged += new System.EventHandler(this.listCompetitions_SelectedIndexChanged);
            // 
            // clmCompetitionID
            // 
            this.clmCompetitionID.Text = "CompetitionID";
            this.clmCompetitionID.Width = 177;
            // 
            // clmName
            // 
            this.clmName.Text = "Competition Name";
            this.clmName.Width = 280;
            // 
            // clmDateTime
            // 
            this.clmDateTime.Text = "Date & Time";
            this.clmDateTime.Width = 166;
            // 
            // clmVenue
            // 
            this.clmVenue.Text = "Venue";
            this.clmVenue.Width = 377;
            // 
            // memberViewCompetitions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1101, 586);
            this.Controls.Add(this.listCompetitions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "memberViewCompetitions";
            this.Text = "memberViewCompetitions";
            this.Load += new System.EventHandler(this.memberViewCompetitions_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listCompetitions;
        private System.Windows.Forms.ColumnHeader clmCompetitionID;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader clmDateTime;
        private System.Windows.Forms.ColumnHeader clmVenue;
    }
}