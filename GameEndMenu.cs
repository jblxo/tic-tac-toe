using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class GameEndMenu : Form
    {
        private Game game;

        public GameEndMenu(string gameEndText, Game game)
        {
            InitializeComponent();

            this.game = game;
            lblGameEnd.Text = gameEndText;
        }

        private void btnResetGame_Click(object sender, EventArgs e)
        {
            game.Reset();
            game.Show();
            this.Hide();
        }

        private void btnGoToMenu_Click(object sender, EventArgs e)
        {
            game.Close();
            this.Close();
        }

        private void GameEndMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            game.Close();
        }
    }
}
