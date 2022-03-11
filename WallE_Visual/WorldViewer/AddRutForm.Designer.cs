namespace WallE_Visual.WorldViewer
{
    partial class AddRutForm
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
            this.lblRow = new System.Windows.Forms.Label();
            this.lblColumn = new System.Windows.Forms.Label();
            this.nUpDownRow = new System.Windows.Forms.NumericUpDown();
            this.nUpDownColumn = new System.Windows.Forms.NumericUpDown();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.tboxName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownColumn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRow.Location = new System.Drawing.Point(53, 66);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(62, 17);
            this.lblRow.TabIndex = 0;
            this.lblRow.Text = "Filas:";
            // 
            // lblColumn
            // 
            this.lblColumn.AutoSize = true;
            this.lblColumn.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumn.Location = new System.Drawing.Point(26, 98);
            this.lblColumn.Name = "lblColumn";
            this.lblColumn.Size = new System.Drawing.Size(89, 17);
            this.lblColumn.TabIndex = 1;
            this.lblColumn.Text = "Columnas:";
            // 
            // nUpDownRow
            // 
            this.nUpDownRow.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nUpDownRow.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpDownRow.ForeColor = System.Drawing.SystemColors.Window;
            this.nUpDownRow.Location = new System.Drawing.Point(144, 59);
            this.nUpDownRow.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nUpDownRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDownRow.Name = "nUpDownRow";
            this.nUpDownRow.Size = new System.Drawing.Size(99, 24);
            this.nUpDownRow.TabIndex = 2;
            this.nUpDownRow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUpDownRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDownRow.ValueChanged += new System.EventHandler(this.nUpRows_ValueChanged);
            // 
            // nUpDownColumn
            // 
            this.nUpDownColumn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nUpDownColumn.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpDownColumn.ForeColor = System.Drawing.SystemColors.Window;
            this.nUpDownColumn.Location = new System.Drawing.Point(144, 96);
            this.nUpDownColumn.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nUpDownColumn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDownColumn.Name = "nUpDownColumn";
            this.nUpDownColumn.Size = new System.Drawing.Size(99, 24);
            this.nUpDownColumn.TabIndex = 3;
            this.nUpDownColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUpDownColumn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDownColumn.ValueChanged += new System.EventHandler(this.nUpColumns_ValueChanged);
            // 
            // btnAccept
            // 
            this.btnAccept.BackgroundImage = global::WallE_Visual.Properties.Resources.addWhite;
            this.btnAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccept.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(206, 135);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(37, 31);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(44, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 17);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Nombre:";
            // 
            // tboxName
            // 
            this.tboxName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tboxName.ForeColor = System.Drawing.SystemColors.Window;
            this.tboxName.Location = new System.Drawing.Point(143, 13);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(100, 27);
            this.tboxName.TabIndex = 0;
            this.tboxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tboxName.TextChanged += new System.EventHandler(this.tboxName_TextChanged);
            // 
            // AddRutForm
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(255, 178);
            this.Controls.Add(this.tboxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.nUpDownColumn);
            this.Controls.Add(this.nUpDownRow);
            this.Controls.Add(this.lblColumn);
            this.Controls.Add(this.lblRow);
            this.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddRutForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nueva rutina";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AddRutForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownColumn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.Label lblColumn;
        private System.Windows.Forms.NumericUpDown nUpDownRow;
        private System.Windows.Forms.NumericUpDown nUpDownColumn;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tboxName;
    }
}