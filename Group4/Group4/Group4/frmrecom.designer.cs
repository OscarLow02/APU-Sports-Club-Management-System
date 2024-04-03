namespace Group4
{
    partial class frmrecom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblRecom = new System.Windows.Forms.Label();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.lblCoach = new System.Windows.Forms.Label();
            this.lblSche = new System.Windows.Forms.Label();
            this.lblperforrm = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.dataPerform = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtMemId = new System.Windows.Forms.TextBox();
            this.lblMemID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPerform)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblUpdate);
            this.panel2.Controls.Add(this.lblCoach);
            this.panel2.Controls.Add(this.lblSche);
            this.panel2.Controls.Add(this.lblperforrm);
            this.panel2.Controls.Add(this.lblPay);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 675);
            this.panel2.TabIndex = 14;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 663);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 32);
            this.btnLogout.TabIndex = 44;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lavender;
            this.panel3.Controls.Add(this.lblRecom);
            this.panel3.Location = new System.Drawing.Point(7, 332);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 49);
            this.panel3.TabIndex = 44;
            // 
            // lblRecom
            // 
            this.lblRecom.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblRecom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRecom.Location = new System.Drawing.Point(0, -1);
            this.lblRecom.Name = "lblRecom";
            this.lblRecom.Size = new System.Drawing.Size(185, 34);
            this.lblRecom.TabIndex = 15;
            this.lblRecom.Text = "\nRecommendation";
            // 
            // lblUpdate
            // 
            this.lblUpdate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUpdate.Location = new System.Drawing.Point(7, 412);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(148, 26);
            this.lblUpdate.TabIndex = 16;
            this.lblUpdate.Text = "Update Profile";
            this.lblUpdate.Click += new System.EventHandler(this.lblUpdate_Click);
            // 
            // lblCoach
            // 
            this.lblCoach.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblCoach.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCoach.Location = new System.Drawing.Point(3, 11);
            this.lblCoach.Name = "lblCoach";
            this.lblCoach.Size = new System.Drawing.Size(117, 48);
            this.lblCoach.TabIndex = 11;
            this.lblCoach.Text = "Coach";
            // 
            // lblSche
            // 
            this.lblSche.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblSche.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSche.Location = new System.Drawing.Point(7, 153);
            this.lblSche.Name = "lblSche";
            this.lblSche.Size = new System.Drawing.Size(185, 26);
            this.lblSche.TabIndex = 12;
            this.lblSche.Text = "Manage Schedule";
            this.lblSche.Click += new System.EventHandler(this.lblSche_Click);
            // 
            // lblperforrm
            // 
            this.lblperforrm.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblperforrm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblperforrm.Location = new System.Drawing.Point(7, 288);
            this.lblperforrm.Name = "lblperforrm";
            this.lblperforrm.Size = new System.Drawing.Size(197, 26);
            this.lblperforrm.TabIndex = 14;
            this.lblperforrm.Text = "Members\' performance";
            this.lblperforrm.Click += new System.EventHandler(this.lblperforrm_Click);
            // 
            // lblPay
            // 
            this.lblPay.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblPay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPay.Location = new System.Drawing.Point(7, 222);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(93, 32);
            this.lblPay.TabIndex = 13;
            this.lblPay.Text = "Payment";
            this.lblPay.Click += new System.EventHandler(this.lblPay_Click);
            // 
            // lblList
            // 
            this.lblList.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblList.Location = new System.Drawing.Point(720, 76);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(261, 31);
            this.lblList.TabIndex = 30;
            this.lblList.Text = "Members\' performance";
            // 
            // dataPerform
            // 
            this.dataPerform.AllowUserToAddRows = false;
            this.dataPerform.AllowUserToDeleteRows = false;
            this.dataPerform.BackgroundColor = System.Drawing.Color.White;
            this.dataPerform.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPerform.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataPerform.ColumnHeadersHeight = 29;
            this.dataPerform.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataPerform.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataPerform.Location = new System.Drawing.Point(496, 110);
            this.dataPerform.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataPerform.Name = "dataPerform";
            this.dataPerform.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPerform.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataPerform.RowHeadersVisible = false;
            this.dataPerform.RowHeadersWidth = 51;
            this.dataPerform.RowTemplate.Height = 24;
            this.dataPerform.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPerform.Size = new System.Drawing.Size(660, 574);
            this.dataPerform.TabIndex = 31;
            this.dataPerform.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPerform_CellContentClick);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitle.Location = new System.Drawing.Point(211, 1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(301, 48);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Send Recommendation";
            // 
            // lblSearch
            // 
            this.lblSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSearch.Location = new System.Drawing.Point(644, 28);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(149, 31);
            this.lblSearch.TabIndex = 32;
            this.lblSearch.Text = "Search by ID:";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Arial", 10.2F);
            this.txtSearch.Location = new System.Drawing.Point(797, 25);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(171, 27);
            this.txtSearch.TabIndex = 33;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSend.Location = new System.Drawing.Point(25, 506);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(89, 42);
            this.btnSend.TabIndex = 40;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClear.Location = new System.Drawing.Point(131, 506);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 42);
            this.btnClear.TabIndex = 41;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtScore);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.lblScore);
            this.panel1.Controls.Add(this.txtMemId);
            this.panel1.Controls.Add(this.lblMemID);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(219, 102);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 580);
            this.panel1.TabIndex = 35;
            // 
            // txtScore
            // 
            this.txtScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScore.Enabled = false;
            this.txtScore.Font = new System.Drawing.Font("Arial", 10.2F);
            this.txtScore.Location = new System.Drawing.Point(25, 175);
            this.txtScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(183, 27);
            this.txtScore.TabIndex = 42;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Arial", 10.2F);
            this.txtName.Location = new System.Drawing.Point(25, 106);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(183, 27);
            this.txtName.TabIndex = 29;
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(21, 145);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(80, 27);
            this.lblScore.TabIndex = 27;
            this.lblScore.Text = "Score";
            // 
            // txtMemId
            // 
            this.txtMemId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMemId.Enabled = false;
            this.txtMemId.Font = new System.Drawing.Font("Arial", 10.2F);
            this.txtMemId.Location = new System.Drawing.Point(25, 39);
            this.txtMemId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMemId.Name = "txtMemId";
            this.txtMemId.ReadOnly = true;
            this.txtMemId.Size = new System.Drawing.Size(183, 27);
            this.txtMemId.TabIndex = 23;
            // 
            // lblMemID
            // 
            this.lblMemID.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblMemID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMemID.Location = new System.Drawing.Point(21, 10);
            this.lblMemID.Name = "lblMemID";
            this.lblMemID.Size = new System.Drawing.Size(112, 27);
            this.lblMemID.TabIndex = 22;
            this.lblMemID.Text = "MemberID";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblName.Location = new System.Drawing.Point(21, 81);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(80, 27);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearch.Location = new System.Drawing.Point(983, 20);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 34);
            this.btnSearch.TabIndex = 43;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmrecom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1179, 675);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dataPerform);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmrecom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send Recommendation";
            this.Load += new System.EventHandler(this.frmrecom_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPerform)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Label lblCoach;
        private System.Windows.Forms.Label lblRecom;
        private System.Windows.Forms.Label lblSche;
        private System.Windows.Forms.Label lblperforrm;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.DataGridView dataPerform;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtMemId;
        private System.Windows.Forms.Label lblMemID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLogout;
    }
}