using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WallE_Visual.WorldViewer
{
    public partial class AddRutForm : Form
    {
        #region Properties
        public int Row { get; private set; }
        public int Column { get; private set; }
        public string Name { get; private set; }
        #endregion

        public AddRutForm( )
        {
            InitializeComponent( );
            Row = 1;
            Column = 1;
            Name = string.Empty;
        }

        #region Events
        private void nUpRows_ValueChanged(object sender,EventArgs e)
        {
            ValueChange_Row(this.nUpDownRow);
        }
        private void nUpColumns_ValueChanged(object sender,EventArgs e)
        {
            ValueChange_Columns(this.nUpDownColumn);
        }
        private void tboxName_TextChanged(object sender,EventArgs e)
        {
            Name = tboxName.Text;
        }
        private void btnAccept_Click(object sender,EventArgs e)
        {
            Accepted( );
        }
        private void AddRutForm_KeyUp(object sender,KeyEventArgs e)
        {
            EnterPress( sender, e);
        }
        #endregion

        #region Methods
        private void Accepted( )
        {
            if ( Name == string.Empty )
            {
                MessageBox.Show("Nombre la rutina.","Rutina sin nombre.",MessageBoxButtons.OK,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Hide( );
        }
        private void ValueChange_Row(NumericUpDown numericUpDown)
        {
            if ( (int) numericUpDown.Value < 1 || (int) numericUpDown.Value > 500 )
                return;
            this.Row = (int) numericUpDown.Value;
        }
        private void ValueChange_Columns(NumericUpDown numericUpDown)
        {
            if ( (int) numericUpDown.Value < 1 || (int) numericUpDown.Value > 500 )
                return;
            this.Column = (int) numericUpDown.Value;
        }
        private void EnterPress(object sender, KeyEventArgs e )
        {
            if ( e.KeyData == Keys.Enter )
                btnAccept_Click(sender,e);
        }
        #endregion

      
    }
}
