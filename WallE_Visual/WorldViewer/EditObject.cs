using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Tools;
using WallE.World.WorldObjects;
using System.Windows.Forms;

namespace WallE_Visual.WorldViewer
{
    public partial class EditObject : Form
    {
        #region Properties
        private WallEObjects wallE;

        public WallEObjects WallE => wallE;
        #endregion

        #region Constructor
        public EditObject( )
        {
            InitializeComponent( );
        }
        public EditObject(ref WallEObjects objects) : this()
        {
            this.wallE = objects;
            
            RefreshCombos( );
        }
        #endregion

        #region Events
        private void btnEdited_Click(object sender,EventArgs e)
        {
            Save( );
            this.DialogResult = DialogResult.OK;
            this.Hide( );
        }
        private void btnEditRut_Click(object sender,EventArgs e)
        {
            EditRoutine( );
        }

        #endregion

        #region Methods
        private void RefreshCombos( )
        {
            this.lblWallEObjects.Text = wallE.ToString( );
            this.lblWallEObjects.Visible = true;
            this.btnEditRut.Visible = false;

            this.lblDirections.Hide( );
            this.cboxDirection.Hide( );
            List<string> tempList = new List<string>( );

            if ( WallE is IProgrammable )
            {
                this.btnEditRut.Visible = true;
                this.btnEditRut.Show( );
                this.lblDirections.Show( );
                this.cboxDirection.Show( );

                this.cboxDirection.Items.Clear( );

                foreach ( var item in Direction.GetValues( ) )
                    tempList.Add(item.Value);

                this.cboxDirection.Items.AddRange(tempList.ToArray( ));

                this.cboxDirection.SelectedItem = ((Direction) ( (IProgrammable) WallE ).Directions).Value;
                tempList.Clear( );
                this.cboxSize.Items.Clear( );
                tempList.Add(Sizes.GetByID(WallE.ObjSize).Value);
                this.cboxSize.Items.AddRange(tempList.ToArray( ));

                this.cboxSize.SelectedItem = Sizes.GetValues( ).Where(c => c.ID == WallE.ObjSize).Take(1).ToArray( )[0].Value;
            }
            else
            {
                tempList.Clear( );
                this.cboxSize.Items.Clear( );

                foreach ( var item in Sizes.GetValues( ).Skip(1) )
                    tempList.Add(item.Value);
                this.cboxSize.Items.AddRange(tempList.ToArray( ));

                this.cboxSize.SelectedItem = Sizes.GetValues( ).Where(c => c.ID == WallE.ObjSize).Take(1).ToArray( )[0].Value;
            }
            tempList.Clear( );

            this.cboxColor.Items.Clear( );

            foreach ( var item in Colors.GetValues( ).Skip(1) )
                tempList.Add(item.Value);
            this.cboxColor.Items.AddRange(tempList.ToArray( ));

            this.cboxColor.SelectedItem = Colors.GetValues( ).Where(c => c.ID == WallE.ObjColor).Take(1).ToArray( )[0].Value;
        }
        private void Save( )
        {
            this.WallE.ObjColor = Colors.GetValues( ).Where(c => c.Value == (string) this.cboxColor.SelectedItem).ToArray( )[0].ID;
            this.WallE.ObjSize = Sizes.GetValues( ).Where(c => c.Value == (string) this.cboxSize.SelectedItem).ToArray( )[0].ID;

            if ( WallE is IProgrammable )
                ( (IProgrammable) this.WallE ).Directions = Direction.GetValues( ).Where(c => c.Value == (string) this.cboxDirection.SelectedItem).ToArray( )[0].ID;
        }
        private void EditRoutine()
        {
            IProgrammable temp = wallE as IProgrammable;
            ViewRoutineForm viewer = new ViewRoutineForm( temp);

            viewer.ShowDialog( );
        }
        #endregion

       
    }
}
