using WallE_Visual.WorldViewer;

namespace WallE_Visual.MainApp
{
    partial class ZoomWorldForm
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
            this.lblMaxZoom = new System.Windows.Forms.Label();
            this.lblMinZoom = new System.Windows.Forms.Label();
            this.lblZoom = new System.Windows.Forms.Label();
            this.tbarZoom = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tbarZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaxZoom
            // 
            this.lblMaxZoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMaxZoom.AutoSize = true;
            this.lblMaxZoom.Font = new System.Drawing.Font("Courier New", 9F);
            this.lblMaxZoom.Location = new System.Drawing.Point(396, 32);
            this.lblMaxZoom.Name = "lblMaxZoom";
            this.lblMaxZoom.Size = new System.Drawing.Size(44, 17);
            this.lblMaxZoom.TabIndex = 9;
            this.lblMaxZoom.Text = "4.0x";
            // 
            // lblMinZoom
            // 
            this.lblMinZoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMinZoom.AutoSize = true;
            this.lblMinZoom.Font = new System.Drawing.Font("Courier New", 9F);
            this.lblMinZoom.Location = new System.Drawing.Point(108, 34);
            this.lblMinZoom.Name = "lblMinZoom";
            this.lblMinZoom.Size = new System.Drawing.Size(53, 17);
            this.lblMinZoom.TabIndex = 8;
            this.lblMinZoom.Text = " 1.0x";
            // 
            // lblZoom
            // 
            this.lblZoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblZoom.AutoSize = true;
            this.lblZoom.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZoom.Location = new System.Drawing.Point(40, 33);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(62, 17);
            this.lblZoom.TabIndex = 7;
            this.lblZoom.Text = "Zoom: ";
            // 
            // tbarZoom
            // 
            this.tbarZoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbarZoom.Cursor = System.Windows.Forms.Cursors.Cross;
            this.tbarZoom.LargeChange = 1;
            this.tbarZoom.Location = new System.Drawing.Point(167, 12);
            this.tbarZoom.Maximum = 4;
            this.tbarZoom.Minimum = 1;
            this.tbarZoom.Name = "tbarZoom";
            this.tbarZoom.Size = new System.Drawing.Size(212, 56);
            this.tbarZoom.TabIndex = 6;
            this.tbarZoom.TickFrequency = 4;
            this.tbarZoom.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbarZoom.Value = 1;
            this.tbarZoom.Scroll += new System.EventHandler(this.tbarZoom_Scroll);
            // 
            // ZoomWorldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 93);
            this.Controls.Add(this.lblMaxZoom);
            this.Controls.Add(this.lblMinZoom);
            this.Controls.Add(this.lblZoom);
            this.Controls.Add(this.tbarZoom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ZoomWorldForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Ajustar tamaño del mundo";
            ((System.ComponentModel.ISupportInitialize)(this.tbarZoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaxZoom;
        private System.Windows.Forms.Label lblMinZoom;
        private System.Windows.Forms.Label lblZoom;
        private System.Windows.Forms.TrackBar tbarZoom;
        private WorldViewer.WorldViewer wView;

        public ZoomWorldForm(WorldViewer.WorldViewer wView)
        {
            this.wView = wView;
        }
    }
}