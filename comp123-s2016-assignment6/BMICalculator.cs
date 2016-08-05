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

        private Control _lastFocusedControl;  //used for NumPad to work
        private double _calculatedResult;
        private double _weightValue;
        private double _heightValue;

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

        /** <summary>
         * This is the property that read/writes the _calculatedResult field.
         * </summary>
         *
         * @property {double} CalculatedResult
         */
        public double CalculatedResult
        {
            get
            {
                return _calculatedResult;
            }
            set
            {
                _calculatedResult = value;
            }
        }

        /** <summary>
         * This is the property that read/writes the _weightValue field.
         * </summary>
         *
         * @property {double} WeightValue
         */
        public double WeightValue
        {
            get
            {
                return _weightValue;
            }
            set
            {
                _weightValue = value;
            }
        }

        /** <summary>
         * This is the property that read/writes the _heightValue field.
         * </summary>
         *
         * @property {double} HeightValue
         */
        public double HeightValue
        {
            get
            {
                return _heightValue;
            }
            set
            {
                _heightValue = value;
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
            if (LastFocusedControl == HeightTextBox || LastFocusedControl == WeightTextBox)
            {
                if (!(String.Equals(LastFocusedControl.Text, "0")))
                {
                    if (LastFocusedControl.Text.Length == 1)
                    {
                        LastFocusedControl.Text = "0";
                    }
                    else
                    {
                        LastFocusedControl.Text = LastFocusedControl.Text.Remove(LastFocusedControl.Text.Length - 1);
                    }
                    LastFocusedControl.Focus();
                }
            }
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
            if (!(String.Equals(HeightTextBox.Text, "0") || HeightTextBox.Text.EndsWith(".") ||
                WeightTextBox.Text.EndsWith(".")))
            {

                WeightValue = Convert.ToDouble(WeightTextBox.Text);
                HeightValue = Convert.ToDouble(HeightTextBox.Text);

                if (ImperialRadioButton.Checked == true)
                {
                    CalculatedResult = (WeightValue * 703) / (HeightValue * HeightValue);
                }
                else if (MetricRadioButton.Checked == true)
                {
                    CalculatedResult = (WeightValue) / (HeightValue * HeightValue);
                }

                CalculatedResult = Math.Round(CalculatedResult, 1);
                CalculatedBMITextBox.Text = Convert.ToString(CalculatedResult);
                BMIResultsTextBox.Text = String.Format("Underweight: < 18.5\r" +
                                                       "Normal: 18.5~24.9\r" +
                                                       "Overweight: 25~29.9\r" +
                                                       "Obese: >= 30");
                BMIResultsTextBox.Text += String.Format("\r\n\r\nYour BMI is {0}.", (Convert.ToString(CalculatedResult)));

               if (CalculatedResult < 18.5)
                {
                    BMIResultsTextBox.Text += String.Format("\r\nYou are underweight.");
                }
               else if ((CalculatedResult > 18.5) && (CalculatedResult < 24.9))
                {
                    BMIResultsTextBox.Text += String.Format("\r\nYou have a normal BMI.");
                }
               else if ((CalculatedResult > 25) && (CalculatedResult < 29.9))
                {
                    BMIResultsTextBox.Text += String.Format("\r\nYou are overweight.");
                }
               else if (CalculatedResult >= 30)
                {
                    BMIResultsTextBox.Text += String.Format("\r\nYou are obese.");
                }
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
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
            if (LastFocusedControl == HeightTextBox || LastFocusedControl == WeightTextBox)
            {
                if (!(String.Equals(LastFocusedControl.Text, "0") || LastFocusedControl.Text.Contains(".")))
                {
                    LastFocusedControl.Text += ".";
                    LastFocusedControl.Focus();
                }
                LastFocusedControl.Focus();
            }
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
            if (LastFocusedControl == HeightTextBox || LastFocusedControl == WeightTextBox)
            {
                if (!(LastFocusedControl.Text.Length > 10))
                {
                    if (String.Equals(LastFocusedControl.Text, "0"))
                    {
                        LastFocusedControl.Text = numberClicked.Text;
                        LastFocusedControl.Focus();
                    }
                    else
                    {
                        LastFocusedControl.Text += numberClicked.Text;
                        LastFocusedControl.Focus();
                    } 
                }
                else
                {
                    MessageBox.Show("Maximum digits reached.");
                }
            }   
        }

        /**<summary>
        * This method asks for confirmation before closing the application.
        * </summary>
        *
        * @method BMICalculator_FormClosing
        * @params {object} sender
        * @params {FormClosingEventArgs} e
        * @private
        * @returns {void}
        */
        private void BMICalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Result;
            Result = MessageBox.Show("Exit program?", "Exit", MessageBoxButtons.OKCancel);
            if (Result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }

        }

        /**<summary>
        * This method closes the application.
        * </summary>
        *
        * @method BMICalculator_FormClosed
        * @params {object} sender
        * @params {FormClosedEventArgs} e
        * @private
        * @returns {void}
        */
        private void BMICalculator_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    }
}
