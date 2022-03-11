namespace WallE_Visual.MainApp
{
    partial class SimulatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimulatorForm));
            this.pnlWorld = new System.Windows.Forms.Panel();
            this.gbosControls = new System.Windows.Forms.GroupBox();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.nUpDownTime = new System.Windows.Forms.NumericUpDown();
            this.lblTime = new System.Windows.Forms.Label();
            this.tboxNumberRound = new System.Windows.Forms.TextBox();
            this.lblNumberRound = new System.Windows.Forms.Label();
            this.rbtnNo = new System.Windows.Forms.RadioButton();
            this.rbtnYes = new System.Windows.Forms.RadioButton();
            this.lblErrors = new System.Windows.Forms.Label();
            this.btnDebug = new System.Windows.Forms.Button();
            this.btnAdvance = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.pnlRut = new System.Windows.Forms.Panel();
            this.mStripOptions = new System.Windows.Forms.MenuStrip();
            this.volverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustarTamañoDelMundoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustarTamañoDeLaRutinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolTipGuide = new System.Windows.Forms.ToolTip(this.components);
            this.wEConsole = new WallE_Visual.Wall_E_Console();
            this.rutView = new WallE_Visual.RutViews();
            this.wView = new WallE_Visual.WorldViewer.WorldViewer();
            this.pnlWorld.SuspendLayout();
            this.gbosControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownTime)).BeginInit();
            this.pnlRut.SuspendLayout();
            this.mStripOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWorld
            // 
            this.pnlWorld.AutoScroll = true;
            this.pnlWorld.Controls.Add(this.wView);
            this.pnlWorld.Location = new System.Drawing.Point(10, 36);
            this.pnlWorld.Name = "pnlWorld";
            this.pnlWorld.Size = new System.Drawing.Size(900, 670);
            this.pnlWorld.TabIndex = 0;
            // 
            // gbosControls
            // 
            this.gbosControls.BackColor = System.Drawing.SystemColors.Control;
            this.gbosControls.Controls.Add(this.lblSeconds);
            this.gbosControls.Controls.Add(this.nUpDownTime);
            this.gbosControls.Controls.Add(this.lblTime);
            this.gbosControls.Controls.Add(this.tboxNumberRound);
            this.gbosControls.Controls.Add(this.lblNumberRound);
            this.gbosControls.Controls.Add(this.rbtnNo);
            this.gbosControls.Controls.Add(this.rbtnYes);
            this.gbosControls.Controls.Add(this.lblErrors);
            this.gbosControls.Controls.Add(this.btnDebug);
            this.gbosControls.Controls.Add(this.btnAdvance);
            this.gbosControls.Controls.Add(this.btnPause);
            this.gbosControls.Controls.Add(this.btnPlay);
            this.gbosControls.Controls.Add(this.btnStop);
            this.gbosControls.Location = new System.Drawing.Point(10, 717);
            this.gbosControls.Name = "gbosControls";
            this.gbosControls.Size = new System.Drawing.Size(895, 74);
            this.gbosControls.TabIndex = 1;
            this.gbosControls.TabStop = false;
            this.gbosControls.Text = "Controles";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(527, 42);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(74, 17);
            this.lblSeconds.TabIndex = 12;
            this.lblSeconds.Text = "segundos.";
            // 
            // nUpDownTime
            // 
            this.nUpDownTime.DecimalPlaces = 1;
            this.nUpDownTime.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.nUpDownTime.Location = new System.Drawing.Point(466, 41);
            this.nUpDownTime.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUpDownTime.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.nUpDownTime.Name = "nUpDownTime";
            this.nUpDownTime.ReadOnly = true;
            this.nUpDownTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nUpDownTime.Size = new System.Drawing.Size(55, 22);
            this.nUpDownTime.TabIndex = 11;
            this.nUpDownTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipGuide.SetToolTip(this.nUpDownTime, "Tiempo entre ronda y ronda");
            this.nUpDownTime.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.nUpDownTime.ValueChanged += new System.EventHandler(this.nUpDownTime_ValueChanged);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(455, 15);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(149, 17);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "Tiempo de simulación:";
            // 
            // tboxNumberRound
            // 
            this.tboxNumberRound.BackColor = System.Drawing.SystemColors.Control;
            this.tboxNumberRound.Cursor = System.Windows.Forms.Cursors.No;
            this.tboxNumberRound.Enabled = false;
            this.tboxNumberRound.Location = new System.Drawing.Point(790, 41);
            this.tboxNumberRound.Name = "tboxNumberRound";
            this.tboxNumberRound.ReadOnly = true;
            this.tboxNumberRound.Size = new System.Drawing.Size(51, 22);
            this.tboxNumberRound.TabIndex = 9;
            // 
            // lblNumberRound
            // 
            this.lblNumberRound.AutoSize = true;
            this.lblNumberRound.Location = new System.Drawing.Point(787, 15);
            this.lblNumberRound.Name = "lblNumberRound";
            this.lblNumberRound.Size = new System.Drawing.Size(54, 17);
            this.lblNumberRound.TabIndex = 8;
            this.lblNumberRound.Text = "Ronda:";
            this.toolTipGuide.SetToolTip(this.lblNumberRound, "Ronda actual");
            // 
            // rbtnNo
            // 
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.Checked = true;
            this.rbtnNo.Location = new System.Drawing.Point(695, 42);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(47, 21);
            this.rbtnNo.TabIndex = 7;
            this.rbtnNo.TabStop = true;
            this.rbtnNo.Text = "No";
            this.toolTipGuide.SetToolTip(this.rbtnNo, "Se cerrará la simulación si tiene errores.");
            this.rbtnNo.UseVisualStyleBackColor = true;
            this.rbtnNo.CheckedChanged += new System.EventHandler(this.rbtnNo_CheckedChanged);
            // 
            // rbtnYes
            // 
            this.rbtnYes.AutoSize = true;
            this.rbtnYes.Location = new System.Drawing.Point(625, 42);
            this.rbtnYes.Name = "rbtnYes";
            this.rbtnYes.Size = new System.Drawing.Size(41, 21);
            this.rbtnYes.TabIndex = 6;
            this.rbtnYes.Text = "Sí";
            this.toolTipGuide.SetToolTip(this.rbtnYes, "No se cerrará la simulación si tiene errores");
            this.rbtnYes.UseVisualStyleBackColor = true;
            this.rbtnYes.CheckedChanged += new System.EventHandler(this.rbtnYes_CheckedChanged);
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.Location = new System.Drawing.Point(632, 15);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(110, 17);
            this.lblErrors.TabIndex = 5;
            this.lblErrors.Text = "Permitir errores:";
            // 
            // btnDebug
            // 
            this.btnDebug.BackColor = System.Drawing.Color.Transparent;
            this.btnDebug.BackgroundImage = global::WallE_Visual.Properties.Resources.debug;
            this.btnDebug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDebug.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnDebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebug.Location = new System.Drawing.Point(20, 15);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(59, 53);
            this.btnDebug.TabIndex = 4;
            this.toolTipGuide.SetToolTip(this.btnDebug, "Instrucción por instrucción");
            this.btnDebug.UseVisualStyleBackColor = false;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // btnAdvance
            // 
            this.btnAdvance.BackColor = System.Drawing.Color.Transparent;
            this.btnAdvance.BackgroundImage = global::WallE_Visual.Properties.Resources.advance1;
            this.btnAdvance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdvance.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAdvance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvance.Location = new System.Drawing.Point(376, 15);
            this.btnAdvance.Name = "btnAdvance";
            this.btnAdvance.Size = new System.Drawing.Size(59, 53);
            this.btnAdvance.TabIndex = 3;
            this.toolTipGuide.SetToolTip(this.btnAdvance, "Avanzar hacia la próxima ronda.");
            this.btnAdvance.UseVisualStyleBackColor = false;
            this.btnAdvance.Click += new System.EventHandler(this.btnAdvance_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.BackgroundImage = global::WallE_Visual.Properties.Resources.pause;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPause.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Location = new System.Drawing.Point(287, 15);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(59, 53);
            this.btnPause.TabIndex = 2;
            this.toolTipGuide.SetToolTip(this.btnPause, "Pausar la simulación en la próxima ronda.");
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = global::WallE_Visual.Properties.Resources.play;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(199, 15);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(59, 53);
            this.btnPlay.TabIndex = 1;
            this.toolTipGuide.SetToolTip(this.btnPlay, "Play a la simulación");
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.BackgroundImage = global::WallE_Visual.Properties.Resources.stop;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Location = new System.Drawing.Point(109, 15);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(59, 53);
            this.btnStop.TabIndex = 0;
            this.toolTipGuide.SetToolTip(this.btnStop, "Volver la simulación al estado inicial.");
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pnlRut
            // 
            this.pnlRut.AutoScroll = true;
            this.pnlRut.Controls.Add(this.rutView);
            this.pnlRut.Location = new System.Drawing.Point(916, 306);
            this.pnlRut.Name = "pnlRut";
            this.pnlRut.Size = new System.Drawing.Size(683, 490);
            this.pnlRut.TabIndex = 2;
            // 
            // mStripOptions
            // 
            this.mStripOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mStripOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverToolStripMenuItem,
            this.opcionesToolStripMenuItem});
            this.mStripOptions.Location = new System.Drawing.Point(0, 0);
            this.mStripOptions.Name = "mStripOptions";
            this.mStripOptions.Size = new System.Drawing.Size(1609, 28);
            this.mStripOptions.TabIndex = 4;
            this.mStripOptions.Text = "Volver";
            // 
            // volverToolStripMenuItem
            // 
            this.volverToolStripMenuItem.Image = global::WallE_Visual.Properties.Resources.volver;
            this.volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            this.volverToolStripMenuItem.Size = new System.Drawing.Size(32, 24);
            this.volverToolStripMenuItem.ToolTipText = "Volver a configurar la simulación";
            this.volverToolStripMenuItem.Click += new System.EventHandler(this.volverToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajustarTamañoDelMundoToolStripMenuItem,
            this.ajustarTamañoDeLaRutinaToolStripMenuItem});
            this.opcionesToolStripMenuItem.Image = global::WallE_Visual.Properties.Resources.config;
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(32, 24);
            this.opcionesToolStripMenuItem.ToolTipText = "Ajustes de tamaño.";
            // 
            // ajustarTamañoDelMundoToolStripMenuItem
            // 
            this.ajustarTamañoDelMundoToolStripMenuItem.Image = global::WallE_Visual.Properties.Resources.trackbar;
            this.ajustarTamañoDelMundoToolStripMenuItem.Name = "ajustarTamañoDelMundoToolStripMenuItem";
            this.ajustarTamañoDelMundoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
            this.ajustarTamañoDelMundoToolStripMenuItem.Size = new System.Drawing.Size(313, 26);
            this.ajustarTamañoDelMundoToolStripMenuItem.Text = "&Ajustar tamaño del mundo";
            this.ajustarTamañoDelMundoToolStripMenuItem.Click += new System.EventHandler(this.ajustarTamañoDelMundoToolStripMenuItem_Click);
            // 
            // ajustarTamañoDeLaRutinaToolStripMenuItem
            // 
            this.ajustarTamañoDeLaRutinaToolStripMenuItem.Image = global::WallE_Visual.Properties.Resources.trackbar;
            this.ajustarTamañoDeLaRutinaToolStripMenuItem.Name = "ajustarTamañoDeLaRutinaToolStripMenuItem";
            this.ajustarTamañoDeLaRutinaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.ajustarTamañoDeLaRutinaToolStripMenuItem.Size = new System.Drawing.Size(313, 26);
            this.ajustarTamañoDeLaRutinaToolStripMenuItem.Text = "&Ajustar tamaño de la rutina";
            this.ajustarTamañoDeLaRutinaToolStripMenuItem.Click += new System.EventHandler(this.ajustarTamañoDeLaRutinaToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.btnAdvance_Click);
            // 
            // toolTipGuide
            // 
            this.toolTipGuide.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipGuide.ToolTipTitle = "Guía de uso";
            // 
            // wEConsole
            // 
            this.wEConsole.AutoSize = true;
            this.wEConsole.BackColor = System.Drawing.Color.Transparent;
            this.wEConsole.Location = new System.Drawing.Point(917, 36);
            this.wEConsole.Name = "wEConsole";
            this.wEConsole.Size = new System.Drawing.Size(682, 253);
            this.wEConsole.TabIndex = 5;
            // 
            // rutView
            // 
            this.rutView.AutoSize = true;
            this.rutView.BackColor = System.Drawing.Color.Transparent;
            this.rutView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rutView.IsReadOnly = true;
            this.rutView.Location = new System.Drawing.Point(0, -3);
            this.rutView.Name = "rutView";
            this.rutView.Size = new System.Drawing.Size(681, 490);
            this.rutView.TabIndex = 0;
            // 
            // wView
            // 
            this.wView.AutoSize = true;
            this.wView.BackColor = System.Drawing.Color.Transparent;
            this.wView.IsReadOnly = false;
            this.wView.Location = new System.Drawing.Point(0, 0);
            this.wView.Name = "wView";
            this.wView.Size = new System.Drawing.Size(897, 665);
            this.wView.SizePiece = 64F;
            this.wView.TabIndex = 0;
            // 
            // SimulatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1609, 808);
            this.Controls.Add(this.wEConsole);
            this.Controls.Add(this.pnlRut);
            this.Controls.Add(this.gbosControls);
            this.Controls.Add(this.pnlWorld);
            this.Controls.Add(this.mStripOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mStripOptions;
            this.MaximizeBox = false;
            this.Name = "SimulatorForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Simulador";
            this.pnlWorld.ResumeLayout(false);
            this.pnlWorld.PerformLayout();
            this.gbosControls.ResumeLayout(false);
            this.gbosControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownTime)).EndInit();
            this.pnlRut.ResumeLayout(false);
            this.pnlRut.PerformLayout();
            this.mStripOptions.ResumeLayout(false);
            this.mStripOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlWorld;
        private WorldViewer.WorldViewer wView;
        private System.Windows.Forms.GroupBox gbosControls;
        private System.Windows.Forms.Panel pnlRut;
        private RutViews rutView;
        private System.Windows.Forms.Button btnDebug;
        private System.Windows.Forms.Button btnAdvance;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.RadioButton rbtnNo;
        private System.Windows.Forms.RadioButton rbtnYes;
        private System.Windows.Forms.Label lblErrors;
        private System.Windows.Forms.MenuStrip mStripOptions;
        private System.Windows.Forms.ToolStripMenuItem volverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajustarTamañoDelMundoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajustarTamañoDeLaRutinaToolStripMenuItem;
        private System.Windows.Forms.TextBox tboxNumberRound;
        private System.Windows.Forms.Label lblNumberRound;
        private System.Windows.Forms.NumericUpDown nUpDownTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblSeconds;
        private Wall_E_Console wEConsole;
        private System.Windows.Forms.ToolTip toolTipGuide;
    }
}