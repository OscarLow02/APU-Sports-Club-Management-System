namespace Group4
{
    partial class frmIncome
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
            this.panel = new System.Windows.Forms.Panel();
            this.btnApply = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxMonth = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxLevel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboxCoach = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAdmExit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.lblCompetition = new System.Windows.Forms.Label();
            this.lblSuggestion = new System.Windows.Forms.Label();
            this.lblManage = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.Control;
            this.panel.Controls.Add(this.btnApply);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.cboxMonth);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.cboxLevel);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.panel1);
            this.panel.Controls.Add(this.cboxCoach);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.dataView);
            this.panel.Controls.Add(this.panel2);
            this.panel.Controls.Add(this.btnReset);
            this.panel.Location = new System.Drawing.Point(252, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1317, 1185);
            this.panel.TabIndex = 37;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(436, 1072);
            this.btnApply.Margin = new System.Windows.Forms.Padding(2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(182, 65);
            this.btnApply.TabIndex = 57;
            this.btnApply.Text = "Apply FIlter";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 840);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 31);
            this.label2.TabIndex = 52;
            this.label2.Text = "Months:";
            // 
            // cboxMonth
            // 
            this.cboxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxMonth.FormattingEnabled = true;
            this.cboxMonth.Location = new System.Drawing.Point(277, 838);
            this.cboxMonth.Margin = new System.Windows.Forms.Padding(2);
            this.cboxMonth.Name = "cboxMonth";
            this.cboxMonth.Size = new System.Drawing.Size(265, 38);
            this.cboxMonth.TabIndex = 51;
            this.cboxMonth.SelectedIndexChanged += new System.EventHandler(this.cboxMonth_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(675, 907);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 31);
            this.label5.TabIndex = 50;
            this.label5.Text = "Training Level :";
            // 
            // cboxLevel
            // 
            this.cboxLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxLevel.FormattingEnabled = true;
            this.cboxLevel.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Advance"});
            this.cboxLevel.Location = new System.Drawing.Point(889, 905);
            this.cboxLevel.Margin = new System.Windows.Forms.Padding(2);
            this.cboxLevel.Name = "cboxLevel";
            this.cboxLevel.Size = new System.Drawing.Size(265, 38);
            this.cboxLevel.TabIndex = 49;
            this.cboxLevel.SelectedIndexChanged += new System.EventHandler(this.cboxLevel_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(687, 838);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 31);
            this.label4.TabIndex = 48;
            this.label4.Text = "Coach Name :";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(851, 672);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(6, 6);
            this.panel1.TabIndex = 2;
            // 
            // cboxCoach
            // 
            this.cboxCoach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCoach.FormattingEnabled = true;
            this.cboxCoach.Location = new System.Drawing.Point(889, 838);
            this.cboxCoach.Margin = new System.Windows.Forms.Padding(2);
            this.cboxCoach.Name = "cboxCoach";
            this.cboxCoach.Size = new System.Drawing.Size(265, 38);
            this.cboxCoach.TabIndex = 47;
            this.cboxCoach.SelectedIndexChanged += new System.EventHandler(this.cboxUser_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Income";
            // 
            // dataView
            // 
            this.dataView.AllowUserToAddRows = false;
            this.dataView.AllowUserToDeleteRows = false;
            this.dataView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(44, 110);
            this.dataView.Name = "dataView";
            this.dataView.ReadOnly = true;
            this.dataView.RowHeadersVisible = false;
            this.dataView.RowHeadersWidth = 82;
            this.dataView.RowTemplate.Height = 33;
            this.dataView.Size = new System.Drawing.Size(1227, 653);
            this.dataView.TabIndex = 41;
            this.dataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(853, 673);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(6, 6);
            this.panel2.TabIndex = 40;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(675, 1072);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(182, 65);
            this.btnReset.TabIndex = 42;
            this.btnReset.Text = "Reset FIlter";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAdmExit
            // 
            this.btnAdmExit.Location = new System.Drawing.Point(11, 1129);
            this.btnAdmExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdmExit.Name = "btnAdmExit";
            this.btnAdmExit.Size = new System.Drawing.Size(115, 44);
            this.btnAdmExit.TabIndex = 36;
            this.btnAdmExit.Text = "Logout";
            this.btnAdmExit.UseVisualStyleBackColor = true;
            this.btnAdmExit.Click += new System.EventHandler(this.btnAdmExit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 47);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 67);
            this.label9.TabIndex = 34;
            this.label9.Text = "Admin";
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.Location = new System.Drawing.Point(21, 825);
            this.lblUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(186, 31);
            this.lblUpdate.TabIndex = 28;
            this.lblUpdate.Text = "Update Profile";
            this.lblUpdate.Click += new System.EventHandler(this.lblUpdate_Click);
            // 
            // lblCompetition
            // 
            this.lblCompetition.AutoSize = true;
            this.lblCompetition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetition.Location = new System.Drawing.Point(23, 688);
            this.lblCompetition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompetition.Name = "lblCompetition";
            this.lblCompetition.Size = new System.Drawing.Size(225, 31);
            this.lblCompetition.TabIndex = 27;
            this.lblCompetition.Text = "View Competition";
            this.lblCompetition.Click += new System.EventHandler(this.lblCompetition_Click);
            // 
            // lblSuggestion
            // 
            this.lblSuggestion.AutoSize = true;
            this.lblSuggestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuggestion.Location = new System.Drawing.Point(23, 433);
            this.lblSuggestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSuggestion.Name = "lblSuggestion";
            this.lblSuggestion.Size = new System.Drawing.Size(216, 31);
            this.lblSuggestion.TabIndex = 25;
            this.lblSuggestion.Text = "View Suggestion";
            this.lblSuggestion.Click += new System.EventHandler(this.lblSuggestion_Click);
            // 
            // lblManage
            // 
            this.lblManage.AutoSize = true;
            this.lblManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManage.Location = new System.Drawing.Point(23, 306);
            this.lblManage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblManage.Name = "lblManage";
            this.lblManage.Size = new System.Drawing.Size(176, 31);
            this.lblManage.TabIndex = 38;
            this.lblManage.Text = "Manage User";
            this.lblManage.Click += new System.EventHandler(this.lblManage_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.AliceBlue;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(9, 529);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(239, 93);
            this.panel4.TabIndex = 39;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Azure;
            this.panel5.Location = new System.Drawing.Point(202, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(37, 93);
            this.panel5.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 30);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 31);
            this.label10.TabIndex = 21;
            this.label10.Text = "View Income";
            // 
            // frmIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1574, 1184);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblManage);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lblCompetition);
            this.Controls.Add(this.lblSuggestion);
            this.Controls.Add(this.btnAdmExit);
            this.Controls.Add(this.label9);
            this.Name = "frmIncome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIncome";
            this.Load += new System.EventHandler(this.frmIncome_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdmExit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Label lblCompetition;
        private System.Windows.Forms.Label lblSuggestion;
        private System.Windows.Forms.Label lblManage;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxCoach;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboxLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxMonth;
        private System.Windows.Forms.Button btnApply;
    }
}