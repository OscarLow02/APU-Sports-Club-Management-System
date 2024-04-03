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
    public partial class frmReset : Form
    {
        string userName;
        User user = new User();
        public frmReset(string userName)
        {
            InitializeComponent();
            this.userName = userName;
            
            string[] questions = user.GetSecurity(userName);
            if (questions.Length == 2)
            {
                lblQ1.Text = questions[0];
                lblQ2.Text = questions[1];
            }
            else MessageBox.Show("Security questions is not set properly.");
        }

        private void frmReset_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(user.AuthenticateSecurity(userName,tboxA1.Text, tboxA2.Text))
            {
                //MessageBox.Show("OK");
                frmReset2 frmReset2 = new frmReset2(userName);
                frmReset2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Answer is incorrect.");
            }
        }

        private void tboxA1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
