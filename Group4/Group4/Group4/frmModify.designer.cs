namespace Group4
{
    partial class frmModify
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
            this.lstCompetition = new System.Windows.Forms.ListView();
            this.competition_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.competition_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.venue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCompetition
            // 
            this.lstCompetition.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.competition_id,
            this.competition_name,
            this.date_time,
            this.venue});
            this.lstCompetition.FullRowSelect = true;
            this.lstCompetition.HideSelection = false;
            this.lstCompetition.Location = new System.Drawing.Point(12, 52);
            this.lstCompetition.Name = "lstCompetition";
            this.lstCompetition.Size = new System.Drawing.Size(971, 308);
            this.lstCompetition.TabIndex = 0;
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
            this.venue.Width = 448;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 382);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 28);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(182, 382);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 28);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(97, 382);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(79, 28);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(191, 27);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Competition List";
            // 
            // frmModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(999, 470);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstCompetition);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmModify";
            this.Text = "Modify Competition List";
            this.Load += new System.EventHandler(this.frmModify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstCompetition;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ColumnHeader competition_id;
        private System.Windows.Forms.ColumnHeader competition_name;
        private System.Windows.Forms.ColumnHeader date_time;
        private System.Windows.Forms.ColumnHeader venue;
        private System.Windows.Forms.Label lblTitle;
    }
}