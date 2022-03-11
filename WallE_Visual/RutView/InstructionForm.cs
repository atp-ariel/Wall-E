using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WallE.Tools;
using WallE.MATLAN;
using System.Windows.Forms;

namespace WallE_Visual.RutView
{
    public partial class InstructionForm : Form
    {
        public Instruction SelectedInstruction { get; private set; }
        public InstructionForm( )
        {
            InitializeComponent( );
            LoadImage( );
        }

        private void LoadImage( )
        {
            this.iListImage.Images.Clear( );
            this.lViewInstruction.Items.Clear( );


            string path = Application.StartupPath + "\\recursos\\img\\Instructions\\";
            foreach ( var img in InstructionEnum.GetValues())
            {
                iListImage.Images.Add(Image.FromFile(path + img.Value + ".png"));
                lViewInstruction.Items.Add(img.Value,iListImage.Images.Count - 1);
            }
        }

        private void lViewInstruction_ItemSelectionChanged(object sender,ListViewItemSelectionChangedEventArgs e)
        {
            SelectedInstruction = Instruction.ExecuteCreation(e.Item.Text);

            this.DialogResult = DialogResult.OK;
            this.Close( );
        }
    }
}
