namespace tic_tac_toe
{
    partial class GameEndMenu
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
            this.lblGameEnd = new System.Windows.Forms.Label();
            this.btnResetGame = new System.Windows.Forms.Button();
            this.btnGoToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGameEnd
            // 
            this.lblGameEnd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGameEnd.Location = new System.Drawing.Point(12, 9);
            this.lblGameEnd.Name = "lblGameEnd";
            this.lblGameEnd.Size = new System.Drawing.Size(246, 40);
            this.lblGameEnd.TabIndex = 0;
            this.lblGameEnd.Text = "game end text";
            this.lblGameEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnResetGame
            // 
            this.btnResetGame.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResetGame.Location = new System.Drawing.Point(12, 52);
            this.btnResetGame.Name = "btnResetGame";
            this.btnResetGame.Size = new System.Drawing.Size(122, 70);
            this.btnResetGame.TabIndex = 1;
            this.btnResetGame.Text = "Restart game";
            this.btnResetGame.UseVisualStyleBackColor = true;
            this.btnResetGame.Click += new System.EventHandler(this.btnResetGame_Click);
            // 
            // btnGoToMenu
            // 
            this.btnGoToMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGoToMenu.Location = new System.Drawing.Point(136, 52);
            this.btnGoToMenu.Name = "btnGoToMenu";
            this.btnGoToMenu.Size = new System.Drawing.Size(122, 70);
            this.btnGoToMenu.TabIndex = 1;
            this.btnGoToMenu.Text = "Go to menu";
            this.btnGoToMenu.UseVisualStyleBackColor = true;
            this.btnGoToMenu.Click += new System.EventHandler(this.btnGoToMenu_Click);
            // 
            // GameEndMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 134);
            this.Controls.Add(this.btnGoToMenu);
            this.Controls.Add(this.btnResetGame);
            this.Controls.Add(this.lblGameEnd);
            this.Name = "GameEndMenu";
            this.Text = "GameEndMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameEndMenu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGameEnd;
        private System.Windows.Forms.Button btnResetGame;
        private System.Windows.Forms.Button btnGoToMenu;
    }
}