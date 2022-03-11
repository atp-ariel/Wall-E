using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WallE.World.WorldObjects;
using WallE.Tools;

namespace WallE_Visual.WorldViewer
{
    public partial class AddObjectForm : Form
    {
        #region Properties
        public WallEObjects WObject { get; private set; }
        #endregion
        
        #region Constructor
        public AddObjectForm( )
        {
            InitializeComponent( );

            LoadForm( );
        }
        #endregion

        #region Events
        private void cBoxShape_SelectedValueChanged(object sender,EventArgs e)
        {
            RefreshCombos( );
        }
        private void btnCreate_Click(object sender,EventArgs e)
        {
            CreateObject((string) this.cboxShape.SelectedItem,(string) this.cboxSize.SelectedItem,(string) this.cboxColor.SelectedItem);

            this.DialogResult = DialogResult.OK;
            this.Hide( );
        }
        private void AddObjectForm_KeyUp(object sender,KeyEventArgs e)
        {
            EnterPress(sender,e);
        }
        #endregion

        #region Methods
        private void LoadForm( )
        {
            this.cboxShape.Items.Clear( );

            List<string> tempList = new List<string>( );
            foreach ( var item in Shapes.GetValues( ).Skip(1) )
                tempList.Add(item.Value);
            this.cboxShape.Items.AddRange(tempList.ToArray( ));

            this.cboxShape.SelectedItem = "Plant";

            RefreshCombos( );
        }
        private void RefreshCombos( )
        {
            if ( (string) this.cboxShape.SelectedItem == null )
                return;
            var tempObject = WallEObjects.ExecuteCreation((string) this.cboxShape.SelectedItem);
            if ( tempObject is IProgrammable )
            {
                this.lblDirection.Show( );
                this.cboxDirection.Show( );

                this.cboxDirection.Items.Clear( );

                List<string> temp = new List<string>( );
                foreach ( var item in Direction.GetValues( ) )
                    temp.Add(item.Value);

                this.cboxDirection.Items.AddRange(temp.ToArray( ));

                this.cboxDirection.SelectedItem = "East";


                temp.Clear( );
                this.cboxSize.Items.Clear( );
                temp.Add(Sizes.GetByID(tempObject.ObjSize).Value);
                this.cboxSize.Items.AddRange(temp.ToArray( ));

                this.cboxSize.SelectedItem = temp[0];
            }
            else
            {
                this.lblDirection.Hide( );
                this.cboxDirection.Hide( );


                List<string> tempList = new List<string>( );
                this.cboxSize.Items.Clear( );

                foreach ( var item in Sizes.GetValues( ).Skip(1) )
                    tempList.Add(item.Value);
                this.cboxSize.Items.AddRange(tempList.ToArray( ));

                this.cboxSize.SelectedItem = "Medium";

                tempList.Clear( );

                this.cboxColor.Items.Clear( );

                foreach ( var item in Colors.GetValues( ).Skip(1) )
                    tempList.Add(item.Value);
                this.cboxColor.Items.AddRange(tempList.ToArray( ));

                this.cboxColor.SelectedItem = "Green";
            }
        }
        public void CreateObject(string shape,string size,string color)
        {
            try
            {
                WObject = WallEObjects.ExecuteCreation(shape);
                foreach ( var item in Colors.GetValues( ) )
                    if ( item.Value == color )
                    {
                        WObject.ObjColor = item.ID;
                        break;
                    }

                foreach ( var item in Sizes.GetValues( ) )
                    if ( item.Value == size )
                    {
                        WObject.ObjSize = item.ID;
                        break;
                    }
                if ( WObject is IProgrammable )
                {
                    foreach ( var item in Direction.GetValues( ) )
                    {
                        if ( item.Value == (string) this.cboxDirection.SelectedItem )
                        {
                            ( (IProgrammable) WObject ).Directions = item.ID;
                            break;
                        }
                    }
                }
            }
            catch ( Exception )
            {
                throw;
            }
        }
        private void EnterPress(object sender,KeyEventArgs e)
        {
            if ( e.KeyData == Keys.Enter )
                btnCreate_Click(sender,e);
        }
        #endregion
    }
}
