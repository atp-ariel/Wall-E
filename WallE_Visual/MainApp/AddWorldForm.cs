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
    public partial class AddWorldForm : Form
    {
        #region Properties
        public int Row { get; private set; }
        public int Column { get; private set; }
        #endregion

        #region Constructor
        public AddWorldForm( )
        {
            InitializeComponent( );
            this.Row = 10;
            this.Column = 20;
        }
        #endregion

        #region Events
        private void nUpRows_ValueChanged(object sender,EventArgs e)
        {
            ValueChange_Row(this.nUpRows);
        }
        private void nUpColumns_ValueChanged(object sender,EventArgs e)
        {
            ValueChange_Columns(this.nUpColumns);
        }
        private void btnAccept_Click(object sender,EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide( );
        }

        #endregion

        #region Methods
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
        #endregion

        
    }
}
