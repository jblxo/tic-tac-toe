namespace tic_tac_toe
{
    partial class Game
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
            this.pbGameField = new System.Windows.Forms.PictureBox();
            this.lblCurrentPlayerSymbol = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameField)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGameField
            // 
            this.pbGameField.Location = new System.Drawing.Point(34, 61);
            this.pbGameField.Name = "pbGameField";
            this.pbGameField.Size = new System.Drawing.Size(600, 600);
            this.pbGameField.TabIndex = 0;
            this.pbGameField.TabStop = false;
            this.pbGameField.Paint += new System.Windows.Forms.PaintEventHandler(this.pbGameField_Paint);
            this.pbGameField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbGameField_MouseClick);
            // 
            // lblCurrentPlayerSymbol
            // 
            this.lblCurrentPlayerSymbol.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentPlayerSymbol.Location = new System.Drawing.Point(12, 9);
            this.lblCurrentPlayerSymbol.Name = "lblCurrentPlayerSymbol";
            this.lblCurrentPlayerSymbol.Size = new System.Drawing.Size(660, 49);
            this.lblCurrentPlayerSymbol.TabIndex = 1;
            this.lblCurrentPlayerSymbol.Text = "X";
            this.lblCurrentPlayerSymbol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 711);
            this.Controls.Add(this.lblCurrentPlayerSymbol);
            this.Controls.Add(this.pbGameField);
            this.Name = "Game";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.pbGameField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGameField;
        private System.Windows.Forms.Label lblCurrentPlayerSymbol;
    }
}