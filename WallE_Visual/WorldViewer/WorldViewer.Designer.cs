namespace WallE_Visual.WorldViewer
{
    partial class WorldViewer
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
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolTipPosition = new System.Windows.Forms.ToolTip(this.components);
            this.eliminarFilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pboxWorld = new System.Windows.Forms.PictureBox();
            this.añadirObjetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarObjetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarObjetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPropiedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tboxProperties = new System.Windows.Forms.ToolStripTextBox();
            this.añadirColumnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarFilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarColumnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conMenuOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxWorld)).BeginInit();
            this.SuspendLayout();
            // 
            // conMenuOptions
            // 
            this.conMenuOptions.BackColor = System.Drawing.SystemColors.Info;
            this.conMenuOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.conMenuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirObjetoToolStripMenuItem,
            this.editarObjetoToolStripMenuItem,
            this.eliminarObjetoToolStripMenuItem,
            this.toolStripSeparator2,
            this.verPropiedadesToolStripMenuItem,
            this.toolStripSeparator1,
            this.añadirColumnaToolStripMenuItem,
            this.insertarFilaToolStripMenuItem,
            this.eliminarColumnaToolStripMenuItem,
            this.eliminarFilaToolStripMenuItem});
            this.conMenuOptions.Name = "contextMenuStrip1";
            this.conMenuOptions.Size = new System.Drawing.Size(200, 252);
            this.conMenuOptions.Opening += new System.ComponentModel.CancelEventHandler(this.conMenuOptions_Opening);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(196, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(196, 6);
            // 
            // toolTipPosition
            // 
            this.toolTipPosition.IsBalloon = true;
            this.toolTipPosition.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipPosition.ToolTipTitle = "Poisicion";
            // 
            // eliminarFilaToolStripMenuItem
            // 
            this.eliminarFilaToolStripMenuItem.Image = global::WallE_Visual.Properties.Resources.removeRow;
            this.eliminarFilaToolStripMenuItem.Name = "eliminarFilaToolStripMenuItem";
            this.eliminarFilaToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.eliminarFilaToolStripMenuItem.Text = "Eliminar Fila";
            this.eliminarFilaToolStripMenuItem.Click += new System.EventHandler(this.eliminarFilaToolStripMenuItem_Click);
            // 
            // pboxWorld
            // 
            this.pboxWorld.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pboxWorld.BackgroundImage = global::WallE_Visual.Properties.Resources.NoWorld;
            this.pboxWorld.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxWorld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxWorld.ContextMenuStrip = this.conMenuOptions;
            this.pboxWorld.InitialImage = null;
            this.pboxWorld.Location = new System.Drawing.Point(0, 0);
            this.pboxWorld.Name = "pboxWorld";
            this.pboxWorld.Size = new System.Drawing.Size(894, 662);
            this.pboxWorld.TabIndex = 0;
            this.pboxWorld.TabStop = false;
            this.pboxWorld.Paint += new System.Windows.Forms.PaintEventHandler(this.pboxWorld_Paint);
            this.pboxWorld.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pboxWorld_MouseDown);
            // 
            // añadirObjetoToolStripMenuItem
            // 
            this.añadirObjetoToolStripMenuItem.Image = global::WallE_Visual.Properties.Resources.addSomething;
            this.añadirObjetoToolStripMenuItem.Name = "añadirObjetoToolStripMenuItem";
            this.añadirObjetoToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.añadirObjetoToolStripMenuItem.Text = "Añadir Objeto";
            this.añadirObjetoToolStripMenuItem.Click += new System.EventHandler(this.añadirObjetoToolStripMenuItem_Click);
            // 
            // editarObjetoToolStripMenuItem
            // 
            this.editarObjetoToolStripMenuItem.Image = global::WallE_Visual.Properties.Resources.edit;
            this.editarObjetoToolStripMenuItem.Name = "editarObjetoToolStripMenuItem";
            this.editarObjetoToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.editarObjetoToolStripMenuItem.Text = "Editar Objeto";
            this.editarObjetoToolStripMenuItem.Click += new System.EventHandler(this.editarObjetoToolStripMenuItem_Click);
            // 
            // eliminarObjetoToolStripMenuItem
            // 
            this.eliminarObjetoToolStripMenuItem.Image = global::WallE_Visual.Properties.Resources.delete;
            this.eliminarObjetoToolStripMenuItem.Name = "eliminarObjetoToolStripMenuItem";
            this.eliminarObjetoToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.eliminarObjetoToolStripMenuItem.Text = "Eliminar Objeto";
            this.eliminarObjetoToolStripMenuItem.Click += new System.EventHandler(this.eliminarObjetoToolStripMenuItem_Click);
            // 
            // verPropiedadesToolStripMenuItem
            // 
            this.verPropiedadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tboxProperties});
            this.verPropiedadesToolStripMenuItem.Image = global::WallE_Visual.Properties.Resources.look;
            this.verPropiedadesToolStripMenuItem.Name = "verPropiedadesToolStripMenuItem";
            this.verPropiedadesToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.verPropiedadesToolStripMenuItem.Text = "Ver propiedades";
            this.verPropiedadesToolStripMenuItem.MouseHover += new System.EventHandler(this.verCaracteristicasToolStripMenuItem_MouseHover);
            // 
            // tboxProperties
            // 
            this.tboxProperties.BackColor = System.Drawing.SystemColors.Info;
            this.tboxProperties.Enabled = false;
            this.tboxProperties.Name = "tboxProperties";
            this.tboxProperties.ReadOnly = true;
            this.tboxProperties.Size = new System.Drawing.Size(100, 27);
            this.tboxProperties.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // añadirColumnaToolStripMenuItem
            // 
            this.añadirColumnaToolStripMenuItem.Image = global::WallE_Visual.Properties.Resources.newColumn;
            this.añadirColumnaToolStripMenuItem.Name = "añadirColumnaToolStripMenuItem";
            this.añadirColumnaToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.añadirColumnaToolStripMenuItem.Text = "Insertar Columna";
            this.añadirColumnaToolStripMenuItem.Click += new System.EventHandler(this.añadirColumnaToolStripMenuItem_Click);
            // 
            // insertarFilaToolStripMenuItem
            // 
            this.insertarFilaToolStripMenuItem.Image = global::WallE_Visual.Properties.Resources.newRow;
            this.insertarFilaToolStripMenuItem.Name = "insertarFilaToolStripMenuItem";
            this.insertarFilaToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.insertarFilaToolStripMenuItem.Text = "Insertar Fila";
            this.insertarFilaToolStripMenuItem.Click += new System.EventHandler(this.insertarFilaToolStripMenuItem_Click);
            // 
            // eliminarColumnaToolStripMenuItem
            // 
            this.eliminarColumnaToolStripMenuItem.Image = global::WallE_Visual.Properties.Resources.removeColumn;
            this.eliminarColumnaToolStripMenuItem.Name = "eliminarColumnaToolStripMenuItem";
            this.eliminarColumnaToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.eliminarColumnaToolStripMenuItem.Text = "Eliminar Columna";
            this.eliminarColumnaToolStripMenuItem.Click += new System.EventHandler(this.eliminarColumnaToolStripMenuItem_Click);
            // 
            // WorldViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pboxWorld);
            this.Name = "WorldViewer";
            this.Size = new System.Drawing.Size(897, 665);
            this.conMenuOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxWorld)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxWorld;
        private System.Windows.Forms.ContextMenuStrip conMenuOptions;
        private System.Windows.Forms.ToolStripMenuItem añadirObjetoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarObjetoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarObjetoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem verPropiedadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox tboxProperties;
        private System.Windows.Forms.ToolTip toolTipPosition;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem añadirColumnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertarFilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarColumnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarFilaToolStripMenuItem;
    }
}
