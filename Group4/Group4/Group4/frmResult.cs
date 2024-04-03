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
    public partial class frmResult : Form
    {
        public frmResult()
        {
            InitializeComponent();
        }

        private void competitionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.competitionBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.managerDataSet);

        }

        private void frmResult_Load(object sender, EventArgs e)
        {
            //assign values to the cmbID combobox
            ArrayList competition = Competition.viewAll();
            foreach (Competition c in competition)
            {
                cmbID.Items.Add(c.Competition_id);
            }

            //call static method --> className.method
            ArrayList competitionList = Competition.viewAll();
            foreach (Competition comp in competitionList)
            {
                //create a new ListViewItem
                ListViewItem column = new ListViewItem();

                //set the competition_id as the first column
                column.Text = comp.Competition_id.ToString();

                //set other column
                column.SubItems.Add(comp.Competition_Name);
                column.SubItems.Add(comp.Date_time.ToShortDateString());
                column.SubItems.Add(comp.Venue);
                column.SubItems.Add(comp.Result);

                //add the items to the list view
                lstCompetition.Items.Add(column);
            }
        }
        private void cmbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //retrieve the selected ID from the combobox
            int selectedID = Convert.ToInt32(cmbID.SelectedItem);

            // Fetch the corresponding Competition object from the database
            Competition selectedCompetition = Competition.GetCompetitionByID(selectedID);

            // Display the competition name in the label
            lblName.Text = selectedCompetition.Competition_Name;
        }
        private void btnRecord_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve the selected Competition ID and result
                int competitionId = Convert.ToInt32(cmbID.SelectedItem);
                string result = cmbResult.SelectedItem.ToString();

                // Update the competition result in the database
                Competition competition = new Competition(competitionId);
                competition.Result = result;
                string message = competition.UpdateCompetitionResult(competitionId);
                MessageBox.Show(message);

                //Refresh the ListView
                RefreshCompetitionListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error recording competition result: " + ex.Message);
            }
        }
        private void RefreshCompetitionListView()
        {
            lstCompetition.Items.Clear();
            ArrayList competitionList = Competition.viewAll();
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
                column.SubItems.Add(competition.Result);

                //add the items to the list view
                lstCompetition.Items.Add(column);
            }
        }   
    }
}
