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
        }
    }

    public enum GameMode
    {
        PC = 0,
        Human = 1
    }
}
