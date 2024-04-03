namespace Group4
{
    partial class frmResult
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
            System.Windows.Forms.Label lblID;
            System.Windows.Forms.Label lblCName;
            System.Windows.Forms.Label lblResult;
            this.cmbResult = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRecord = new System.Windows.Forms.Button();
            this.cmbID = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lstCompetition = new System.Windows.Forms.ListView();
            this.competition_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.competition_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.venue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.result = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lblID = new System.Windows.Forms.Label();
            lblCName = new System.Windows.Forms.Label();
            lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new System.Drawing.Point(16, 60);
            lblID.Name = "lblID";
            lblID.Size = new System.Drawing.Size(135, 19);
            lblID.TabIndex = 1;
            lblID.Text = "Competition ID:";
            // 
            // lblCName
            // 
            lblCName.AutoSize = true;
            lblCName.Location = new System.Drawing.Point(16, 102);
            lblCName.Name = "lblCName";
            lblCName.Size = new System.Drawing.Size(169, 19);
            lblCName.TabIndex = 3;
            lblCName.Text = "Competition Name:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new System.Drawing.Point(16, 144);
            lblResult.Name = "lblResult";
            lblResult.Size = new System.Drawing.Size(61, 19);
            lblResult.TabIndex = 5;
            lblResult.Text = "Result:";
            // 
            // cmbResult
            // 
            this.cmbResult.FormattingEnabled = true;
            this.cmbResult.Items.AddRange(new object[] {
            "Won",
            "Lost"});
            this.cmbResult.Location = new System.Drawing.Point(186, 141);
            this.cmbResult.Name = "cmbResult";
            this.cmbResult.Size = new System.Drawing.Size(121, 27);
            this.cmbResult.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(16, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 27);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Result of Competitions";
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRecord.Location = new System.Drawing.Point(328, 141);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(114, 31);
            this.btnRecord.TabIndex = 9;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // cmbID
            // 
            this.cmbID.FormattingEnabled = true;
            this.cmbID.Location = new System.Drawing.Point(186, 60);
            this.cmbID.Name = "cmbID";
            this.cmbID.Size = new System.Drawing.Size(164, 27);
            this.cmbID.TabIndex = 10;
            this.cmbID.SelectedIndexChanged += new System.EventHandler(this.cmbID_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Location = new System.Drawing.Point(188, 104);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(2, 21);
            this.lblName.TabIndex = 11;
            // 
            // lstCompetition
            // 
            this.lstCompetition.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.competition_id,
            this.competition_name,
            this.date_time,
            this.venue,
            this.result});
            this.lstCompetition.FullRowSelect = true;
            this.lstCompetition.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstCompetition.HideSelection = false;
            this.lstCompetition.Location = new System.Drawing.Point(12, 196);
            this.lstCompetition.Name = "lstCompetition";
            this.lstCompetition.Size = new System.Drawing.Size(912, 212);
            this.lstCompetition.TabIndex = 12;
            this.lstCompetition.UseCompatibleStateImageBehavior = false;
            this.lstCompetition.View = System.Windows.Forms.View.Details;
            // 
            // competition_id
            // 
            this.competition_id.Text = "Competition ID";
            this.competition_id.Width = 134;
            // 
            // competition_name
            // 
            this.competition_name.Text = "Competition Name";
            this.competition_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.competition_name.Width = 266;
            // 
            // date_time
            // 
            this.date_time.Text = "Date & Time";
            this.date_time.Width = 119;
            // 
            // venue
            // 
            this.venue.Text = "Venue";
            this.venue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.venue.Width = 235;
            // 
            // result
            // 
            this.result.Text = "Result";
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.result.Width = 142;
            // 
            // frmResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(942, 423);
            this.Controls.Add(this.lstCompetition);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cmbID);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(lblID);
            this.Controls.Add(lblCName);
            this.Controls.Add(lblResult);
            this.Controls.Add(this.cmbResult);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmResult";
            this.Text = "Record Competition Result";
            this.Load += new System.EventHandler(this.frmResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbResult;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.ComboBox cmbID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListView lstCompetition;
        private System.Windows.Forms.ColumnHeader competition_id;
        private System.Windows.Forms.ColumnHeader competition_name;
        private System.Windows.Forms.ColumnHeader date_time;
        private System.Windows.Forms.ColumnHeader venue;
        private System.Windows.Forms.ColumnHeader result;
    }
}