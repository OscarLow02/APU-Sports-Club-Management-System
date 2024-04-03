using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Data.Common;
using System.Management.Instrumentation;
using System.Linq.Expressions;

namespace Group4
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // Open child form in panelMain
        private void OpenChildForm(Form childForm)
        {
            if (panelMain.Controls.Count > 0)
            {
                panelMain.Controls.RemoveAt(0);
            }
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.Show();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmModify());
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmManage());
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmViewStudent());
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmResult());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmUpdateProfile());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //logout
            CurrentUser.UserName = null;
            this.Close();
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
