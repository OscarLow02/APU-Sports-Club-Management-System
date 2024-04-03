using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group4
{
    public partial class frmSecurity : Form
    {
        string userName;
        public frmSecurity(string un)
        {
            InitializeComponent();
            userName = un;

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string q1 = cboxQ1.Text;
            string q2 = cboxQ2.Text;
            string a1 = tboxA1.Text;
            string a2 = tboxA2.Text;

            Admin admin = new Admin();
            if (admin.AddSecurity(userName,q1, q2, a1, a2))
            {
                SecurityInfoSaved = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Error saving security info.");
            }

        }

        public bool SecurityInfoSaved { get; private set; } = false;
    }
}
