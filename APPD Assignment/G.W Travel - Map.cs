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
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String LOS = txtLOS2.Text;
            String StationName = txtStationName.Text;
            String LOS2 = txtLOS2.Text;
            String StationName2 = txtStationName2.Text;

            try
            {
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("https://maps.google.com/maps?q=");

                if (LOS != String.Empty)
                {
                    queryaddress.Append(LOS + "," + "+");
                }
                else
                {
                    queryaddress.Append("to " + LOS + "," + "+");
                }
                if (StationName != String.Empty)
                {
                    queryaddress.Append(StationName + " MRT" + "+");
                }


                if (LOS2 != String.Empty)
                {
                    queryaddress.Append("to " + LOS2 + "," + "+");
                }
                else
                {
                    queryaddress.Append("to " + LOS2 + "," + "+");
                }

                if (StationName2 != String.Empty)
                {
                    queryaddress.Append(StationName2 + " MRT" + "+");
                }

                webBrowser1.Navigate(queryaddress.ToString());
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),"Error");
            }
        }
    }
}
