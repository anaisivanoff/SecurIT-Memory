using System;
using System.Windows.Forms;

namespace ProjetSecurITMemory
{
    public partial class Form1 : Form
    {
        // Chronomètre
        private int secondes = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // Chargement du formulaire
        private void Form1_Load_1(object sender, EventArgs e)
        {
            secondes = 0;
            lblTemps.Text = "Temps : 0 s";

            timer1.Start();   // démarre le timer du menu
        }

        // Tick du timer du menu
        private void timer1_Tick(object sender, EventArgs e)
        {
            secondes++;
            lblTemps.Text = "Temps : " + secondes + " s";
        }

        // Bouton Jouer
        private void btnPlay_Click(object sender, EventArgs e)
        {
            FormGame game = new FormGame();
            game.Show();   // ouvre la fenêtre du jeu
            this.Hide();   // cache le menu (optionnel)
        }
    }
}
