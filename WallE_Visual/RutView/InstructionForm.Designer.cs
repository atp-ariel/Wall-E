namespace WallE_Visual.RutView
{
    partial class InstructionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructionForm));
            this.iListImage = new System.Windows.Forms.ImageList(this.components);
            this.lViewInstruction = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // iListImage
            // 
            this.iListImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iListImage.ImageStream")));
            this.iListImage.TransparentColor = System.Drawing.Color.Transparent;
            this.iListImage.Images.SetKeyName(0, "start.png");
            this.iListImage.Images.SetKeyName(1, "return.png");
            this.iListImage.Images.SetKeyName(2, "forward.png");
            this.iListImage.Images.SetKeyName(3, "backward.png");
            this.iListImage.Images.SetKeyName(4, "right.png");
            this.iListImage.Images.SetKeyName(5, "left.png");
            this.iListImage.Images.SetKeyName(6, "drop.png");
            this.iListImage.Images.SetKeyName(7, "code.png");
            this.iListImage.Images.SetKeyName(8, "color.png");
            this.iListImage.Images.SetKeyName(9, "direction.png");
            this.iListImage.Images.SetKeyName(10, "distance.png");
            this.iListImage.Images.SetKeyName(11, "loaded.png");
            this.iListImage.Images.SetKeyName(12, "shape.png");
            this.iListImage.Images.SetKeyName(13, "time.png");
            this.iListImage.Images.SetKeyName(14, "verticalFlux.png");
            this.iListImage.Images.SetKeyName(15, "horizontalFlux.png");
            this.iListImage.Images.SetKeyName(16, "NE.png");
            this.iListImage.Images.SetKeyName(17, "SE.png");
            this.iListImage.Images.SetKeyName(18, "NW.png");
            this.iListImage.Images.SetKeyName(19, "SW.png");
            this.iListImage.Images.SetKeyName(20, "TN.png");
            this.iListImage.Images.SetKeyName(21, "TS.png");
            this.iListImage.Images.SetKeyName(22, "TE.png");
            this.iListImage.Images.SetKeyName(23, "TW.png");
            this.iListImage.Images.SetKeyName(24, "number.png");
            this.iListImage.Images.SetKeyName(25, "zero.png");
            this.iListImage.Images.SetKeyName(26, "one.png");
            this.iListImage.Images.SetKeyName(27, "branch.png");
            this.iListImage.Images.SetKeyName(28, "routine.png");
            this.iListImage.Images.SetKeyName(29, "call.png");
            this.iListImage.Images.SetKeyName(30, "recCall.png");
            this.iListImage.Images.SetKeyName(31, "print.png");
            this.iListImage.Images.SetKeyName(32, "inc.png");
            this.iListImage.Images.SetKeyName(33, "dec.png");
            this.iListImage.Images.SetKeyName(34, "not.png");
            this.iListImage.Images.SetKeyName(35, "lnot.png");
            this.iListImage.Images.SetKeyName(36, "add.png");
            this.iListImage.Images.SetKeyName(37, "sub.png");
            this.iListImage.Images.SetKeyName(38, "mul.png");
            this.iListImage.Images.SetKeyName(39, "div.png");
            this.iListImage.Images.SetKeyName(40, "mod.png");
            this.iListImage.Images.SetKeyName(41, "eq.png");
            this.iListImage.Images.SetKeyName(42, "neq.png");
            this.iListImage.Images.SetKeyName(43, "gt.png");
            this.iListImage.Images.SetKeyName(44, "geq.png");
            this.iListImage.Images.SetKeyName(45, "lt.png");
            this.iListImage.Images.SetKeyName(46, "leq.png");
            this.iListImage.Images.SetKeyName(47, "land.png");
            this.iListImage.Images.SetKeyName(48, "and.png");
            this.iListImage.Images.SetKeyName(49, "lor.png");
            this.iListImage.Images.SetKeyName(50, "or.png");
            this.iListImage.Images.SetKeyName(51, "lxor.png");
            this.iListImage.Images.SetKeyName(52, "ternary.png");
            this.iListImage.Images.SetKeyName(53, "getAt.png");
            this.iListImage.Images.SetKeyName(54, "setAt.png");
            this.iListImage.Images.SetKeyName(55, "getA.png");
            this.iListImage.Images.SetKeyName(56, "getB.png");
            this.iListImage.Images.SetKeyName(57, "getC.png");
            this.iListImage.Images.SetKeyName(58, "getD.png");
            this.iListImage.Images.SetKeyName(59, "getE.png");
            this.iListImage.Images.SetKeyName(60, "getF.png");
            this.iListImage.Images.SetKeyName(61, "getG.png");
            this.iListImage.Images.SetKeyName(62, "getH.png");
            this.iListImage.Images.SetKeyName(63, "getI.png");
            this.iListImage.Images.SetKeyName(64, "getJ.png");
            this.iListImage.Images.SetKeyName(65, "getK.png");
            this.iListImage.Images.SetKeyName(66, "getL.png");
            this.iListImage.Images.SetKeyName(67, "getM.png");
            this.iListImage.Images.SetKeyName(68, "getN.png");
            this.iListImage.Images.SetKeyName(69, "getO.png");
            this.iListImage.Images.SetKeyName(70, "getP.png");
            this.iListImage.Images.SetKeyName(71, "getQ.png");
            this.iListImage.Images.SetKeyName(72, "getR.png");
            this.iListImage.Images.SetKeyName(73, "getS.png");
            this.iListImage.Images.SetKeyName(74, "getT.png");
            this.iListImage.Images.SetKeyName(75, "getU.png");
            this.iListImage.Images.SetKeyName(76, "getV.png");
            this.iListImage.Images.SetKeyName(77, "getW.png");
            this.iListImage.Images.SetKeyName(78, "getX.png");
            this.iListImage.Images.SetKeyName(79, "getY.png");
            this.iListImage.Images.SetKeyName(80, "getZ.png");
            this.iListImage.Images.SetKeyName(81, "setA.png");
            this.iListImage.Images.SetKeyName(82, "setB.png");
            this.iListImage.Images.SetKeyName(83, "setC.png");
            this.iListImage.Images.SetKeyName(84, "setD.png");
            this.iListImage.Images.SetKeyName(85, "setE.png");
            this.iListImage.Images.SetKeyName(86, "setF.png");
            this.iListImage.Images.SetKeyName(87, "setG.png");
            this.iListImage.Images.SetKeyName(88, "setH.png");
            this.iListImage.Images.SetKeyName(89, "setI.png");
            this.iListImage.Images.SetKeyName(90, "setJ.png");
            this.iListImage.Images.SetKeyName(91, "setK.png");
            this.iListImage.Images.SetKeyName(92, "setL.png");
            this.iListImage.Images.SetKeyName(93, "setM.png");
            this.iListImage.Images.SetKeyName(94, "setN.png");
            this.iListImage.Images.SetKeyName(95, "setO.png");
            this.iListImage.Images.SetKeyName(96, "setP.png");
            this.iListImage.Images.SetKeyName(97, "setQ.png");
            this.iListImage.Images.SetKeyName(98, "setR.png");
            this.iListImage.Images.SetKeyName(99, "setS.png");
            this.iListImage.Images.SetKeyName(100, "setT.png");
            this.iListImage.Images.SetKeyName(101, "setU.png");
            this.iListImage.Images.SetKeyName(102, "setV.png");
            this.iListImage.Images.SetKeyName(103, "setW.png");
            this.iListImage.Images.SetKeyName(104, "setX.png");
            this.iListImage.Images.SetKeyName(105, "setY.png");
            this.iListImage.Images.SetKeyName(106, "setZ.png");
            // 
            // lViewInstruction
            // 
            this.lViewInstruction.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lViewInstruction.LargeImageList = this.iListImage;
            this.lViewInstruction.Location = new System.Drawing.Point(4, 3);
            this.lViewInstruction.Name = "lViewInstruction";
            this.lViewInstruction.ShowItemToolTips = true;
            this.lViewInstruction.Size = new System.Drawing.Size(224, 618);
            this.lViewInstruction.SmallImageList = this.iListImage;
            this.lViewInstruction.TabIndex = 2;
            this.lViewInstruction.UseCompatibleStateImageBehavior = false;
            this.lViewInstruction.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lViewInstruction_ItemSelectionChanged);
            // 
            // InstructionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(232, 626);
            this.Controls.Add(this.lViewInstruction);
            this.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InstructionForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Lista de Instrucciones";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList iListImage;
        private System.Windows.Forms.ListView lViewInstruction;
    }
}