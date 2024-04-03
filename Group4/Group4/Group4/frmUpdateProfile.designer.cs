namespace Group4
{
    partial class frmUpdateProfile
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
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.dtDOB = new System.Windows.Forms.DateTimePicker();
            this.lblDOB = new System.Windows.Forms.Label();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.panelView = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtRole2 = new System.Windows.Forms.TextBox();
            this.rbtnFemale2 = new System.Windows.Forms.RadioButton();
            this.rbtnMale2 = new System.Windows.Forms.RadioButton();
            this.lblDOB2 = new System.Windows.Forms.Label();
            this.dtDOB2 = new System.Windows.Forms.DateTimePicker();
            this.lblGender2 = new System.Windows.Forms.Label();
            this.lblEmail2 = new System.Windows.Forms.Label();
            this.txtEmail2 = new System.Windows.Forms.TextBox();
            this.lblPhone2 = new System.Windows.Forms.Label();
            this.txtPhone2 = new System.Windows.Forms.TextBox();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.lblPass2 = new System.Windows.Forms.Label();
            this.txtUserID2 = new System.Windows.Forms.TextBox();
            this.lblID2 = new System.Windows.Forms.Label();
            this.lblRole2 = new System.Windows.Forms.Label();
            this.panelUpdate.SuspendLayout();
            this.panelView.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(19, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(168, 27);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Update Profile";
            // 
            // panelUpdate
            // 
            this.panelUpdate.BackColor = System.Drawing.SystemColors.Window;
            this.panelUpdate.Controls.Add(this.txtRole);
            this.panelUpdate.Controls.Add(this.btnUpdate);
            this.panelUpdate.Controls.Add(this.lblEmail);
            this.panelUpdate.Controls.Add(this.txtEmail);
            this.panelUpdate.Controls.Add(this.txtPhone);
            this.panelUpdate.Controls.Add(this.lblPhone);
            this.panelUpdate.Controls.Add(this.dtDOB);
            this.panelUpdate.Controls.Add(this.lblDOB);
            this.panelUpdate.Controls.Add(this.rbtnFemale);
            this.panelUpdate.Controls.Add(this.rbtnMale);
            this.panelUpdate.Controls.Add(this.lblGender);
            this.panelUpdate.Controls.Add(this.txtPassword);
            this.panelUpdate.Controls.Add(this.lblPass);
            this.panelUpdate.Controls.Add(this.txtUserID);
            this.panelUpdate.Controls.Add(this.lblID);
            this.panelUpdate.Controls.Add(this.lblRole);
            this.panelUpdate.Location = new System.Drawing.Point(17, 52);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(287, 620);
            this.panelUpdate.TabIndex = 1;
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(23, 60);
            this.txtRole.Name = "txtRole";
            this.txtRole.ReadOnly = true;
            this.txtRole.Size = new System.Drawing.Size(186, 28);
            this.txtRole.TabIndex = 17;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(67, 566);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 37);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(19, 481);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 19);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(23, 509);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(186, 28);
            this.txtEmail.TabIndex = 13;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(23, 440);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(186, 28);
            this.txtPhone.TabIndex = 12;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(19, 413);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(61, 19);
            this.lblPhone.TabIndex = 11;
            this.lblPhone.Text = "Phone";
            // 
            // dtDOB
            // 
            this.dtDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDOB.Location = new System.Drawing.Point(23, 370);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(152, 28);
            this.dtDOB.TabIndex = 10;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(19, 343);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(106, 19);
            this.lblDOB.TabIndex = 9;
            this.lblDOB.Text = "Date of Birth";
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(105, 299);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(91, 23);
            this.rbtnFemale.TabIndex = 8;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(23, 299);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(71, 23);
            this.rbtnMale.TabIndex = 7;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(19, 272);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(71, 19);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Gender";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(23, 222);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(186, 28);
            this.txtPassword.TabIndex = 5;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(19, 188);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(126, 19);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "User Password";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(23, 137);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(186, 28);
            this.txtUserID.TabIndex = 3;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(19, 103);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(65, 19);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "User ID";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(19, 19);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(84, 19);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "User Role";
            // 
            // panelView
            // 
            this.panelView.BackColor = System.Drawing.Color.White;
            this.panelView.Controls.Add(this.lblStatus);
            this.panelView.Controls.Add(this.txtRole2);
            this.panelView.Controls.Add(this.rbtnFemale2);
            this.panelView.Controls.Add(this.rbtnMale2);
            this.panelView.Controls.Add(this.lblDOB2);
            this.panelView.Controls.Add(this.dtDOB2);
            this.panelView.Controls.Add(this.lblGender2);
            this.panelView.Controls.Add(this.lblEmail2);
            this.panelView.Controls.Add(this.txtEmail2);
            this.panelView.Controls.Add(this.lblPhone2);
            this.panelView.Controls.Add(this.txtPhone2);
            this.panelView.Controls.Add(this.txtPassword2);
            this.panelView.Controls.Add(this.lblPass2);
            this.panelView.Controls.Add(this.txtUserID2);
            this.panelView.Controls.Add(this.lblID2);
            this.panelView.Controls.Add(this.lblRole2);
            this.panelView.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelView.Location = new System.Drawing.Point(342, 52);
            this.panelView.Margin = new System.Windows.Forms.Padding(1);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(543, 620);
            this.panelView.TabIndex = 27;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(231, 566);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 25);
            this.lblStatus.TabIndex = 26;
            // 
            // txtRole2
            // 
            this.txtRole2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRole2.Location = new System.Drawing.Point(247, 50);
            this.txtRole2.Margin = new System.Windows.Forms.Padding(2);
            this.txtRole2.Name = "txtRole2";
            this.txtRole2.ReadOnly = true;
            this.txtRole2.Size = new System.Drawing.Size(179, 28);
            this.txtRole2.TabIndex = 25;
            // 
            // rbtnFemale2
            // 
            this.rbtnFemale2.AutoSize = true;
            this.rbtnFemale2.Enabled = false;
            this.rbtnFemale2.Location = new System.Drawing.Point(327, 232);
            this.rbtnFemale2.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnFemale2.Name = "rbtnFemale2";
            this.rbtnFemale2.Size = new System.Drawing.Size(91, 23);
            this.rbtnFemale2.TabIndex = 23;
            this.rbtnFemale2.TabStop = true;
            this.rbtnFemale2.Text = "Female";
            this.rbtnFemale2.UseVisualStyleBackColor = true;
            // 
            // rbtnMale2
            // 
            this.rbtnMale2.AutoSize = true;
            this.rbtnMale2.Enabled = false;
            this.rbtnMale2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMale2.Location = new System.Drawing.Point(248, 232);
            this.rbtnMale2.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnMale2.Name = "rbtnMale2";
            this.rbtnMale2.Size = new System.Drawing.Size(71, 23);
            this.rbtnMale2.TabIndex = 22;
            this.rbtnMale2.TabStop = true;
            this.rbtnMale2.Text = "Male";
            this.rbtnMale2.UseVisualStyleBackColor = true;
            // 
            // lblDOB2
            // 
            this.lblDOB2.AutoSize = true;
            this.lblDOB2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB2.Location = new System.Drawing.Point(112, 287);
            this.lblDOB2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblDOB2.Name = "lblDOB2";
            this.lblDOB2.Size = new System.Drawing.Size(89, 19);
            this.lblDOB2.TabIndex = 19;
            this.lblDOB2.Text = "Birthdate :";
            // 
            // dtDOB2
            // 
            this.dtDOB2.Enabled = false;
            this.dtDOB2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDOB2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDOB2.Location = new System.Drawing.Point(246, 287);
            this.dtDOB2.Margin = new System.Windows.Forms.Padding(1);
            this.dtDOB2.Name = "dtDOB2";
            this.dtDOB2.Size = new System.Drawing.Size(180, 28);
            this.dtDOB2.TabIndex = 18;
            this.dtDOB2.Value = new System.DateTime(2024, 2, 3, 23, 57, 20, 0);
            // 
            // lblGender2
            // 
            this.lblGender2.AutoSize = true;
            this.lblGender2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender2.Location = new System.Drawing.Point(125, 230);
            this.lblGender2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblGender2.Name = "lblGender2";
            this.lblGender2.Size = new System.Drawing.Size(81, 19);
            this.lblGender2.TabIndex = 4;
            this.lblGender2.Text = "Gender :";
            // 
            // lblEmail2
            // 
            this.lblEmail2.AutoSize = true;
            this.lblEmail2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail2.Location = new System.Drawing.Point(140, 427);
            this.lblEmail2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEmail2.Name = "lblEmail2";
            this.lblEmail2.Size = new System.Drawing.Size(63, 19);
            this.lblEmail2.TabIndex = 13;
            this.lblEmail2.Text = "Email :";
            // 
            // txtEmail2
            // 
            this.txtEmail2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail2.Location = new System.Drawing.Point(247, 427);
            this.txtEmail2.Margin = new System.Windows.Forms.Padding(1);
            this.txtEmail2.Name = "txtEmail2";
            this.txtEmail2.ReadOnly = true;
            this.txtEmail2.Size = new System.Drawing.Size(177, 28);
            this.txtEmail2.TabIndex = 12;
            // 
            // lblPhone2
            // 
            this.lblPhone2.AutoSize = true;
            this.lblPhone2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone2.Location = new System.Drawing.Point(133, 353);
            this.lblPhone2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPhone2.Name = "lblPhone2";
            this.lblPhone2.Size = new System.Drawing.Size(71, 19);
            this.lblPhone2.TabIndex = 11;
            this.lblPhone2.Text = "Phone :";
            // 
            // txtPhone2
            // 
            this.txtPhone2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone2.Location = new System.Drawing.Point(246, 353);
            this.txtPhone2.Margin = new System.Windows.Forms.Padding(1);
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.ReadOnly = true;
            this.txtPhone2.Size = new System.Drawing.Size(177, 28);
            this.txtPhone2.TabIndex = 10;
            // 
            // txtPassword2
            // 
            this.txtPassword2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword2.Location = new System.Drawing.Point(247, 170);
            this.txtPassword2.Margin = new System.Windows.Forms.Padding(1);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.ReadOnly = true;
            this.txtPassword2.Size = new System.Drawing.Size(179, 28);
            this.txtPassword2.TabIndex = 9;
            // 
            // lblPass2
            // 
            this.lblPass2.AutoSize = true;
            this.lblPass2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass2.Location = new System.Drawing.Point(61, 172);
            this.lblPass2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPass2.Name = "lblPass2";
            this.lblPass2.Size = new System.Drawing.Size(136, 19);
            this.lblPass2.TabIndex = 8;
            this.lblPass2.Text = "User Password :";
            // 
            // txtUserID2
            // 
            this.txtUserID2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID2.Location = new System.Drawing.Point(244, 113);
            this.txtUserID2.Margin = new System.Windows.Forms.Padding(1);
            this.txtUserID2.Name = "txtUserID2";
            this.txtUserID2.ReadOnly = true;
            this.txtUserID2.Size = new System.Drawing.Size(179, 28);
            this.txtUserID2.TabIndex = 7;
            // 
            // lblID2
            // 
            this.lblID2.AutoSize = true;
            this.lblID2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID2.Location = new System.Drawing.Point(123, 113);
            this.lblID2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblID2.Name = "lblID2";
            this.lblID2.Size = new System.Drawing.Size(75, 19);
            this.lblID2.TabIndex = 6;
            this.lblID2.Text = "User ID :";
            // 
            // lblRole2
            // 
            this.lblRole2.AutoSize = true;
            this.lblRole2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole2.Location = new System.Drawing.Point(104, 50);
            this.lblRole2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblRole2.Name = "lblRole2";
            this.lblRole2.Size = new System.Drawing.Size(94, 19);
            this.lblRole2.TabIndex = 2;
            this.lblRole2.Text = "User Role :";
            // 
            // frmUpdateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(971, 672);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.panelUpdate);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUpdateProfile";
            this.Text = "Update Profile";
            this.Load += new System.EventHandler(this.frmUpdateProfile_Load);
            this.panelUpdate.ResumeLayout(false);
            this.panelUpdate.PerformLayout();
            this.panelView.ResumeLayout(false);
            this.panelView.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelUpdate;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.DateTimePicker dtDOB;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtRole2;
        private System.Windows.Forms.RadioButton rbtnFemale2;
        private System.Windows.Forms.RadioButton rbtnMale2;
        private System.Windows.Forms.Label lblDOB2;
        private System.Windows.Forms.DateTimePicker dtDOB2;
        private System.Windows.Forms.Label lblGender2;
        private System.Windows.Forms.Label lblEmail2;
        private System.Windows.Forms.TextBox txtEmail2;
        private System.Windows.Forms.Label lblPhone2;
        private System.Windows.Forms.TextBox txtPhone2;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Label lblPass2;
        private System.Windows.Forms.TextBox txtUserID2;
        private System.Windows.Forms.Label lblID2;
        private System.Windows.Forms.Label lblRole2;
        private System.Windows.Forms.TextBox txtRole;
    }
}