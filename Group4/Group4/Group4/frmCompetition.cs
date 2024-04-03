using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Group4
{
    
    public partial class frmCompetition : Form
    {

        
        Admin admin = new Admin();

        public frmCompetition()
        {
            InitializeComponent();
            this.Size = new Size(800, 655);

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void frmCompetition_Load(object sender, EventArgs e)
        {
            //Y Axis
            chart.ChartAreas[0].AxisY.Interval = 1;

            //X Axis
            chart.ChartAreas[0].AxisX.LabelStyle.Format = "MM-yyyy";
            chart.ChartAreas[0].AxisX.Interval = 1;
            chart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Months;
            chart.ChartAreas[0].AxisX.IsLabelAutoFit = false;
            chart.ChartAreas[0].AxisX.LabelStyle.IsEndLabelVisible = true;
            chart.ChartAreas[0].AxisX.LabelStyle.Angle = -45; //readability

            // load data and update labels
            LoadChartData();
            lblWin.Text = admin.TotalResult("Won");
            lblLost.Text = admin.TotalResult("Lost");
        }

        //private void LoadChartData()
        //{

        //    DataTable dt = admin.GetMonthlyResults();

        //    // Clear the chart
        //    chart.Series.Clear();

        //    // Add series for "Win" and "Lost"
        //    var seriesWin = new Series("Win");
        //    var seriesLoss = new Series("Loss");
        //    chart.Series.Add(seriesWin);
        //    chart.Series.Add(seriesLoss);

        //    // Bind data to the series
        //    foreach (DataRow row in dt.Rows)
        //    {
        //        if (row["result"].ToString() == "Win")
        //        {
        //            seriesWin.Points.AddXY(row["Month"], row["Total"]);
        //        }
        //        else if (row["result"].ToString() == "Loss")
        //        {
        //            seriesLoss.Points.AddXY(row["Month"], row["Total"]);
        //        }
        //    }
        //}
        private void LoadChartData()
        {
            DataTable dt = admin.GetMonthlyResults();
            // Clear the chart
            chart.Series.Clear();

            // Add series for "Win" and "Lost"
            var seriesWin = new Series("Win");
            var seriesLoss = new Series("Loss");

            // test data points
            //seriesWin.Points.AddXY("01-2023", 1);
            //seriesWin.Points.AddXY("01-2024", 2);
            //seriesLoss.Points.AddXY("01-2023", 2);
            //seriesLoss.Points.AddXY("01-2024", 1);
            //seriesLoss.Points.AddXY("01-2024", 1);

            foreach (DataRow row in dt.Rows)
            {
                DateTime monthDate = DateTime.ParseExact(row["Month"].ToString(), "MM-yyyy", CultureInfo.InvariantCulture);

                if (row["result"].ToString() == "Won")
                {
                    seriesWin.Points.AddXY(monthDate, row["Total"]);
                }
                else if (row["result"].ToString() == "Lost")
                {
                    seriesLoss.Points.AddXY(monthDate, row["Total"]);
                }
            }

            // Add series to chart
            chart.Series.Add(seriesWin);
            chart.Series.Add(seriesLoss);
        }



        private void lblManage_Click(object sender, EventArgs e)
        {
            frmAdminHome frmAdminHome = new frmAdminHome();
            frmAdminHome.Show();
            this.Close();
        }

        private void lblSuggestion_Click(object sender, EventArgs e)
        {
            frmSuggestion frmSuggestion = new frmSuggestion();
            frmSuggestion.Show();
            this.Close();
        }

        private void lblIncome_Click(object sender, EventArgs e)
        {
            frmIncome frmIncome = new frmIncome();
            frmIncome.Show();
            this.Close();
        }

        private void lblUpdate_Click(object sender, EventArgs e)
        {
            frmUpdate frmUpdate = new frmUpdate();
            frmUpdate.Show();
            this.Close();
        }

        private void btnAdmExit_Click(object sender, EventArgs e)
        {
            CurrentUser.UserName = null;
            this.Close();
        }

        private void lblWin_Click(object sender, EventArgs e)
        {

        }

        private void lblLost_Click(object sender, EventArgs e)
        {

        }
    }

}
