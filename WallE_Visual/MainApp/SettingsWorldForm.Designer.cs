namespace WallE_Visual
{
    partial class SettingsWorldForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWorldForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripAddWorld = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripRestartWorld = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.simularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlWorldConfig = new System.Windows.Forms.Panel();
            this.wViewConfig = new WallE_Visual.WorldViewer.WorldViewer();
            this.tbarZoom = new System.Windows.Forms.TrackBar();
            this.lblZoom = new System.Windows.Forms.Label();
            this.lblMinZoom = new System.Windows.Forms.Label();
            this.lblMaxZoom = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlWorldConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(916, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripAddWorld,
            this.menuToolStripRestartWorld,
            this.toolStripSeparator1,
            this.simularToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Image = global::WallE_Visual.Properties.Resources.config;
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.configuraciónToolStripMenuItem.Text = "Opciones";
            this.configuraciónToolStripMenuItem.ToolTipText = "Todas las opciones para configurar el mundo que desea simular.";
            // 
            // menuToolStripAddWorld
            // 
            this.menuToolStripAddWorld.Image = global::WallE_Visual.Properties.Resources.addSomething;
            this.menuToolStripAddWorld.Name = "menuToolStripAddWorld";
            this.menuToolStripAddWorld.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuToolStripAddWorld.Size = new System.Drawing.Size(243, 26);
            this.menuToolStripAddWorld.Text = "&Nuevo mundo";
            this.menuToolStripAddWorld.Click += new System.EventHandler(this.menuToolStripAddWorld_Click);
            // 
            // menuToolStripRestartWorld
            // 
            this.menuToolStripRestartWorld.Image = global::WallE_Visual.Properties.Resources.back;
            this.menuToolStripRestartWorld.Name = "menuToolStripRestartWorld";
            this.menuToolStripRestartWorld.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.menuToolStripRestartWorld.Size = new System.Drawing.Size(243, 26);
            this.menuToolStripRestartWorld.Text = "&Reiniciar mundo";
            this.menuToolStripRestartWorld.Click += new System.EventHandler(this.menuToolStripRestartWorld_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(240, 6);
            // 
            // simularToolStripMenuItem
            // 
            this.simularToolStripMenuItem.Image = global::WallE_Visual.Properties.Resources.advance;
            this.simularToolStripMenuItem.Name = "simularToolStripMenuItem";
            this.simularToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F5)));
            this.simularToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.simularToolStripMenuItem.Text = "&Simular";
            this.simularToolStripMenuItem.Click += new System.EventHandler(this.simularToolStripMenuItem_Click);
            // 
            // pnlWorldConfig
            // 
            this.pnlWorldConfig.AutoScroll = true;
            this.pnlWorldConfig.Controls.Add(this.wViewConfig);
            this.pnlWorldConfig.Location = new System.Drawing.Point(6, 33);
            this.pnlWorldConfig.Name = "pnlWorldConfig";
            this.pnlWorldConfig.Size = new System.Drawing.Size(907, 670);
            this.pnlWorldConfig.TabIndex = 1;
            // 
            // wViewConfig
            // 
            this.wViewConfig.AutoSize = true;
            this.wViewConfig.BackColor = System.Drawing.Color.Transparent;
            this.wViewConfig.IsReadOnly = false;
            this.wViewConfig.Location = new System.Drawing.Point(7, 5);
            this.wViewConfig.Name = "wViewConfig";
            this.wViewConfig.Size = new System.Drawing.Size(897, 665);
            this.wViewConfig.SizePiece = 64F;
            this.wViewConfig.TabIndex = 0;
            // 
            // tbarZoom
            // 
            this.tbarZoom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbarZoom.Cursor = System.Windows.Forms.Cursors.Cross;
            this.tbarZoom.LargeChange = 1;
            this.tbarZoom.Location = new System.Drawing.Point(286, 713);
            this.tbarZoom.Maximum = 4;
            this.tbarZoom.Minimum = 1;
            this.tbarZoom.Name = "tbarZoom";
            this.tbarZoom.Size = new System.Drawing.Size(404, 56);
            this.tbarZoom.TabIndex = 2;
            this.tbarZoom.TickFrequency = 4;
            this.tbarZoom.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbarZoom.Value = 1;
            this.tbarZoom.Scroll += new System.EventHandler(this.tbarZoom_Scroll);
            // 
            // lblZoom
            // 
            this.lblZoom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblZoom.AutoSize = true;
            this.lblZoom.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZoom.Location = new System.Drawing.Point(104, 728);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(76, 22);
            this.lblZoom.TabIndex = 3;
            this.lblZoom.Text = "Zoom: ";
            // 
            // lblMinZoom
            // 
            this.lblMinZoom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblMinZoom.AutoSize = true;
            this.lblMinZoom.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinZoom.Location = new System.Drawing.Point(219, 729);
            this.lblMinZoom.Name = "lblMinZoom";
            this.lblMinZoom.Size = new System.Drawing.Size(59, 20);
            this.lblMinZoom.TabIndex = 4;
            this.lblMinZoom.Text = " 1.0x";
            // 
            // lblMaxZoom
            // 
            this.lblMaxZoom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblMaxZoom.AutoSize = true;
            this.lblMaxZoom.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxZoom.Location = new System.Drawing.Point(711, 729);
            this.lblMaxZoom.Name = "lblMaxZoom";
            this.lblMaxZoom.Size = new System.Drawing.Size(49, 20);
            this.lblMaxZoom.TabIndex = 5;
            this.lblMaxZoom.Text = "4.0x";
            // 
            // SettingsWorldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 769);
            this.Controls.Add(this.lblMaxZoom);
            this.Controls.Add(this.lblMinZoom);
            this.Controls.Add(this.lblZoom);
            this.Controls.Add(this.tbarZoom);
            this.Controls.Add(this.pnlWorldConfig);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "SettingsWorldForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración del mundo.";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsWorldForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlWorldConfig.ResumeLayout(false);
            this.pnlWorldConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarZoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripAddWorld;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem simularToolStripMenuItem;
        private System.Windows.Forms.Panel pnlWorldConfig;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripRestartWorld;
        private WorldViewer.WorldViewer wViewConfig;
        private System.Windows.Forms.TrackBar tbarZoom;
        private System.Windows.Forms.Label lblZoom;
        private System.Windows.Forms.Label lblMinZoom;
        private System.Windows.Forms.Label lblMaxZoom;
    }
}