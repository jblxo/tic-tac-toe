using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Game : Form
    {
        private GameMode mode;
        private int playerTurn = 1;
        private List<Symbol> symbols = new List<Symbol>();
        float cellsX;
        float cellsY;

        public Game(GameMode mode)
        {
            InitializeComponent();

            this.mode = mode;
            pbGameField.Refresh();
        }

        private void DrawField(Graphics g)
        {
            float width = Settings.Instance.FieldSize.Width;
            float height = Settings.Instance.FieldSize.Height;
            cellsX = pbGameField.Width / width;
            cellsY = pbGameField.Height / height;

            for(int i = 0; i < width; i++)
            {
                g.DrawLine(Pens.Black, i * cellsX, 0, i * cellsX, pbGameField.Height);
            }
            g.DrawLine(Pens.Black, pbGameField.Width - 1, 0, pbGameField.Width - 1, pbGameField.Height - 1);

            for (int i = 0; i < height; i++)
            {
                g.DrawLine(Pens.Black, 0, i * cellsY, pbGameField.Width, i * cellsY);
            }
            g.DrawLine(Pens.Black, 0, pbGameField.Height - 1, pbGameField.Width - 1, pbGameField.Height - 1);
        }

        private void pbGameField_Paint(object sender, PaintEventArgs e)
        {
            DrawField(e.Graphics);
            DrawSymbols(e.Graphics);
        }

        private void DrawSymbols(Graphics g)
        {
            foreach(Symbol s in symbols)
            {
                s.Draw(g);
            }
        }

        private void pbGameField_MouseClick(object sender, MouseEventArgs e)
        {
            int x = (int) Math.Floor(e.X / cellsX);
            int y = (int) Math.Floor(e.Y / cellsY);

            string symbol = playerTurn == 1 ? Settings.Instance.Player1Symbol : Settings.Instance.Player2Symbol;

            symbols.Add(new Symbol(symbol, x, y, playerTurn, cellsX, cellsY));
            playerTurn = playerTurn == 1 ? 2 : 1;
            pbGameField.Refresh();
        }
    }

    public enum GameMode
    {
        PC = 0,
        Human = 1
    }
}
