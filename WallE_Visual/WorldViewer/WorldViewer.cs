using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WallE.World;
using WallE.World.WorldObjects;
using WallE.Tools;
using System.Windows.Forms;

namespace WallE_Visual.WorldViewer
{
    public partial class WorldViewer : UserControl
    {
        #region Fields
        float widthPiece = 64, heightPiece = 64;
        float fontSize = 9;
        #endregion

        #region Properties
        public float SizePiece
        {
            get
            {
                return widthPiece;
            }
            set
            {
                if ( value >= 64 )
                    widthPiece = heightPiece = value;
                else
                    MessageBox.Show("No puede tener un tamaño menor a 64 px.","Tamaño invalido.",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        Dictionary<string,Image> imgList = new Dictionary<string,Image>( );
        public Map World { get; private set; }
        private int Rows => World.Rows;
        private int Columns => World.Columns;

        private Point lastPosition;
        public bool IsReadOnly { get; set; }
        #endregion

        #region Constructor
        public WorldViewer( )
        {
            InitializeComponent( );
            this.pboxWorld.ContextMenuStrip = null;
            LoadImages( );
        }
        public WorldViewer(Map world) : this( )
        {
            this.World = world;
            if ( !IsReadOnly )
                this.pboxWorld.ContextMenuStrip = conMenuOptions;
        }
        #endregion

        #region Events
        private void pboxWorld_Paint(object sender,PaintEventArgs e)
        {
            PaintWorld(e.Graphics);
        }
        private void pboxWorld_MouseDown(object sender,MouseEventArgs e)
        {
            if ( World == null )
                return;
            lastPosition = e.Location;
        }
        private void verCaracteristicasToolStripMenuItem_MouseHover(object sender,EventArgs e)
        {
            ViewProperties( );
        }
        private void eliminarObjetoToolStripMenuItem_Click(object sender,EventArgs e)
        {
            DeleteObject( );
        }
        private void añadirObjetoToolStripMenuItem_Click(object sender,EventArgs e)
        {
            AddObject( );
        }
        private void editarObjetoToolStripMenuItem_Click(object sender,EventArgs e)
        {
            EditWallObject( );
        }
        private void conMenuOptions_Opening(object sender,CancelEventArgs e)
        {
            ReloadContextMenuStrip( );
        }
        private void añadirColumnaToolStripMenuItem_Click(object sender,EventArgs e)
        {
            AddColumn( );
        }
        private void insertarFilaToolStripMenuItem_Click(object sender,EventArgs e)
        {
            AddRow( );
        }
        private void eliminarColumnaToolStripMenuItem_Click(object sender,EventArgs e)
        {
            RemoveColumns( );
        }
        private void eliminarFilaToolStripMenuItem_Click(object sender,EventArgs e)
        {
            RemoveRows( );
        }
        #endregion

        #region Methods
        private void RemoveRows( )
        {
            Position tempPosition = PointToPosition(lastPosition);

            try {
                World.RemoveRowAt(tempPosition.X); }
            catch(Exception e)
            {
                MessageBox.Show(e.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            this.pboxWorld.Refresh( );
        }
        private void RemoveColumns( )
        {
            Position tempPosition = PointToPosition(lastPosition);

            try
            {
                World.RemoveColumnAt(tempPosition.Y);
            }
            catch ( Exception e )
            {
                MessageBox.Show(e.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            this.pboxWorld.Refresh( );
        }
        private void AddColumn( )
        {
            Position tempPosition = PointToPosition(lastPosition);

            World.AddColumnAt(tempPosition.Y);
            this.pboxWorld.Refresh( );
        }
        private void AddRow( )
        {
            Position tempPosition = PointToPosition(lastPosition);

            World.AddRowAt(tempPosition.X);
            this.pboxWorld.Refresh( );

        }
        public void SetWorld(Map world)
        {
            this.World = world;
            if(!IsReadOnly)
            this.pboxWorld.ContextMenuStrip = conMenuOptions;
            this.pboxWorld.Refresh( );
        }
        public void SetWorld(int row,int column)
        {
            SetWorld(new Map(row,column));
        }
        private void PaintWorld(Graphics graph)
        {
            if ( World == null )
                return;
            else
            {
                this.pboxWorld.BackgroundImage = null;
                this.pboxWorld.Size = new Size(Columns * (int) ( widthPiece ),Rows * (int) ( heightPiece ));

                Pen pen = new Pen(Color.DarkGray,1);

                //Pinto lineas
                for ( int i = 0; i < Columns; i++ )
                    graph.DrawLine(pen,i * (int) widthPiece - 1,0,i * (int) widthPiece - 1,this.pboxWorld.Height);

                for ( int i = 0; i < Rows; i++ )
                    graph.DrawLine(pen,0,i * (int) heightPiece - 1,this.pboxWorld.Width,i * (int) heightPiece - 1);

                
                //Pinto imagenes
                LoadImages( );
                foreach ( var wObjects in World )
                {
                    Image tempImg = (Image) imgList[wObjects.MainCharacteristics].Clone( );
                    if ( wObjects is IProgrammable )
                    {
                        var direction = (Direction) ( (IProgrammable) wObjects ).Directions;
                        if ( direction == Direction.East )
                            tempImg.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        else if ( direction == Direction.South )
                            tempImg.RotateFlip(RotateFlipType.RotateNoneFlipY);
                        else if ( direction == Direction.West )
                            tempImg.RotateFlip(RotateFlipType.Rotate90FlipXY);
                    }

                    graph.DrawImage(tempImg,
                        wObjects.ObjPosition.Y * pboxWorld.Height / Rows,
                        wObjects.ObjPosition.X * pboxWorld.Width / Columns,
                        ( this.pboxWorld.Height / Rows ) - 1,
                    ( this.pboxWorld.Width / Columns ) - 1);
                }

                //Pinto los números
                for ( int i = 0; i < Columns; i++ )
                    graph.DrawString(i.ToString( ),new Font(new FontFamily(GenericFontFamilies.Monospace),fontSize,FontStyle.Regular),Brushes.DarkGray,( i * pboxWorld.Width ) / Columns ,1);

                for ( int i = 1; i < Rows; i++ )
                    graph.DrawString(i.ToString( ),new Font(new FontFamily(GenericFontFamilies.Monospace),fontSize,FontStyle.Regular),Brushes.DarkGray,1,( i * pboxWorld.Height ) / Rows );
            }
        }
        private void LoadImages( )
        {
            if ( World == null )
                return;
            string pathImage = Application.StartupPath + @"\recursos\img\WallEObjects";

            foreach ( var wObjects in World.Where(c => c is WallEObjects) )
                try
                {
                    if ( !imgList.ContainsKey(wObjects.MainCharacteristics) )
                    {
                        var img = Image.FromFile(pathImage + "\\" + wObjects.MainCharacteristics + ".jpg");
                        imgList.Add(wObjects.MainCharacteristics,img);
                    }
                }
                catch ( Exception )
                {
                    MessageBox.Show("No existe imagen del objeto: " + wObjects.ToString( ),"Error de imagen",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
        }
        private Position PointToPosition(Point lastPosition)
        {
            return new Position(lastPosition.Y * Rows / this.pboxWorld.Height,lastPosition.X * Columns / this.pboxWorld.Width);
        }
        private void AddObject( )
        {
            Position tempPosition = PointToPosition(lastPosition);

            AddObjectForm addObject = new AddObjectForm( );

            if ( addObject.ShowDialog( ) == DialogResult.OK )
            {

                if ( Directory.Exists(Application.StartupPath + "\\recursos\\img\\WallEObjects\\" + addObject.WObject.MainCharacteristics + ".jpg") )
                {
                    MessageBox.Show("No existe imagen del objeto: " + addObject.WObject.MainCharacteristics,"Error de imagen",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                if ( Map.IsValidPosition(World,tempPosition) )
                {
                    addObject.WObject.ObjPosition = tempPosition;
                    World.AddNewObjectAt(addObject.WObject);
                }
                this.pboxWorld.Refresh( );
                this.ReloadContextMenuStrip( );
            }
        }
        private void DeleteObject( )
        {
            Position tempPosition = PointToPosition(lastPosition);

            WallE.World.WorldObjects.WallEObjects tempObject;
            if ( Map.IsValidPosition(World,tempPosition) )
                World.RemoveAt(tempPosition,out tempObject);
            this.pboxWorld.Refresh( );
            this.ReloadContextMenuStrip( );
        }
        private void ViewProperties( )
        {
            Position position = PointToPosition(lastPosition);

            if ( Map.IsValidPosition(World,position) )
            {
                if ( World[position] == null )
                    this.tboxProperties.Text = "Empty";
                else if ( World[position] is ILoader )
                    this.tboxProperties.Text = World[position] + "\\nInside: " + ( (ILoader) World[position] ).ObjectInside;
                else
                    this.tboxProperties.Text = World[position].ToString( );
            }
        }
        private void EditWallObject( )
        {
            Position tempPosition = PointToPosition(lastPosition);
            var temp = World[tempPosition];
            if ( temp == null )
                return;
            EditObject edit = new EditObject(ref temp);
            edit.ShowDialog( );
            this.pboxWorld.Refresh( );
            this.ReloadContextMenuStrip( );
        }
        private void ReloadContextMenuStrip( )
        {
            Position position = PointToPosition(lastPosition);

            if ( Map.IsValidPosition(World,position) && World[position] == null )
            {
                this.añadirObjetoToolStripMenuItem.Enabled = true;
                this.editarObjetoToolStripMenuItem.Enabled = false;
                this.eliminarObjetoToolStripMenuItem.Enabled = false;
            }
            else
            {
                this.añadirObjetoToolStripMenuItem.Enabled = false;
                this.editarObjetoToolStripMenuItem.Enabled = true;
                this.eliminarObjetoToolStripMenuItem.Enabled = true;
            }
        }


        public void ModifySize(int upNumber,int downNumber)
        {
            this.widthPiece = 64 * upNumber / downNumber;
            this.heightPiece = 64 * upNumber / downNumber;
            this.fontSize = 9 * upNumber / downNumber;
            this.pboxWorld.Refresh( );
        }
        #endregion
    }
}
