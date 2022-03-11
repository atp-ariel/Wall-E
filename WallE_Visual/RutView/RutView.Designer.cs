namespace WallE_Visual
{
    partial class RutViews
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.components = new System.ComponentModel.Container();
            this.conMenuOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.añadirInstrucciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarInstrucciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.insertarColumnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarFilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTipDescription = new System.Windows.Forms.ToolTip(this.components);
            this.pboxRut = new System.Windows.Forms.PictureBox();
            this.conMenuOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxRut)).BeginInit();
            this.SuspendLayout();
            // 
            // conMenuOptions
            // 
            this.conMenuOptions.BackColor = System.Drawing.SystemColors.Info;
            this.conMenuOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.conMenuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirInstrucciToolStripMenuItem,
            this.eliminarInstrucciónToolStripMenuItem,
            this.toolStripSeparator1,
            this.insertarColumnaToolStripMenuItem,
            this.insertarFilaToolStripMenuItem});
            this.conMenuOptions.Name = "conMenuOptions";
            this.conMenuOptions.Size = new System.Drawing.Size(212, 114);
            this.conMenuOptions.Opening += new System.ComponentModel.CancelEventHandler(this.conMenuOptions_Opening);
            // 
            // añadirInstrucciToolStripMenuItem
            // 
            this.añadirInstrucciToolStripMenuItem.Image = global::WallE_Visual.Properties.Resources.addSomething;
            this.añadirInstrucciToolStripMenuItem.Name = "añadirInstrucciToolStripMenuItem";
            this.añadirInstrucciToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.añadirInstrucciToolStripMenuItem.Text = "Añadir Instrucción";
            this.añadirInstrucciToolStripMenuItem.Click += new System.EventHandler(this.añadirInstrucciToolStripMenuItem_Click);
            // 
            // eliminarInstrucciónToolStripMenuItem
            // 
            this.eliminarInstrucciónToolStripMenuItem.Image = global::WallE_Visual.Properties.Resources.delete;
            this.eliminarInstrucciónToolStripMenuItem.Name = "eliminarInstrucciónToolStripMenuItem";
            this.eliminarInstrucciónToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.eliminarInstrucciónToolStripMenuItem.Text = "Eliminar Instrucción";
            this.eliminarInstrucciónToolStripMenuItem.Click += new System.EventHandler(this.eliminarInstrucciónToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(208, 6);
            // 
            // insertarColumnaToolStripMenuItem
            // 
            this.insertarColumnaToolStripMenuItem.Image = global::WallE_Visual.Properties.Resources.newColumn;
            this.insertarColumnaToolStripMenuItem.Name = "insertarColumnaToolStripMenuItem";
            this.insertarColumnaToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.insertarColumnaToolStripMenuItem.Text = "Insertar Columna";
            this.insertarColumnaToolStripMenuItem.Click += new System.EventHandler(this.insertarColumnaToolStripMenuItem_Click);
            // 
            // insertarFilaToolStripMenuItem
            // 
            this.insertarFilaToolStripMenuItem.Image = global::WallE_Visual.Properties.Resources.newRow;
            this.insertarFilaToolStripMenuItem.Name = "insertarFilaToolStripMenuItem";
            this.insertarFilaToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.insertarFilaToolStripMenuItem.Text = "Insertar Fila";
            this.insertarFilaToolStripMenuItem.Click += new System.EventHandler(this.insertarFilaToolStripMenuItem_Click);
            // 
            // toolTipDescription
            // 
            this.toolTipDescription.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipDescription.ToolTipTitle = "Descripción";
            // 
            // pboxRut
            // 
            this.pboxRut.BackColor = System.Drawing.SystemColors.Control;
            this.pboxRut.BackgroundImage = global::WallE_Visual.Properties.Resources.NoRut;
            this.pboxRut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxRut.ContextMenuStrip = this.conMenuOptions;
            this.pboxRut.Location = new System.Drawing.Point(0, 0);
            this.pboxRut.Name = "pboxRut";
            this.pboxRut.Size = new System.Drawing.Size(676, 485);
            this.pboxRut.TabIndex = 0;
            this.pboxRut.TabStop = false;
            this.pboxRut.Paint += new System.Windows.Forms.PaintEventHandler(this.pboxRut_Paint);
            this.pboxRut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pboxRut_MouseDown);
            // 
            // RutViews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pboxRut);
            this.Name = "RutViews";
            this.Size = new System.Drawing.Size(679, 488);
            this.conMenuOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxRut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxRut;
        private System.Windows.Forms.ContextMenuStrip conMenuOptions;
        private System.Windows.Forms.ToolStripMenuItem añadirInstrucciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarInstrucciónToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTipDescription;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem insertarColumnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertarFilaToolStripMenuItem;
    }
}
