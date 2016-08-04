using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comp123_s2016_assignment6
{
    /** <summary>
    * This class defines a form for a BMI calculator.
    * </summary>
    * 
    * @class BMICalculator
    * @extends Form
    */
    public partial class BMICalculator : Form
    {

        // FIELDS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        // PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /** <summary>
        * This is the default constructor.
        * </summary>
        *
        * @method BMICalculator
        */
        public BMICalculator()
        {
            InitializeComponent();
        }

        // PRIVATE METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        
        /** <summary>
        * This method inputs a number into HeightTextBox or WeightTextBox when a button from NumPadTableLayoutPanel is clicked.
        * </summary>
        *
        * @method NumPad_Click
        * @param {object} sender
        * @param {EventArgs} e
        * @private
        */
        private void NumPad_Click(object sender, EventArgs e)
        {
            Button numberClicked = sender as Button;
            if (String.Equals(HeightTextBox.Text, "0"))
            {
                HeightTextBox.Clear();
                HeightTextBox.Text = numberClicked.Text;
            }
            else
            {
                HeightTextBox.Text += numberClicked.Text;
            }
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            HeightTextBox.Text = "0";
            WeightTextBox.Text = "0";
            CalculatedBMITextBox.Text = "";
            BMIResultsMultilineTextBoxControl.Text = "";
        }

        // PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    }
}
