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
    public partial class FeedbackForm : Form
    {
        public FeedbackForm()
        {
            InitializeComponent();
        }

        private void FeedbackForm_Load(object sender, EventArgs e)
        {
            txtFeedback.Text = txtFeedback.Text + "\r\n\r\n";
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFeedback.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtFeedback.Text == "")
            {
                MessageBox.Show("Please input your feedback", "Did you miss out something?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Feedback submitted \r\nThank You for your feedback !" , "G.W Travel" , MessageBoxButtons.OK , MessageBoxIcon.Information);
            }
        }

       
    }
}
