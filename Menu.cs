using System;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnPCGame_Click(object sender, EventArgs e)
        {
            SwitchForms(new Game(GameMode.PC));
        }

        private void btnHumanGame_Click(object sender, EventArgs e)
        {
            SwitchForms(new Game(GameMode.Human));
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hint for player.");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SwitchForms(new SettingsForm());
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SwitchForms(Form form)
        {
            form.Show();
            form.FormClosed += (sender, args) => Show();
            Hide();
        }
    }
}
