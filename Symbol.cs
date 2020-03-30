using System.Drawing;

namespace tic_tac_toe
{
    class Symbol
    {
        private string character;
        private PointF position;
        private int player;

        public Symbol(string character, float x, float y, int player, float width, float height)
        {
            this.character = character;
            this.player = player;
            position = new PointF(x * width + width / 2 - 14f, y * height + height / 2 - 14f);
        }

        public void Draw(Graphics g)
        {
            g.DrawString(character, new Font("Arial", 24), Brushes.Black, position);
        }
    }
}
