namespace tic_tac_toe
{
    partial class SettingsForm
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFieldSize = new System.Windows.Forms.Label();
            this.npdFieldSizeX = new System.Windows.Forms.NumericUpDown();
            this.npdFieldSizeY = new System.Windows.Forms.NumericUpDown();
            this.lblFieldSizeX = new System.Windows.Forms.Label();
            this.lblFieldSizeY = new System.Windows.Forms.Label();
            this.lblSymbolsSelect = new System.Windows.Forms.Label();
            this.lblPlayer1Symbol = new System.Windows.Forms.Label();
            this.lblPlayer2Symbol = new System.Windows.Forms.Label();
            this.cmbbxPlayer1Symbol = new System.Windows.Forms.ComboBox();
            this.cmbbxPlayer2Symbol = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.npdFieldSizeX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdFieldSizeY)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFieldSize
            // 
            this.lblFieldSize.AutoSize = true;
            this.lblFieldSize.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFieldSize.Location = new System.Drawing.Point(12, 9);
            this.lblFieldSize.Name = "lblFieldSize";
            this.lblFieldSize.Size = new System.Drawing.Size(78, 21);
            this.lblFieldSize.TabIndex = 0;
            this.lblFieldSize.Text = "Field Size";
            // 
            // npdFieldSizeX
            // 
            this.npdFieldSizeX.Location = new System.Drawing.Point(42, 33);
            this.npdFieldSizeX.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.npdFieldSizeX.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.npdFieldSizeX.Name = "npdFieldSizeX";
            this.npdFieldSizeX.Size = new System.Drawing.Size(132, 23);
            this.npdFieldSizeX.TabIndex = 1;
            this.npdFieldSizeX.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.npdFieldSizeX.ValueChanged += new System.EventHandler(this.npdFieldSizeX_ValueChanged);
            // 
            // npdFieldSizeY
            // 
            this.npdFieldSizeY.Location = new System.Drawing.Point(205, 33);
            this.npdFieldSizeY.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.npdFieldSizeY.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.npdFieldSizeY.Name = "npdFieldSizeY";
            this.npdFieldSizeY.Size = new System.Drawing.Size(132, 23);
            this.npdFieldSizeY.TabIndex = 1;
            this.npdFieldSizeY.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.npdFieldSizeY.ValueChanged += new System.EventHandler(this.npdFieldSizeY_ValueChanged);
            // 
            // lblFieldSizeX
            // 
            this.lblFieldSizeX.AutoSize = true;
            this.lblFieldSizeX.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFieldSizeX.Location = new System.Drawing.Point(16, 33);
            this.lblFieldSizeX.Name = "lblFieldSizeX";
            this.lblFieldSizeX.Size = new System.Drawing.Size(20, 21);
            this.lblFieldSizeX.TabIndex = 0;
            this.lblFieldSizeX.Text = "X";
            // 
            // lblFieldSizeY
            // 
            this.lblFieldSizeY.AutoSize = true;
            this.lblFieldSizeY.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFieldSizeY.Location = new System.Drawing.Point(180, 33);
            this.lblFieldSizeY.Name = "lblFieldSizeY";
            this.lblFieldSizeY.Size = new System.Drawing.Size(19, 21);
            this.lblFieldSizeY.TabIndex = 0;
            this.lblFieldSizeY.Text = "Y";
            // 
            // lblSymbolsSelect
            // 
            this.lblSymbolsSelect.AutoSize = true;
            this.lblSymbolsSelect.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSymbolsSelect.Location = new System.Drawing.Point(16, 59);
            this.lblSymbolsSelect.Name = "lblSymbolsSelect";
            this.lblSymbolsSelect.Size = new System.Drawing.Size(72, 21);
            this.lblSymbolsSelect.TabIndex = 0;
            this.lblSymbolsSelect.Text = "Symbols";
            // 
            // lblPlayer1Symbol
            // 
            this.lblPlayer1Symbol.AutoSize = true;
            this.lblPlayer1Symbol.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer1Symbol.Location = new System.Drawing.Point(12, 80);
            this.lblPlayer1Symbol.Name = "lblPlayer1Symbol";
            this.lblPlayer1Symbol.Size = new System.Drawing.Size(64, 21);
            this.lblPlayer1Symbol.TabIndex = 0;
            this.lblPlayer1Symbol.Text = "Player 1";
            // 
            // lblPlayer2Symbol
            // 
            this.lblPlayer2Symbol.AutoSize = true;
            this.lblPlayer2Symbol.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer2Symbol.Location = new System.Drawing.Point(273, 80);
            this.lblPlayer2Symbol.Name = "lblPlayer2Symbol";
            this.lblPlayer2Symbol.Size = new System.Drawing.Size(67, 21);
            this.lblPlayer2Symbol.TabIndex = 0;
            this.lblPlayer2Symbol.Text = "Player 2";
            // 
            // cmbbxPlayer1Symbol
            // 
            this.cmbbxPlayer1Symbol.FormattingEnabled = true;
            this.cmbbxPlayer1Symbol.Items.AddRange(new object[] {
            "X",
            "O",
            "Q",
            "W",
            "E",
            "R",
            "T",
            "Y"});
            this.cmbbxPlayer1Symbol.Location = new System.Drawing.Point(12, 104);
            this.cmbbxPlayer1Symbol.Name = "cmbbxPlayer1Symbol";
            this.cmbbxPlayer1Symbol.Size = new System.Drawing.Size(162, 23);
            this.cmbbxPlayer1Symbol.TabIndex = 2;
            this.cmbbxPlayer1Symbol.SelectedValueChanged += new System.EventHandler(this.cmbbxPlayer1Symbol_SelectedValueChanged);
            // 
            // cmbbxPlayer2Symbol
            // 
            this.cmbbxPlayer2Symbol.FormattingEnabled = true;
            this.cmbbxPlayer2Symbol.Items.AddRange(new object[] {
            "X",
            "O",
            "Q",
            "W",
            "E",
            "R",
            "T",
            "Y"});
            this.cmbbxPlayer2Symbol.Location = new System.Drawing.Point(180, 104);
            this.cmbbxPlayer2Symbol.Name = "cmbbxPlayer2Symbol";
            this.cmbbxPlayer2Symbol.Size = new System.Drawing.Size(162, 23);
            this.cmbbxPlayer2Symbol.TabIndex = 2;
            this.cmbbxPlayer2Symbol.SelectedValueChanged += new System.EventHandler(this.cmbbxPlayer2Symbol_SelectedValueChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 142);
            this.Controls.Add(this.cmbbxPlayer2Symbol);
            this.Controls.Add(this.cmbbxPlayer1Symbol);
            this.Controls.Add(this.lblPlayer2Symbol);
            this.Controls.Add(this.lblPlayer1Symbol);
            this.Controls.Add(this.lblSymbolsSelect);
            this.Controls.Add(this.lblFieldSizeX);
            this.Controls.Add(this.npdFieldSizeX);
            this.Controls.Add(this.lblFieldSizeY);
            this.Controls.Add(this.npdFieldSizeY);
            this.Controls.Add(this.lblFieldSize);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.npdFieldSizeX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdFieldSizeY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFieldSize;
        private System.Windows.Forms.NumericUpDown npdFieldSizeX;
        private System.Windows.Forms.NumericUpDown npdFieldSizeY;
        private System.Windows.Forms.Label lblFieldSizeX;
        private System.Windows.Forms.Label lblFieldSizeY;
        private System.Windows.Forms.Label lblSymbolsSelect;
        private System.Windows.Forms.Label lblPlayer1Symbol;
        private System.Windows.Forms.Label lblPlayer2Symbol;
        private System.Windows.Forms.ComboBox cmbbxPlayer1Symbol;
        private System.Windows.Forms.ComboBox cmbbxPlayer2Symbol;
    }
}