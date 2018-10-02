using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaydaySimulator
{
    public partial class PaydayWindow : Form
    {
        /// <summary>
        /// holds hourly rate info
        /// </summary>
        double hourlyRate;

        /// <summary>
        /// tracks current progress
        /// </summary>
        double totalMade = 0;

        /// <summary>
        /// tracks fractions of a penny to a reasonable extent
        /// </summary>
        double pennyFraction = 0;

        /// <summary>
        /// stores the "pennies per second" rate - used for progress bar speed
        /// </summary>
        double secondRate;

        public PaydayWindow()
        {
            InitializeComponent();
        }
        private void LoadForm(object sender, EventArgs e)
        {
            // loads info into system
            hourlyRate = Convert.ToDouble(HourlyWageTextBox.Text);
            // converts hourly rate to second-ly rate
            secondRate = hourlyRate/60/60;
            HourlyWageTextBox.BackColor = Color.LightBlue;
        }
        private void updateTick(object sender, EventArgs e)
        {
            // totals up what was made since the last tick
            // divided by 60 twice for minutes then seconds, multiplied by 1000 and then divided by updateTimer.Interval to deal with milliseconds
            totalMade += hourlyRate / 60 / 60 * 1000 / updateTimer.Interval; 

            // the portion left over is a fraction of a penny
            pennyFraction = totalMade % 1;

            // makes the progress bar... progress
            progressBar1.Value = Convert.ToInt32(pennyFraction * 100);

            try
            {
                //a quick add and subtract to make the progress bar "snap" into place as opposed to the slow speed it would otherwise use (which is too slow for this application)
                progressBar1.Value = progressBar1.Value - 1;
                progressBar1.Value = progressBar1.Value + 1;

            }
            catch //neccessary due to negative numbers causing a crash
            {
                progressBar1.Value = 0;
            }
            TotalMadeLabel.Text = (totalMade-pennyFraction).ToString(); // updates the display
        }

        /// <summary>
        /// resets the counts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reset(object sender, EventArgs e)
        {
            totalMade = 0; TotalMadeLabel.Text = "0.00";
            pennyFraction = 0;
        }

        /// <summary>
        /// updates when the hourly wage textbox is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Hourly_TextChanged(object sender, EventArgs e)
        {
            ///makes the textbox light blue if the input is valid, or light coral if invalid
            try
            {
                hourlyRate = Convert.ToDouble(HourlyWageTextBox.Text);
                HourlyWageTextBox.BackColor = Color.LightBlue;
            }
            catch
            {
                HourlyWageTextBox.BackColor = Color.LightCoral;
            }
        }

        
    }
}
