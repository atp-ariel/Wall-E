using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE_Visual.RutView;
using System.Windows.Forms;
using WallE.MATLAN;
using WallE.Routine;
using WallE.Tools;

namespace WallE_Visual
{
    public partial class RutViews : UserControl
    {
        #region Fields
        public Rut Routine
        {
            get; private set;
        }

        float widthPiece = 64;
        float heightPiece = 64;
        float fontSize = 9;
        Dictionary<string,Image> imgList = new Dictionary<string,Image>( );

        public bool IsReadOnly { get; set; }
        private int Rows => Routine.Body.Row;
        private int Columns => Routine.Body.Column;

        private Point lastPosition;
        #endregion

        #region Constructor
        public RutViews( )
        {
            InitializeComponent( );
            this.pboxRut.ContextMenuStrip = null;
        }
        public RutViews(Rut rut) : this()
        {
            this.Routine = rut;
            IsReadOnly = false;
            this.pboxRut.ContextMenuStrip = conMenuOptions;
            LoadImages( );
        }
        #endregion

        #region Events
        private void pboxRut_Paint(object sender,PaintEventArgs e)
        {
            PaintRoutine(e.Graphics );
        }
        private void pboxRut_MouseDown(object sender,MouseEventArgs e)
        {
            if(!IsReadOnly)
            lastPosition = e.Location;
        }
        private void añadirInstrucciToolStripMenuItem_Click(object sender,EventArgs e)
        {
            AddInstruction( );
        }
        private void eliminarInstrucciónToolStripMenuItem_Click(object sender,EventArgs e)
        {
            DeleteInstruction( );
        }
        private void insertarColumnaToolStripMenuItem_Click(object sender,EventArgs e)
        {
            AddColumn( );
        }
        private void insertarFilaToolStripMenuItem_Click(object sender,EventArgs e)
        {
            AddRow( );
        }
        private void conMenuOptions_Opening(object sender,CancelEventArgs e)
        {
            ReloadContextMenuStrip( );
        }
        #endregion

