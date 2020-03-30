using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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

            bool cellTaken = symbols.Any(s => s.X == x && s.Y == y);

            if(cellTaken)
            {
                MessageBox.Show("This cell is already taken!");
                return;
            }

            symbols.Add(new Symbol(symbol, x, y, playerTurn, (int) cellsX, (int) cellsY));
            pbGameField.Refresh();
            EndTurn();
        }

        private void EndTurn()
        {
            CheckWinner();
            playerTurn = playerTurn == 1 ? 2 : 1;
            lblCurrentPlayerSymbol.Text = playerTurn == 1 ? Settings.Instance.Player1Symbol : Settings.Instance.Player2Symbol;
        }

        private void CheckWinner()
        {
            var playerSymbols = symbols.Where(s => s.Player == playerTurn);
            int x, y;
            foreach(Symbol s in playerSymbols)
            {
                x = s.X;
                y = s.Y;

                var symbolsRow = playerSymbols.Where(s => s.Y == y && s.X > x && s.X < x + 5).ToList();
                var symbolsColumn = playerSymbols.Where(s => s.X == x && s.Y > y && s.Y < y + 5).ToList();
                List<Symbol> symbolsDiagonalL = new List<Symbol>();
                List<Symbol> symbolsDiagonalR = new List<Symbol>();

                for (int i = 1; i < 5; i++)
                {
                    for(int j = 1; j < 5; j++)
                    {
                        var sym = playerSymbols.SingleOrDefault(s => s.X - i == x && s.Y - j == y);
                        if(sym != null)
                        {
                            symbolsDiagonalL.Add(sym);
                        }
                    }
                }

                for(int i = 1; i < 5; i++)
                {
                    for(int j = 1; j < 5; j++)
                    {
                        var sym = playerSymbols.SingleOrDefault(s => s.X - i == x && s.Y + j == y);
                        if (sym != null)
                        {
                            symbolsDiagonalR.Add(sym);
                        }
                    }
                }

                if (symbolsRow.Count == 4 || symbolsColumn.Count == 4 || symbolsDiagonalL.Count == 4 || symbolsDiagonalR.Count == 4)
                {
                    MessageBox.Show("KEKW");
                }
            }
        }
    }

    public enum GameMode
    {
        PC = 0,
        Human = 1
    }
}
