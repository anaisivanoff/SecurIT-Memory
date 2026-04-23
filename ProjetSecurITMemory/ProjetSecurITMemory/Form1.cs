using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetSecurITMemory.Models;

namespace ProjetSecurITMemory
{
    public partial class Form1 : Form
    {
        private JeuMemory _jeu;
        private int tempsEcoule = 0;

        public Form1()
        {
            InitializeComponent();

            _jeu = new JeuMemory();
            _jeu.InitialiserJeu(8);

            tempsEcoule = 0;
            lblTemps.Text = "Temps : 0 s";
            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            tempsEcoule++;
            lblTemps.Text = $"Temps : {tempsEcoule} s";
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

        }
    }
    private void btnPlay_Click(object sender, EventArgs e)
        {
            FormGame game = new FormGame();
            game.Show();   // affiche la fenêtre de jeu
            this.Hide();   // cache le menu
        }
    }