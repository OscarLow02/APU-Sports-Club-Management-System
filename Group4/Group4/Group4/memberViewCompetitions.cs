using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Group4
{

    public partial class memberViewCompetitions : Form
    {
        Member member = new Member();
        public memberViewCompetitions()
        {
            InitializeComponent();
        }

        private void listCompetitions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void memberViewCompetitions_Load(object sender, EventArgs e)
        {
            ArrayList competitionsList = new ArrayList();

            competitionsList = member.ViewCompetitions();

            foreach (ArrayList arrayList in competitionsList)
            {
                listCompetitions.Items.Add(new ListViewItem(new string[] { (string)arrayList[0], (string)arrayList[1], (string)arrayList[2], (string)arrayList[3] }));

            }
        }

    }
}
