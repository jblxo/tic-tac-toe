using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace tic_tac_toe
{
    class Settings
    {
        private static Settings instance = new Settings();
        public static Settings Instance => instance;
        private Size fieldSize;
        public Size FieldSize { get { return fieldSize; } set { fieldSize = value; } }
        private string player1Symbol;
        public int FieldSizeX { set { fieldSize.Width = value; } }
        public int FieldSizeY { set { fieldSize.Height = value; } }
        public string Player1Symbol { get { return player1Symbol; } set { player1Symbol = value; } }
        private string player2Symbol;
        public string Player2Symbol { get { return player2Symbol; } set { player2Symbol = value; } }
        private Settings()
        {
            FieldSize = new Size(10, 10);
            Player1Symbol = "X";
            Player2Symbol = "O";
        }
    }
}
