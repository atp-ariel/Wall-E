using WallE.Simulator;

namespace WallE_Visual
{
    partial class Wall_E_Console
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
            this.rtboxConsole = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtboxConsole
            // 
            this.rtboxConsole.AutoWordSelection = true;
            this.rtboxConsole.BackColor = System.Drawing.SystemColors.WindowText;
            this.rtboxConsole.Cursor = System.Windows.Forms.Cursors.Cross;
            this.rtboxConsole.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtboxConsole.ForeColor = System.Drawing.SystemColors.Window;
            this.rtboxConsole.Location = new System.Drawing.Point(0, 0);
            this.rtboxConsole.Name = "rtboxConsole";
            this.rtboxConsole.ReadOnly = true;
            this.rtboxConsole.Size = new System.Drawing.Size(679, 250);
            this.rtboxConsole.TabIndex = 0;
            this.rtboxConsole.Text = "";
            // 
            // Wall_E_Console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.rtboxConsole);
            this.Name = "Wall_E_Console";
            this.Size = new System.Drawing.Size(682, 253);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtboxConsole;

      
    }
}