        #region Methods
        internal void PaintIn(Position marks)
        {
            if ( IsReadOnly )
            {
                var pen = new Pen(Brushes.Black,4);
                pboxRut.CreateGraphics( ).DrawRectangle(pen,marks.Y * pboxRut.Height / Rows,
                            marks.X * pboxRut.Width / Columns,
                            ( this.pboxRut.Height / Rows ) - 1,
                        ( this.pboxRut.Width / Columns ) - 1);
                PaintRoutine(pboxRut.CreateGraphics( ));
            }
        }
        private void AddRow( )
        {
            Position tempPosition = PointToPosition(lastPosition);

            Routine.Body.AddRowAt(tempPosition.X);
            this.pboxRut.Refresh( );
        }
        private void AddColumn( )
        {
            Position tempPosition = PointToPosition(lastPosition);

            Routine.Body.AddColumnAt(tempPosition.Y);
            this.pboxRut.Refresh( );
        }
        private void PaintRoutine(Graphics graph)
        {
            if ( Routine == null )
                return;
            else
            {
                this.pboxRut.BackgroundImage = null;
                this.pboxRut.Size = new Size(Columns * (int) ( widthPiece ),Rows * (int) ( heightPiece ));

                Pen pen = new Pen(Color.Black,1);

                //Pinto lineas
                for ( int i = 0; i <= Columns; i++ )
                    graph.DrawLine(pen,i * (int) widthPiece - 1,0,i * (int) widthPiece - 1,this.pboxRut.Height);

                for ( int i = 0; i <= Rows; i++ )
                    graph.DrawLine(pen,0,i * (int) heightPiece - 1,this.pboxRut.Width,i * (int) heightPiece - 1);

                //Pinto imagenes
                LoadImages( );
                var a = Routine.GetAllInstructionAndPositions( ).Where(c => c.Item1 is Instruction);
                foreach ( var instruction in a )
                {
                    Image tempImg = (Image) imgList[instruction.Item1.ToString( )].Clone( );

                    graph.DrawImage(tempImg,
                        instruction.Item2.Y * pboxRut.Height / Rows,
                        instruction.Item2.X * pboxRut.Width / Columns,
                        ( this.pboxRut.Height / Rows ) - 1,
                    ( this.pboxRut.Width / Columns ) - 1);
                }

                //Pinto números
                for ( int i = 0; i < Columns; i++ )
                    graph.DrawString(i.ToString( ),new Font(new FontFamily(GenericFontFamilies.Monospace),fontSize,FontStyle.Regular),Brushes.DarkGray,( i * pboxRut.Width ) / Columns,1);

                for ( int i = 1; i < Rows; i++ )
                    graph.DrawString(i.ToString( ),new Font(new FontFamily(GenericFontFamilies.Monospace),fontSize,FontStyle.Regular),Brushes.DarkGray,1,( i * pboxRut.Height ) / Rows);
            }
        }
        private void LoadImages( )
        {
            if ( Routine == null )
                return;
            string pathImage = Application.StartupPath + @"\recursos\img\Instructions";

            foreach ( var instruction in Routine.GetAllInstruction() )
                try
                {
                    if ( !imgList.ContainsKey(instruction.ToString()) )
                    {
                        var img = Image.FromFile(pathImage + "\\" + instruction.ToString() + ".png");
                        imgList.Add(instruction.ToString(),img);
                    }
                }
                catch ( Exception )
                {
                    MessageBox.Show("No existe imagen de la instrucción: " + instruction.ToString( ),"Error de imagen",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
        }
        private Position PointToPosition(Point lastPosition)
        {
            return new Position(lastPosition.Y * Rows / this.pboxRut.Height,lastPosition.X * Columns / this.pboxRut.Width);
        }
        public void SetRut( Rut rut)
        {
            this.Routine = rut;
            if(!IsReadOnly)
                this.pboxRut.ContextMenuStrip = conMenuOptions;
            pboxRut.Refresh( );
        }
        public void SetRut(int row, int column)
        {
            var rut = new Rut( );

            rut.Body.AddRowAt(row - 1);
            rut.Body.AddColumnAt(column - 1);

            SetRut( rut);
        }
        private void RemoveInstruction( )
        {
            Position tempPosition = PointToPosition(lastPosition);

            this.Routine.Body.RemoveInstructionAt(tempPosition);
            this.pboxRut.Refresh( );
        } 
        public void AddInstruction( )
        {
            Position tempPosition = PointToPosition(lastPosition);

            InstructionForm instForm = new InstructionForm( );

            if ( instForm.ShowDialog( ) == DialogResult.OK )
            {
                try {
                    this.Routine.Body.AddInstructionAt(instForm.SelectedInstruction,tempPosition); }
                catch(Exception e )
                {
                    MessageBox.Show(e.Message, "Error de rutina.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                this.pboxRut.Refresh( );
            }
        }
        public void DeleteInstruction( )
        {
            Position tempPosition = PointToPosition(lastPosition);

            if ( Routine.Body[tempPosition] == null )
                return;
            else
                Routine.Body.RemoveInstructionAt(tempPosition);
            this.pboxRut.Refresh( );
        }
        private void ReloadContextMenuStrip( )
        {
            if ( !IsReadOnly )
            {
                Position tempPosition = PointToPosition(lastPosition);

                if ( Routine.Body[tempPosition] == null )
                {
                    this.añadirInstrucciToolStripMenuItem.Enabled = true;
                    this.eliminarInstrucciónToolStripMenuItem.Enabled = false;
                }
                else
                {
                    this.añadirInstrucciToolStripMenuItem.Enabled = false;
                    this.eliminarInstrucciónToolStripMenuItem.Enabled = true;
                }
            }
        }
        public void ModifySize(int upNumber,int downNumber)
        {
            this.widthPiece = 64 * upNumber / downNumber;
            this.heightPiece = 64 * upNumber / downNumber;

            this.fontSize = 9 * upNumber / downNumber;

            this.pboxRut.Refresh( );
        }
        #endregion


    }
}

