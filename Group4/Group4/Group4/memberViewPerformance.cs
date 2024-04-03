using System;
using System.Collections;
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
using System.Xml.Linq;

namespace Group4
{
    public partial class memberViewPerformance : Form
    {
        public memberViewPerformance()
        {
            InitializeComponent();
        }

        private void memberViewPerformance_Load(object sender, EventArgs e)
        {
            DatabaseLoad();
        }

        private void DatabaseLoad()
        {
            Member member = new Member();
            ArrayList performanceList = new ArrayList();

            performanceList = member.ViewPerformance();

            foreach (ArrayList arrayList in performanceList) 
            {
                listCompetition.Items.Add(new ListViewItem(new string[] { (string)arrayList[0], (string)arrayList[1], (string)arrayList[2], (string)arrayList[3], (string)arrayList[4] }));

            }

        }

        private void listCompetition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
