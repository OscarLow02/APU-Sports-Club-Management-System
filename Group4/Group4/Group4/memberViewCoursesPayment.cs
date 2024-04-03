using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Group4
{
    public partial class memberViewCoursesPayment : Form
    {
        public memberViewCoursesPayment()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Member member = new Member();

            if (txtCNum.Text.Length == 16 && long.TryParse(txtCNum.Text, out _))
            {
                string pattern = @"^(0[1-9]|1[0-9]|2[0-9]|3[0-1])\/(2[4-9]|3[0-9])$";

                if (Regex.IsMatch(txtDate.Text, pattern))
                {
                    if (txtCV.Text.Length == 3 && int.TryParse(txtCV.Text, out _))
                    {
                        MessageBox.Show("Transaction successful");
                        member.AddtoPayment();
                        this.Close();
                    }
                    else { MessageBox.Show("Incorrect CV!"); }
                }
                else { MessageBox.Show("Incorrect date!"); }

            }
            else { MessageBox.Show("Incorrect card number!"); }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void memberViewCoursesPayment_Load(object sender, EventArgs e)
        {

        }
    }
}
