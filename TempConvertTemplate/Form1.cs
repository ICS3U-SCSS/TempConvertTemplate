/// Created by Mr. T
/// To demonstrate creation of custom methods that use parameters and return values

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TempConvertTemplate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            double temp; // holds value inputted by the user
            double answer; // hold the converted temp

            temp = Convert.ToDouble(tempInput.Text);

            /// checks to see that conversion option has been selected and runs 
            /// appropriate custom method based on that option
            if (fahToCelButton.Checked)
            {

            }
            else if (celToFahButton.Checked)
            {

            }
        }
    }
}
