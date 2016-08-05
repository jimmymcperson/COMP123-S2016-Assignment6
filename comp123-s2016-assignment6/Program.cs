using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * ==================================================================================================
 * Author: Jonathan Hao
 * Student#: 300869273
 * Date Modified: August 4, 2016
 * Description: This is a demonstration of Windows Forms applications.
 * Version: 0.0.4 - Refactored NumPad_Click, added functionality to DecimalButton, BackspaceButton,
 * started coding CalculateBMIButton
 * ==================================================================================================
 */
namespace comp123_s2016_assignment6
{
    /** <summary>
    * This is the driver class for the program.
    * </summary>
    *
    * @class Program
    */
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        /** <summary>
        * This is the "main" method.
        * </summary>
        * 
        * @method Main
        * @returns {void}
        */
        public static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BMICalculator mainForm = new BMICalculator();
            Application.Run(mainForm);

        }
    }
}
