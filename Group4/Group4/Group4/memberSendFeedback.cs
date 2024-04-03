using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group4
{
    public partial class memberSendFeedback : Form
    {
        public memberSendFeedback()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            member.SendFeedback(txtFeedback.Text);
            MessageBox.Show("Sent.");

        }
    }
}
