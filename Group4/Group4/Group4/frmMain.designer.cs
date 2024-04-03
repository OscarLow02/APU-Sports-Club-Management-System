namespace Group4
{
    partial class frmMain
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(23, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(182, 44);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Manager";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(31, 94);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(237, 43);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "Modify Competition List";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnManage
            // 
            this.btnManage.Location = new System.Drawing.Point(31, 166);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(237, 43);
            this.btnManage.TabIndex = 2;
            this.btnManage.Text = "Manage Competition";
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(31, 244);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(237, 43);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View Student List";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(31, 323);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(237, 43);
            this.btnRecord.TabIndex = 4;
            this.btnRecord.Text = "Record Competition Result";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(31, 401);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(237, 43);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update Profile";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(290, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(944, 672);
            this.panelMain.TabIndex = 6;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(31, 627);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(91, 32);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1237, 684);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Manager Home";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnLogout;
    }
}

