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
    public partial class AddComp : Form
    {
        public AddComp()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //check if any of the required fields are empty
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtVenue.Text) ||  dateTime.Value == null)
            {
                MessageBox.Show("Please enter name, venue or pick the date & time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; //exit
            }
            else
            {
                Competition add = new Competition(txtName.Text, dateTime.Value, txtVenue.Text);
                MessageBox.Show(add.addCompetition());

                //clear the text box
                txtName.Clear();
                txtVenue.Clear();
                this.Close();
            }
        }
    }
}
