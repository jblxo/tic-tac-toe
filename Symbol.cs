using System.Drawing;

namespace tic_tac_toe
{
    class Symbol
    {
        private string character;
        private Point position;
        private int x;
        public int X { get { return x; } }
        private int y;
        public int Y { get { return y; } }
        private int player;
        public int Player { get { return player; } }

        public Symbol(string character, int x, int y, int player, int width, int height)
        {
            this.character = character;
            this.player = player;
            this.x = x;
            this.y = y;
            position = new Point(x * width + width / 2 - 12, y * height + height / 2 - 12);
        }

        public void Draw(Graphics g)
        {
            g.DrawString(character, new Font("Arial", 24), Brushes.Black, position);
        }
    }
}
