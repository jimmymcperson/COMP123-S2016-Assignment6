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
 * ==================================================================================================
 * Author: Jonathan Hao
 * Student#: 300869273
 * Date Modified: August 5, 2016
 * Description: This is a demonstration of Windows Forms applications.
 * Version: 0.1.2 - Minor edits
 * ==================================================================================================
 */
namespace comp123_s2016_assignment6
{
    /** <summary>
    * This class defines a form for a splash screen.
    * </summary>
    * 
    * @class SplashScreen
    * @extends Form
    */
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        /** <summary>
        * This method closes the form after 3 seconds.
        * </summary>
        *
        * @method SplashScreenTimer_Tick
        * @params {object} sender
        * @params {EventArgs} e
        * @private
        * @returns {void}
        */
        private void SplashScreenTimer_Tick(object sender, EventArgs e)
        {
            SplashScreenTimer.Enabled = false;
            this.Hide();
            Program.mainForm.Show();
        }
    }
}
