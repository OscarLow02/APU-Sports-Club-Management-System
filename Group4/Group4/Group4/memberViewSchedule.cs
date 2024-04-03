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

namespace Group4
{
    public partial class memberViewSchedule : Form
    {

        Member member = new Member();
        public memberViewSchedule()
        {
            InitializeComponent();
        }

        private void memberViewSchedule_Load(object sender, EventArgs e)
        {
            LoadDataFromDatabase();
        }

        private void LoadDataFromDatabase()
        {
            
            ArrayList scheduleList = new ArrayList();
            scheduleList = member.ViewSchedule();

            foreach (ArrayList arrayList in scheduleList)
            {
                lstSchedule.Items.Add(new ListViewItem(new string[] { (string)arrayList[0], (string)arrayList[1], (string)arrayList[2], (string)arrayList[3], (string)arrayList[4], (string)arrayList[5], (string)arrayList[6] }));
            }
        }

    }
}
