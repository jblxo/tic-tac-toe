using System;
using System.Drawing;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Game : Form
    {
        private GameMode mode;

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
            float cellsX = pbGameField.Width / width;
            float cellsY = pbGameField.Height / height;

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
        }
    }

    public enum GameMode
    {
        PC = 0,
        Human = 1
    }
}
