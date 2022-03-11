using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WallE.World;

namespace WallE_Visual.MainApp
{
    public partial class ZoomWorldForm : Form
    {
        WorldViewer.WorldViewer worldViewer;

        public ZoomWorldForm( )
        {
            InitializeComponent( );
            this.tbarZoom.Value = 4;
        }
        public ZoomWorldForm(ref WorldViewer.WorldViewer viewer) : this()
        {
            this.worldViewer = viewer;
        }

        private void tbarZoom_Scroll(object sender,EventArgs e)
        {
            Zoom_Scroll( );
        }
        private void Zoom_Scroll( )
        {
            this.worldViewer.ModifySize(this.tbarZoom.Value,this.tbarZoom.Maximum);
        }

      
    }
}
