namespace WallE_Visual.MainApp
{
    partial class ZoomRutForm
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
            this.lblMaxZoom.Location = new System.Drawing.Point(412, 38);
            this.lblMaxZoom.Name = "lblMaxZoom";
            this.lblMaxZoom.Size = new System.Drawing.Size(44, 17);
            this.lblMaxZoom.TabIndex = 13;
            this.lblMaxZoom.Text = "4.0x";
            // 
            // lblMinZoom
            // 
            this.lblMinZoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMinZoom.AutoSize = true;
            this.lblMinZoom.Font = new System.Drawing.Font("Courier New", 9F);
            this.lblMinZoom.Location = new System.Drawing.Point(124, 40);
            this.lblMinZoom.Name = "lblMinZoom";
            this.lblMinZoom.Size = new System.Drawing.Size(53, 17);
            this.lblMinZoom.TabIndex = 12;
            this.lblMinZoom.Text = " 1.0x";
            // 
            // lblZoom
            // 
            this.lblZoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblZoom.AutoSize = true;
            this.lblZoom.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZoom.Location = new System.Drawing.Point(56, 39);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(62, 17);
            this.lblZoom.TabIndex = 11;
            this.lblZoom.Text = "Zoom: ";
            // 
            // tbarZoom
            // 
            this.tbarZoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbarZoom.Cursor = System.Windows.Forms.Cursors.Cross;
            this.tbarZoom.LargeChange = 1;
            this.tbarZoom.Location = new System.Drawing.Point(183, 18);
            this.tbarZoom.Maximum = 4;
            this.tbarZoom.Minimum = 1;
            this.tbarZoom.Name = "tbarZoom";
            this.tbarZoom.Size = new System.Drawing.Size(212, 56);
            this.tbarZoom.TabIndex = 10;
            this.tbarZoom.TickFrequency = 4;
            this.tbarZoom.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbarZoom.Value = 1;
            this.tbarZoom.Scroll += new System.EventHandler(this.tbarZoom_Scroll);
            // 
            // ZoomRutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 93);
            this.Controls.Add(this.lblMaxZoom);
            this.Controls.Add(this.lblMinZoom);
            this.Controls.Add(this.lblZoom);
            this.Controls.Add(this.tbarZoom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ZoomRutForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Ajustar tamaño de la rutina";
            ((System.ComponentModel.ISupportInitialize)(this.tbarZoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaxZoom;
        private System.Windows.Forms.Label lblMinZoom;
        private System.Windows.Forms.Label lblZoom;
        private System.Windows.Forms.TrackBar tbarZoom;
    }
}