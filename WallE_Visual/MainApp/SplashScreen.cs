using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WallE_Visual
{
    public partial class formSplashScreen : Form
    {
        Timer timer;
        public formSplashScreen( )
        {
            InitializeComponent( );
        }

        private void SplashScreen_Shown(object sender,EventArgs e)
        {
            InitializeTimerScree( );
        }

        private void InitializeTimerScree( )
        {
            timer = new Timer( );

            timer.Interval = 1800;
            timer.Start( );
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender,EventArgs e)
        {
            timer.Stop( );

            SettingsWorldForm adjust = new SettingsWorldForm( );

            adjust.Show( );

            this.Hide( );
        }
    }
}
