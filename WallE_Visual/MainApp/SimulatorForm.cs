using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using WallE.Simulator;
using WallE.World;
using WallE.Errors;
using WallE.Routine;

namespace WallE_Visual.MainApp
{
    public partial class SimulatorForm : Form
    {
        #region Properties
        public Simulator CurrentSimulator { get; private set; }
        bool WasError;
        bool play;
        #endregion

        #region Constructors
        public SimulatorForm( )
        {
            InitializeComponent( );
            ReloadMenu( );
            Simulator.NoAllowErrors = true;
            Simulator.Error += ThrowNewError;
            Error.SystemError += ThrowNewSystemError;
            Rut.ExecuteInstruction += PaintRutine;
        }
        public SimulatorForm(Map world) : this( )
        {
            this.CurrentSimulator = new Simulator(world);
            this.CurrentSimulator.TimeSimulation = 0.2;

            this.wView.IsReadOnly = true;
            this.wView.SetWorld(world);
            this.wView.Refresh( );

            this.wEConsole.Refresh( );
        }
        #endregion

        #region Events
        private void PaintRutine(object sender, EventArgs e)
        {
            if ( CurrentSimulator.IsDebugging )
            {
                this.ajustarTamañoDeLaRutinaToolStripMenuItem.Enabled = true;
                this.rutView.SetRut((Rut) sender);
                this.rutView.PaintIn(Rut.LastInstruction);
            }
        }
        private void btnDebug_Click(object sender,EventArgs e)
        {
            Debug( );
        }
        private void ThrowNewSystemError(object sender, EventArgs e)
        {
            MessageBox.Show(Error.CurrentError.Message,"Error de sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
            this.Close( );
        }
        private void ThrowNewError(object sender, EventArgs e)
        {
            timer.Stop( );
            this.tboxNumberRound.Clear( );
            this.tboxNumberRound.Text = CurrentSimulator.Rounds.ToString( );
            this.wView.SetWorld(CurrentSimulator.World);
            this.wView.Refresh( );
            play = false;
            WasError = true;
            MessageBox.Show(Simulator.CurrentError.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //this.Close( );
        }
        private void ajustarTamañoDelMundoToolStripMenuItem_Click(object sender,EventArgs e)
        {
            DoZoom( );
        }
        private void btnAdvance_Click(object sender,EventArgs e)
        {
            if ( play )
                AdvanceUsedByPlay( );
            else
                Advance( );

        }
        private void btnStop_Click(object sender,EventArgs e)
        {
            Stop( );
        }
        private void btnPlay_Click(object sender,EventArgs e)
        {
            Play( );
        }
        private void btnPause_Click(object sender,EventArgs e)
        {
            CurrentSimulator.Pause( );
        }
        private void ajustarTamañoDeLaRutinaToolStripMenuItem_Click(object sender,EventArgs e)
        {
            DoRutZoom( );
        }
        private void nUpDownTime_ValueChanged(object sender,EventArgs e)
        {
            ValueChange( );
        }
        private void volverToolStripMenuItem_Click(object sender,EventArgs e)
        {
            timer.Stop( );
            this.CurrentSimulator.Stop( );
            this.Close( );

            //this.CurrentSimulator = null;
        }
        
        private void rbtnNo_CheckedChanged(object sender,EventArgs e)
        {
            Simulator.NoAllowErrors = true;
        }
        private void rbtnYes_CheckedChanged(object sender,EventArgs e)
        {
            Simulator.NoAllowErrors = false;
        }
        #endregion

        #region Methods
        private void Debug( )
        {
            CurrentSimulator.Debug( );
            this.wView.Refresh( );
            this.tboxNumberRound.Text = CurrentSimulator.Rounds.ToString( );
        }
        private void ValueChange( )
        {
            CurrentSimulator.TimeSimulation = (double) nUpDownTime.Value;
            timer.Interval = (int) ( CurrentSimulator.TimeSimulation * 1000 );
        }
        private void ReloadMenu( )
        {
            if ( rutView.Routine == null )
                this.ajustarTamañoDeLaRutinaToolStripMenuItem.Enabled = false;
            else this.ajustarTamañoDeLaRutinaToolStripMenuItem.Enabled = true;
        }
        private void DoZoom( )
        {
            ZoomWorldForm zoom = new ZoomWorldForm(ref wView);

            if ( zoom.ShowDialog( ) == DialogResult.OK )
                this.wView.Refresh( );
        }
        private void Advance( )
        {
            rutView.SetRut(null);
            CurrentSimulator.Advance( );
            this.wView.Refresh( );
            if ( WasError )
            {
                this.Close( );
                WasError = false;
                return;
            }
            this.tboxNumberRound.Text = CurrentSimulator.Rounds.ToString();
        }

        private void Stop( )
        {
            this.rutView.SetRut(null);
            timer.Stop( );
            CurrentSimulator.Stop( );

            this.wEConsole.Clear( );

            this.tboxNumberRound.Clear( );
            this.tboxNumberRound.Text = CurrentSimulator.Rounds.ToString( );
            this.wView.SetWorld(CurrentSimulator.World);
            this.wView.Refresh( );
        }
        private void Play( )
        {
            rutView.SetRut(null);
            timer.Interval = (int) ( CurrentSimulator.TimeSimulation * 1000 );
            CurrentSimulator.IsRunning = true;
            play = true;

            timer.Start( );

        }
        private void DoRutZoom( )
        {
            ZoomRutForm zoom = new ZoomRutForm(ref rutView);

            if ( zoom.ShowDialog( ) == DialogResult.OK )
                this.rutView.Refresh( );
        }
        private void AdvanceUsedByPlay( )
        {
            if ( !CurrentSimulator.IsRunning && play)
            {
                timer.Stop( );
                play = false;
                return;
            }
            CurrentSimulator.Advance( );
            if ( WasError )
            {
                timer.Stop( );
                this.Close( );
                this.CurrentSimulator = null;
                WasError = false;
                return;
            }
            CurrentSimulator.IsRunning = true;
            this.wView.Refresh( );
            this.tboxNumberRound.Text = CurrentSimulator.Rounds.ToString( );
        }



        #endregion
    }
}
