using ProjetSecurITMemory.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetSecurITMemory
{
    public partial class Form1 : Form
    {
        private int secondes = 0;

        // --- Effet lignes de code ---
        private Random rnd = new Random();
        private int[] positionsY;
        private string[] codeLines;
        private Timer codeTimer;

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

            // Centrage du titre
            this.Load += (s, e) =>
            {
                lblTitle.Left = (this.ClientSize.Width - lblTitle.Width) / 2;
                InitCodeRain();
            };

            this.Resize += (s, e) =>
            {
                lblTitle.Left = (this.ClientSize.Width - lblTitle.Width) / 2;
            };

            this.Paint += Form1_Paint;
        }

        // Initialisation des lignes de code
        private void InitCodeRain()
        {
            // VRAIES LIGNES DE CODE CYBER
            codeLines = new string[]
            {
                "Scanning ports... OPEN 443",
                "Firewall status: ACTIVE",
                "Encrypting payload...",
                "Hashing credentials SHA-256",
                "Connecting to secure node...",
                "Analyzing packets...",
                "Bruteforce protection enabled",
                "Monitoring network traffic...",
                "Access token validated",
                "Launching intrusion detection...",
                "Compiling security rules...",
                "Scanning vulnerabilities...",
                "TLS handshake completed",
                "Session key generated",
                "Security audit running..."
            };

            int columns = Math.Max(1, this.ClientSize.Width / 300);
            positionsY = new int[columns];

            for (int i = 0; i < columns; i++)
                positionsY[i] = rnd.Next(-600, 0);

            codeTimer = new Timer();
            codeTimer.Interval = 50;
            codeTimer.Tick += CodeTimer_Tick;
            codeTimer.Start();
        }

        // Animation
        private void CodeTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < positionsY.Length; i++)
            {
                positionsY[i] += 5;

                if (positionsY[i] > this.ClientSize.Height)
                    positionsY[i] = rnd.Next(-400, 0);
            }

            this.Invalidate();
        }

        // Dessin des LIGNES DE CODE
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (positionsY == null) return;

            Graphics g = e.Graphics;

            for (int i = 0; i < positionsY.Length; i++)
            {
                int x = i * 300;
                int y = positionsY[i];

                string line = codeLines[rnd.Next(codeLines.Length)];

                using (Brush b = new SolidBrush(Color.FromArgb(180, 0, 255, 255))) // turquoise
                using (Font f = new Font("Consolas", 14, FontStyle.Bold))
                {
                    g.DrawString(line, f, b, x, y);
                }
            }
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
