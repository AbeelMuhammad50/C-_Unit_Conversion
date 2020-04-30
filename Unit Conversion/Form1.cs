using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit_Conversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // converts Inches to Centimeters
        public double Inch2Cm(double inch)
        {
            return inch * 2.54;
        }

        // converts Centimeters to Inches
        public double Cm2Inch(double cm)
        {
            return cm / 2.54;    
        }

        // converts foots to Centimeters
        public double Foot2Cm(double foot)
        {
            return foot * 30.48;
        }

        // converts Centimeters to Foots
        public double Cm2Foot(double cm)
        {
            return cm / 30.48;
        }

        // Converts Yards to Centimeters
        public double Yard2Cm(double yard)
        {
            return yard * 91.44;
        }

        // converts centimeters to yards
        public double Cm2Yard(double cm)
        {
            return cm / 91.44;
        }

        // Input Text Box Validation
        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(inputTextBox.Text, "[^0-9.]"))
            {
                MessageBox.Show("Please enter only numbers.");
                inputTextBox.Text = inputTextBox.Text.Remove(inputTextBox.Text.Length - 1);
            }
        }

        // converts inches to centimeter
        private void inchToCmButton_Click(object sender, EventArgs e)
        {
            if (this.inputTextBox.Text == "")
            {
                MessageBox.Show("Input Cannot be empty");
                return;
            }

            inputlabel.Text = "Inches:";
            outputlabel.Text = "Centimeters:";
            outputTextBox.Text = String.Format("{0:0.00}", Inch2Cm(Double.Parse(inputTextBox.Text)));
        }

        // Converts Centimeters to Inches
        private void CmToInchButton_Click(object sender, EventArgs e)
        {
            if (this.inputTextBox.Text == "")
            {
                MessageBox.Show("Input Cannot be empty");
                return;
            }

            inputlabel.Text = "Centimeters:";
            outputlabel.Text = "Inches:";
            outputTextBox.Text = String.Format("{0:0.00}", Cm2Inch(Double.Parse(inputTextBox.Text)));
        }

        // Converts Foot to centimeters
        private void FootToCmButton_Click(object sender, EventArgs e)
        {
            if (this.inputTextBox.Text == "")
            {
                MessageBox.Show("Input Cannot be empty");
                return;
            }

            inputlabel.Text = "Foot:";
            outputlabel.Text = "Centimeters:";
            outputTextBox.Text = String.Format("{0:0.00}", Foot2Cm(Double.Parse(inputTextBox.Text)));
        }

        // converts Centimeters to Foot
        private void CmToFootButton_Click(object sender, EventArgs e)
        {
            if (this.inputTextBox.Text == "")
            {
                MessageBox.Show("Input Cannot be empty");
                return;
            }

            inputlabel.Text = "Centimeters:";
            outputlabel.Text = "Foot:";
            outputTextBox.Text = String.Format("{0:0.00}", Cm2Foot(Double.Parse(inputTextBox.Text)));
        }

        // Converts Yards to Centimeters
        private void YardToCmButton_Click(object sender, EventArgs e)
        {
            if (this.inputTextBox.Text == "")
            {
                MessageBox.Show("Input Cannot be empty");
                return;
            }

            inputlabel.Text = "Yards:";
            outputlabel.Text = "Centimeters:";
            outputTextBox.Text = String.Format("{0:0.00}", Yard2Cm(Double.Parse(inputTextBox.Text)));
        }

        // Converts Centimeters to Yards
        private void CmToYardButton_Click(object sender, EventArgs e)
        {
            if (this.inputTextBox.Text == "")
            {
                MessageBox.Show("Input Cannot be empty");
                return;
            }

            inputlabel.Text = "Centimeters:";
            outputlabel.Text = "Yards:";
            outputTextBox.Text = String.Format("{0:0.00}", Cm2Yard(Double.Parse(inputTextBox.Text)));
        }
    }
}
