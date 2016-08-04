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

        private Control _lastFocusedControl;

        // PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /** <summary>
         * This is the property that read/writes the _lastFocusedControl field.
         * </summary>
         *
         * @property {Control} LastFocusedControl
         */
        public Control LastFocusedControl
        {
            get
            {
                return _lastFocusedControl;
            }
            set
            {
                _lastFocusedControl = value;
            }
        }

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
            this.LastFocusedControl = HeightTextBox;
        }

        // PRIVATE METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /** <summary>
        * This method truncates the rightmost digit in HeightTextBox or WeightTextBox when the
        * BacksspaceButton is clicked.
        * </summary>
        *
        * @method BackspaceButton_Click
        * @params {object} sender
        * @params {EventArgs} e
        * @private
        * @returns {void}
        */
        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            
        }

        /** <Summary>
        * This method calculates BMI using the values in HeightTextBox and WeightTextBox when the 
        * CalculateBMIButton is clicked.
        * </Summary>
        *
        * @method CalculateBMIButton_Click
        * @params {object} sender
        * @params {EventArgs} e
        * @private
        * @returns {void}
        */
        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {

        }

        /** <Summary>
        * This method clears the fields for HeightTextBox, WeightTextBox, CalculatedBMITextBox, and BMIResultsTextBox
        * when the ClearAllButton is clicked.
        * </Summary>
        *
        * @method ClearAllButton_Click
        * @params {object} sender
        * @params {EventArgs} e
        * @private
        * @returns {void}
        */
        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            HeightTextBox.Text = "0";
            WeightTextBox.Text = "0";
            CalculatedBMITextBox.Text = "";
            BMIResultsTextBox.Text = "";
            _lastFocusedControl = null;
        }

        /**<summary>
        * This method sets the _lastFocusedControl field to the current control focused upon any "enter" event.
        * </summary>
        *
        * @method Control_Enter
        * @params {object} sender
        * @params {EventArgs} e
        * @private
        * @returns {void}
        */
        private void Control_Enter(object sender, EventArgs e)
        {
            _lastFocusedControl = sender as Control;
        }

        /** <summary>
        * This method appends a decimal point to HeightTextBox or WeightTextBox when DecimalButton is clicked.
        * </summary>
        *
        * @method DecimalButton_Click
        * @param {object} sender
        * @param {EventArgs} e
        * @private
        * @returns {void}
        */
        private void DecimalButton_Click(object sender, EventArgs e)
        {

        }

        /** <summary>
        * This method appends a number to HeightTextBox or WeightTextBox when a button from
        * NumPadTableLayoutPanel is clicked.
        * </summary>
        *
        * @method NumPad_Click
        * @param {object} sender
        * @param {EventArgs} e
        * @private
        * @returns {void}
        */
        private void NumPad_Click(object sender, EventArgs e)
        {
            Button numberClicked = sender as Button;
            if (LastFocusedControl == HeightTextBox)
            {
                if (String.Equals(HeightTextBox.Text, "0"))
                {
                    HeightTextBox.Clear();
                    HeightTextBox.Text = numberClicked.Text;
                    HeightTextBox.Focus();
                }
                else
                {
                    HeightTextBox.Text += numberClicked.Text;
                    HeightTextBox.Focus();
                }
            }
            if (LastFocusedControl == WeightTextBox)
            {
                if (String.Equals(WeightTextBox.Text, "0"))
                {
                    WeightTextBox.Clear();
                    WeightTextBox.Text = numberClicked.Text;
                    WeightTextBox.Focus();
                }
                else
                {
                    WeightTextBox.Text += numberClicked.Text;
                    WeightTextBox.Focus();
                }
            }
                
        }

        // PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    }
}
