using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comp123_s2016_assignment6
{
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
