using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * ==================================================================================================
 * Author: Jonathan Hao
 * Student#: 300869273
 * Date Modified: August 3, 2016
 * Description: This is a demonstration of Windows Forms applications.
 * Version: 0.0.2 - Made layout for calculator
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
    static class Program
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
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BMICalculator());
        }
    }
}
