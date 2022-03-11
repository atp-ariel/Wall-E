using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WallE_Visual.MainApp;
using WallE.World;

namespace WallE_Visual
{
    public partial class SettingsWorldForm : Form
    {
        #region Constructor
        public SettingsWorldForm( )
        {
            InitializeComponent( );

            this.menuToolStripRestartWorld.Enabled = false;
            this.simularToolStripMenuItem.Enabled = false;
            this.tbarZoom.Visible = false;
            this.lblZoom.Visible = false;
            this.lblMaxZoom.Visible = false;
            this.lblMinZoom.Visible = false;
        }
        #endregion

        #region Events
        private void menuToolStripAddWorld_Click(object sender,EventArgs e)
        {
            AddWorld( );

            this.tbarZoom.Value = 4;
            this.tbarZoom.Visible = true;
            this.lblZoom.Visible = true;
            this.lblMaxZoom.Visible = true;
            this.lblMinZoom.Visible = true;
        }
        private void SettingsWorldForm_FormClosed(object sender,FormClosedEventArgs e)
        {
            Application.Exit( );
        }
        private void menuToolStripRestartWorld_Click(object sender,EventArgs e)
        {
            RestartWorld( );
        }
        private void tbarZoom_Scroll(object sender,EventArgs e)
        {
            Zoom_Scroll( );
        }
        private void simularToolStripMenuItem_Click(object sender,EventArgs e)
        {
            Simulate( );

        }
        #endregion

        #region Methods
        private void Simulate( )
        {
            if ( this.wViewConfig.World.SelectIProgrammables( ).Count == 0 )
            {
                MessageBox.Show("No existen objetos programables para simular.","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            SimulatorForm main = new SimulatorForm((Map) this.wViewConfig.World.Clone( ));

            main.ShowDialog( );

            main = null;

            this.wViewConfig.Refresh( );
        }
        private void Zoom_Scroll( )
        {
            this.wViewConfig.ModifySize(this.tbarZoom.Value,this.tbarZoom.Maximum);
        }
        private void AddWorld( )
        {
            AddWorldForm addWorld = new AddWorldForm( );

            if ( addWorld.ShowDialog( ) == DialogResult.OK )
            {
                this.wViewConfig.SetWorld(addWorld.Row,addWorld.Column);
                this.menuToolStripRestartWorld.Enabled = true;
                this.wViewConfig.IsReadOnly = false;
                this.simularToolStripMenuItem.Enabled = true;
            }

        }
        private void RestartWorld( )
        {
            if ( MessageBox.Show("¿Desea reiniciar el mundo? \nSi lo reinicia perderá todas las rutina que no haya exportado.","Advertencia de reinicio",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes )
                this.wViewConfig.SetWorld(this.wViewConfig.World.Rows,this.wViewConfig.World.Columns);
        }
        #endregion
    }
}
