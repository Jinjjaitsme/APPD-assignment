using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPD_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartNavigation_Click(object sender, EventArgs e)
        {
            string msg = "~~Trip Overview~~";
            Guide pathfind;
            pathfind = new Guide(cbFrom.Text,cbTo.Text);
            Guide stationcount;
            stationcount = new Guide(cbFrom.Text, cbTo.Text);
            


            msg += "\r\nFrom :: " + cbFrom.Text;
            msg += "\r\n\r\n   To :: " + cbTo.Text;



            txtSummary.Text = msg + "\r\n\r\n" + "Number of Stations :: "+stationcount.StationCount() + "\r\n\r\n" + pathfind.pathFind();



        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            Map form2 = new Map();
            form2.Show();
        }

        private void btnShowNotification_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There will be track maintenance on 5 January 2019 from 4AM to 12PM .\n\rAffected stations are EW24 - Chinese Garden , EW23 - Clementi , EW22 - Dover.\n\r\n\rDear commuters , please plan your journey ahead of time ! \n\r\n\rThank You for traveling with SMRT !" , "Scheduled Maintenance on 5 January 2019" , MessageBoxButtons.OK ,MessageBoxIcon.Information);
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            FeedbackForm form3 = new FeedbackForm();
            form3.Show();
        }
    }
}
