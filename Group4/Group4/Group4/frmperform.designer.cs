namespace Group4
{
    partial class frmperform
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
            this.lblperforrm = new System.Windows.Forms.Label();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.lblCoach = new System.Windows.Forms.Label();
            this.lblRecom = new System.Windows.Forms.Label();
            this.lblManage = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.NumericUpDown();
            this.lblScore = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.txtMemID = new System.Windows.Forms.TextBox();
            this.lblMemID = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.dataPerformance = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPerformance)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblUpdate);
            this.panel2.Controls.Add(this.lblCoach);
            this.panel2.Controls.Add(this.lblRecom);
            this.panel2.Controls.Add(this.lblManage);
            this.panel2.Controls.Add(this.lblPay);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 675);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 689);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 32);
            this.btnLogout.TabIndex = 35;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lavender;
            this.panel3.Controls.Add(this.lblperforrm);
            this.panel3.Location = new System.Drawing.Point(3, 278);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 49);
            this.panel3.TabIndex = 29;
            // 
            // lblperforrm
            // 
            this.lblperforrm.BackColor = System.Drawing.Color.Transparent;
            this.lblperforrm.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblperforrm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblperforrm.Location = new System.Drawing.Point(3, 12);
            this.lblperforrm.Name = "lblperforrm";
            this.lblperforrm.Size = new System.Drawing.Size(197, 26);
            this.lblperforrm.TabIndex = 14;
            this.lblperforrm.Text = "Members\' performance";
            // 
            // lblUpdate
            // 
            this.lblUpdate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUpdate.Location = new System.Drawing.Point(7, 412);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(197, 26);
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
            this.lblRecom.Size = new System.Drawing.Size(197, 42);
            this.lblRecom.TabIndex = 15;
            this.lblRecom.Text = "\nRecommendation";
            this.lblRecom.Click += new System.EventHandler(this.lblRecom_Click);
            // 
            // lblManage
            // 
            this.lblManage.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblManage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblManage.Location = new System.Drawing.Point(7, 153);
            this.lblManage.Name = "lblManage";
            this.lblManage.Size = new System.Drawing.Size(197, 26);
            this.lblManage.TabIndex = 12;
            this.lblManage.Text = "Manage Schedule";
            this.lblManage.Click += new System.EventHandler(this.lblManage_Click);
            // 
            // lblPay
            // 
            this.lblPay.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblPay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPay.Location = new System.Drawing.Point(7, 222);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(197, 32);
            this.lblPay.TabIndex = 13;
            this.lblPay.Text = "Payment";
            this.lblPay.Click += new System.EventHandler(this.lblPay_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtScore);
            this.panel1.Controls.Add(this.lblScore);
            this.panel1.Controls.Add(this.rtxtDescription);
            this.panel1.Controls.Add(this.txtDate);
            this.panel1.Controls.Add(this.txtMemID);
            this.panel1.Controls.Add(this.lblMemID);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(231, 89);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 622);
            this.panel1.TabIndex = 18;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Arial", 10.2F);
            this.txtName.Location = new System.Drawing.Point(25, 106);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(183, 27);
            this.txtName.TabIndex = 29;
            // 
            // txtScore
            // 
            this.txtScore.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtScore.Font = new System.Drawing.Font("Arial", 10.2F);
            this.txtScore.Location = new System.Drawing.Point(25, 174);
            this.txtScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(184, 27);
            this.txtScore.TabIndex = 28;
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
            // rtxtDescription
            // 
            this.rtxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtDescription.Location = new System.Drawing.Point(25, 295);
            this.rtxtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(184, 117);
            this.rtxtDescription.TabIndex = 26;
            this.rtxtDescription.Text = "";
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate.Location = new System.Drawing.Point(25, 235);
            this.txtDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(184, 27);
            this.txtDate.TabIndex = 25;
            // 
            // txtMemID
            // 
            this.txtMemID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMemID.Font = new System.Drawing.Font("Arial", 10.2F);
            this.txtMemID.Location = new System.Drawing.Point(25, 39);
            this.txtMemID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMemID.Name = "txtMemID";
            this.txtMemID.Size = new System.Drawing.Size(183, 27);
            this.txtMemID.TabIndex = 23;
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
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(21, 210);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(80, 27);
            this.lblDate.TabIndex = 24;
            this.lblDate.Text = "Date";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDescription.Location = new System.Drawing.Point(21, 272);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(147, 27);
            this.lblDescription.TabIndex = 21;
            this.lblDescription.Text = "Description";
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdate.Location = new System.Drawing.Point(133, 527);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 42);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdd.Location = new System.Drawing.Point(25, 527);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 42);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            // lblList
            // 
            this.lblList.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblList.Location = new System.Drawing.Point(732, 56);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(213, 31);
            this.lblList.TabIndex = 26;
            this.lblList.Text = "Performance Records";
            // 
            // dataPerformance
            // 
            this.dataPerformance.AllowUserToAddRows = false;
            this.dataPerformance.AllowUserToDeleteRows = false;
            this.dataPerformance.BackgroundColor = System.Drawing.Color.White;
            this.dataPerformance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPerformance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataPerformance.ColumnHeadersHeight = 29;
            this.dataPerformance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataPerformance.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataPerformance.Location = new System.Drawing.Point(499, 89);
            this.dataPerformance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataPerformance.Name = "dataPerformance";
            this.dataPerformance.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPerformance.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataPerformance.RowHeadersVisible = false;
            this.dataPerformance.RowHeadersWidth = 51;
            this.dataPerformance.RowTemplate.Height = 24;
            this.dataPerformance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPerformance.Size = new System.Drawing.Size(660, 622);
            this.dataPerformance.TabIndex = 27;
            this.dataPerformance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPerformance_CellContentClick);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitle.Location = new System.Drawing.Point(211, 1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(320, 48);
            this.lblTitle.TabIndex = 28;
            this.lblTitle.Text = "Record Performance";
            // 
            // frmperform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1179, 675);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dataPerformance);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmperform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Performance";
            this.Load += new System.EventHandler(this.frmperform_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPerformance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Label lblCoach;
        private System.Windows.Forms.Label lblRecom;
        private System.Windows.Forms.Label lblManage;
        private System.Windows.Forms.Label lblperforrm;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtMemID;
        private System.Windows.Forms.Label lblMemID;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.NumericUpDown txtScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.DataGridView dataPerformance;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLogout;
    }
}