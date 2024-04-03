namespace Group4
{
    partial class frmpayment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPay = new System.Windows.Forms.Label();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.lblCoach = new System.Windows.Forms.Label();
            this.lblRecom = new System.Windows.Forms.Label();
            this.lblManage = new System.Windows.Forms.Label();
            this.lblperform = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dataPayment = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.lblUpdate);
            this.panel2.Controls.Add(this.lblCoach);
            this.panel2.Controls.Add(this.lblRecom);
            this.panel2.Controls.Add(this.lblManage);
            this.panel2.Controls.Add(this.lblperform);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 675);
            this.panel2.TabIndex = 13;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 632);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 32);
            this.btnLogout.TabIndex = 35;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.lblPay);
            this.panel1.Location = new System.Drawing.Point(3, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 49);
            this.panel1.TabIndex = 17;
            // 
            // lblPay
            // 
            this.lblPay.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblPay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPay.Location = new System.Drawing.Point(3, 15);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(117, 32);
            this.lblPay.TabIndex = 13;
            this.lblPay.Text = "Payment";
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
            // lblRecom
            // 
            this.lblRecom.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblRecom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRecom.Location = new System.Drawing.Point(7, 332);
            this.lblRecom.Name = "lblRecom";
            this.lblRecom.Size = new System.Drawing.Size(185, 42);
            this.lblRecom.TabIndex = 15;
            this.lblRecom.Text = "\nRecommendation";
            this.lblRecom.Click += new System.EventHandler(this.lblRecom_Click);
            // 
            // lblManage
            // 
            this.lblManage.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblManage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblManage.Location = new System.Drawing.Point(7, 152);
            this.lblManage.Name = "lblManage";
            this.lblManage.Size = new System.Drawing.Size(185, 26);
            this.lblManage.TabIndex = 12;
            this.lblManage.Text = "Manage Schedule";
            this.lblManage.Click += new System.EventHandler(this.lblManage_Click);
            // 
            // lblperform
            // 
            this.lblperform.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblperform.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblperform.Location = new System.Drawing.Point(7, 288);
            this.lblperform.Name = "lblperform";
            this.lblperform.Size = new System.Drawing.Size(197, 26);
            this.lblperform.TabIndex = 14;
            this.lblperform.Text = "Members\' performance";
            this.lblperform.Click += new System.EventHandler(this.lblperform_Click);
            // 
            // lblList
            // 
            this.lblList.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblList.Location = new System.Drawing.Point(509, 132);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(172, 31);
            this.lblList.TabIndex = 31;
            this.lblList.Text = "Payment List";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitle.Location = new System.Drawing.Point(211, 1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(211, 48);
            this.lblTitle.TabIndex = 32;
            this.lblTitle.Text = "View Payment";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearch.Location = new System.Drawing.Point(731, 53);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 35);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Arial", 10.2F);
            this.txtSearch.Location = new System.Drawing.Point(544, 58);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(171, 27);
            this.txtSearch.TabIndex = 45;
            // 
            // lblSearch
            // 
            this.lblSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSearch.Location = new System.Drawing.Point(343, 61);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(197, 31);
            this.lblSearch.TabIndex = 44;
            this.lblSearch.Text = "Search by name:";
            // 
            // dataPayment
            // 
            this.dataPayment.AllowUserToAddRows = false;
            this.dataPayment.AllowUserToDeleteRows = false;
            this.dataPayment.BackgroundColor = System.Drawing.Color.White;
            this.dataPayment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPayment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataPayment.ColumnHeadersHeight = 29;
            this.dataPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataPayment.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataPayment.Location = new System.Drawing.Point(225, 166);
            this.dataPayment.Name = "dataPayment";
            this.dataPayment.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPayment.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataPayment.RowHeadersVisible = false;
            this.dataPayment.RowHeadersWidth = 51;
            this.dataPayment.RowTemplate.Height = 24;
            this.dataPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPayment.Size = new System.Drawing.Size(711, 483);
            this.dataPayment.TabIndex = 47;
            // 
            // frmpayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(960, 675);
            this.Controls.Add(this.dataPayment);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.panel2);
            this.Name = "frmpayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Payment";
            this.Load += new System.EventHandler(this.frmpayment_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Label lblCoach;
        private System.Windows.Forms.Label lblRecom;
        private System.Windows.Forms.Label lblManage;
        private System.Windows.Forms.Label lblperform;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dataPayment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
    }
}