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
    public partial class frmReset2 : Form
    {
        string userName;
        public frmReset2(string un)
        {
            InitializeComponent();
            userName = un;
        }

        private void frmReset2_Load(object sender, EventArgs e)
        {
            lblName.Text = userName;

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tboxPass.Text == tboxPass2.Text)
            {
                User user = new User();
                if (user.UpdatePassword(userName, tboxPass2.Text)) 
                { 
                    MessageBox.Show("Password reset successfully.");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Passwords are not same");
            }
        }
    }
}
