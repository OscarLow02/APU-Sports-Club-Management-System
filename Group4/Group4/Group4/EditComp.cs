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
    public partial class EditComp : Form
    { 
        //constructor that accepting competition details from frmModify
        public EditComp(int id, string name, DateTime dt, string v)
        {
            InitializeComponent();

            //set competitions details to the controls in the form
            lblCompID.Text = id.ToString();
            txtName.Text = name;
            dateTimeP.Value = dt;
            txtVenue.Text = v;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //check if any of the required fields are empty
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtVenue.Text) || dateTimeP.Value == null)
            {
                MessageBox.Show("Please enter name, venue or pick the date & time to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; //exit
            }
            else
            {
                //create a new competition object and pass the values to the constructor
                Competition edit = new Competition(int.Parse(lblCompID.Text), txtName.Text, dateTimeP.Value, txtVenue.Text);
                MessageBox.Show(edit.editCompetition());

                //close the form
                this.Close();
            }
        }
    }
}
