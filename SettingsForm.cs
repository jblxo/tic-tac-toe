using System;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            InitializeFieldSize();
            InitializeSymbolSelects();
        }

        private void InitializeFieldSize()
        {
            npdFieldSizeX.Value = Settings.Instance.FieldSize.Width;
            npdFieldSizeY.Value = Settings.Instance.FieldSize.Height;
        }

        private void InitializeSymbolSelects()
        {
            cmbbxPlayer1Symbol.SelectedItem = Settings.Instance.Player1Symbol;
            cmbbxPlayer2Symbol.SelectedItem = Settings.Instance.Player2Symbol;
            cmbbxPlayer1Symbol.Items.Remove(Settings.Instance.Player2Symbol);
            cmbbxPlayer2Symbol.Items.Remove(Settings.Instance.Player1Symbol);
        }

        private void npdFieldSizeX_ValueChanged(object sender, EventArgs e)
        {
            Settings.Instance.FieldSizeX = (int) npdFieldSizeX.Value;
        }

        private void npdFieldSizeY_ValueChanged(object sender, EventArgs e)
        {
            Settings.Instance.FieldSizeY = (int) npdFieldSizeY.Value;
        }

        private void cmbbxPlayer1Symbol_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbbxPlayer2Symbol.Items.Add(Settings.Instance.Player1Symbol);
            Settings.Instance.Player1Symbol = (string)cmbbxPlayer1Symbol.SelectedItem;
            cmbbxPlayer2Symbol.Items.Remove(Settings.Instance.Player1Symbol);
        }

        private void cmbbxPlayer2Symbol_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbbxPlayer1Symbol.Items.Add(Settings.Instance.Player2Symbol);
            Settings.Instance.Player2Symbol = (string)cmbbxPlayer2Symbol.SelectedItem;
            cmbbxPlayer1Symbol.Items.Remove(Settings.Instance.Player2Symbol);
        }
    }
}
