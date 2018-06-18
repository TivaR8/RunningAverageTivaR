using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tiva Rait
 * Created on: 17-06-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #26 - Running Average
 * This program calculates your running average while you keep entering them 
*/

namespace RunningAverageTivaR
{
    public partial class frmRunningAverage : Form
    {
        int currentAverage = 0;
        int numberOfRuns;

        public frmRunningAverage()
        {
            InitializeComponent();
        }

        private void btnCalculateAverage_Click(object sender, EventArgs e)
        {
            int nextNumber;

            nextNumber = int.Parse(txtAverage.Text);

            // Check if the numbers are in the range
            if ((nextNumber >= 0) && (nextNumber <= 100))
            {
                numberOfRuns = numberOfRuns + 1;
                currentAverage = nextNumber + currentAverage;
                currentAverage = currentAverage / numberOfRuns;

                lblTheAverage.Show();
                lblTheAverage.Text = ("The running average is " + currentAverage);
            }
            // If user enters -1, display a goodbye message and disable buttons
            else if (nextNumber == -1)
            {
                MessageBox.Show("Running average ended.", "Running Average");
                this.btnCalculateAverage.Enabled = false;
                this.txtAverage.Visible = false;
            }
        }
    }
}
