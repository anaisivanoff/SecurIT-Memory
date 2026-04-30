using ProjetSecurITMemory.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetSecurITMemory
{
    public partial class Form1 : Form
    {
        private int secondes = 0;

        public Form1()
        {
            InitializeComponent();

            // Thème Cyber
            this.BackColor = ColorTranslator.FromHtml("#0A0F1F");
            this.ForeColor = Color.White;
            this.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = ColorTranslator.FromHtml("#1F6FEB");
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#00E5FF");
                    btn.FlatAppearance.BorderSize = 2;
                }
            }

            lblTemps.ForeColor = Color.White;

            // ⭐ Centrage automatique du titre au démarrage
            this.Load += (s, e) =>
            {
                lblTitle.Left = (this.ClientSize.Width - lblTitle.Width) / 2;
            };

            // ⭐ Centrage automatique si la fenêtre change de taille
            this.Resize += (s, e) =>
            {
                lblTitle.Left = (this.ClientSize.Width - lblTitle.Width) / 2;
            };
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
                GameOptions options = new GameOptions(opt.SelectedDifficulty)
                {
                    ModeMemoireInversee = opt.SelectedModeMemoireInversee,
                    ModeChronometre = opt.SelectedModeChronometre,
                    ModeHardcore = opt.SelectedModeHardcore,
                };

                FormGame game = new FormGame(options);
                game.Show();
                this.Hide();
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
