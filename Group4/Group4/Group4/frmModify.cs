using System;
using System.Collections;
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
    public partial class frmModify : Form
    {
        public frmModify()
        {
            InitializeComponent();
        }

        private void frmModify_Load(object sender, EventArgs e)
        {
            //arraylist allows to create dynamic size arrays
            ArrayList competitionList = new ArrayList();

            //call static method --> className.method
            competitionList = Competition.viewAll();
            foreach (Competition competition in competitionList)
            {
                //create a new ListViewItem
                ListViewItem column = new ListViewItem();

                //set the competition_id as the first column
                column.Text = competition.Competition_id.ToString();

                //set other column
                column.SubItems.Add(competition.Competition_Name);
                column.SubItems.Add(competition.Date_time.ToShortDateString());
                column.SubItems.Add(competition.Venue);

                //add the items to the list view
                lstCompetition.Items.Add(column);
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddComp add = new AddComp();
            add.ShowDialog();
            
            //refresh the list view
            RefreshCompetitionListView();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstCompetition.SelectedItems.Count == 1)
            {
                //get the selected competition details from the list view
                ListViewItem selectedItem = lstCompetition.SelectedItems[0];

                //retrieve the competition id from the first column
                int competitionId = int.Parse(selectedItem.SubItems[0].Text);

                //retrieve the competition name from the second column
                string competitionName = selectedItem.SubItems[1].Text;

                //retrieve the date and time from the third column
                DateTime dateTime = DateTime.Parse(selectedItem.SubItems[2].Text);

                //retrieve the venue from the fourth column
                string venue = selectedItem.SubItems[3].Text;

                //pass the competition details to EditComp form
                EditComp edit = new EditComp(competitionId, competitionName, dateTime, venue);
                edit.ShowDialog();
                RefreshCompetitionListView();
            }
            else
            {
                MessageBox.Show("Please select a row to edit the competition details.");
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //make sure that the user has selected a row
            if (lstCompetition.SelectedItems.Count == 1)
            {
                //get the selected competition details from the list view
                ListViewItem selectedItem = lstCompetition.SelectedItems[0];

                //retrieve the competition id from the first column
                int competitionId = int.Parse(selectedItem.SubItems[0].Text);

                //pass the competition id to the delCompetition method
                Competition del = new Competition(competitionId);

                //remove the selected item from the list view
                lstCompetition.Items.Remove(selectedItem);

                //call the delCompetition method
                MessageBox.Show(del.delCompetition());
                RefreshCompetitionListView();
            }
            else
            {
                MessageBox.Show("Please select a row to delete the competition details.");
                return;
            }
        }
        private void RefreshCompetitionListView()
        {
            //clear the list view
            lstCompetition.Items.Clear();

            //call the frmModify_Load method to refresh the list view
            frmModify_Load(null, null);
        }
    }
}
