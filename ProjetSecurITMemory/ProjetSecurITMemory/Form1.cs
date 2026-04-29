using ProjetSecurITMemory.Models;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjetSecurITMemory
{
    public partial class Form1 : Form
    {
        private int secondes = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            secondes = 0;
            lblTemps.Text = "Temps : 0 s";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            secondes++;
            lblTemps.Text = "Temps : " + secondes + " s";
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            // Lancement direct en mode facile (4x4)
            GameOptions options = new GameOptions(DifficultyLevel.Facile);

            FormGame game = new FormGame(options);
            game.Show();
            this.Hide();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            FormOptions opt = new FormOptions();

            if (opt.ShowDialog() == DialogResult.OK)
            {
                DifficultyLevel chosen = opt.SelectedDifficulty;

                GameOptions options = new GameOptions(chosen);

                FormGame game = new FormGame(options);
                game.Show();
                this.Hide();
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOptions_Click_1(object sender, EventArgs e)
        {
            FormOptions opt = new FormOptions();

            if (opt.ShowDialog() == DialogResult.OK)
            {
                GameOptions options = new GameOptions(opt.SelectedDifficulty);

                FormGame game = new FormGame(options);
                game.Show();
                this.Hide();
            }
        }
    }
}
