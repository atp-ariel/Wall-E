using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WallE_Visual.MainApp
{
    public partial class ZoomRutForm : Form
    {
        RutViews rutView;
        public ZoomRutForm( )
        {
            InitializeComponent( );
            this.tbarZoom.Value = 4;
        }
        public ZoomRutForm(ref RutViews viewer) : this( )
        {
            
            this.rutView = viewer;
        }

        private void tbarZoom_Scroll(object sender,EventArgs e)
        {
            Zoom_Scroll( );
        }
        private void Zoom_Scroll( )
        {
            this.rutView.ModifySize(this.tbarZoom.Value,this.tbarZoom.Maximum);
        }
    }
}
