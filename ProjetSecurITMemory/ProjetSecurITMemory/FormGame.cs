using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ProjetSecurITMemory.Models;

namespace ProjetSecurITMemory
{
    public partial class FormGame : Form
    {
        private int tempsEcoule = 0;
        private List<Button> _boutonsCartes = new List<Button>();
        private JeuMemory _jeu;

        public FormGame()
        {
            InitializeComponent();

            _jeu = new JeuMemory();
            _jeu.InitialiserJeu(8);

            tempsEcoule = 0;
            lblTemps.Text = "Temps : 0 s";
            timerTemps.Enabled = true;

            InitialiserPlateau(4, 4);
            MettreAJourAffichageCartes();
        }

        private void timerTemps_Tick(object sender, EventArgs e)
        {
            tempsEcoule++;
            lblTemps.Text = $"Temps : {tempsEcoule} s";
            _jeu.IncrementerTemps();
        }

        private void InitialiserPlateau(int lignes, int colonnes)
        {
            tablePlateau.RowCount = lignes;
            tablePlateau.ColumnCount = colonnes;
            tablePlateau.Controls.Clear();
            tablePlateau.ColumnStyles.Clear();
            tablePlateau.RowStyles.Clear();

            for (int c = 0; c < colonnes; c++)
            {
                tablePlateau.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / colonnes));
            }

            for (int r = 0; r < lignes; r++)
            {
                tablePlateau.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / lignes));
            }

            _boutonsCartes.Clear();

            for (int r = 0; r < lignes; r++)
            {
                for (int c = 0; c < colonnes; c++)
                {
                    Button btn = new Button();
                    btn.Dock = DockStyle.Fill;
                    btn.Margin = new Padding(5);
                    btn.Font = new Font(FontFamily.GenericSansSerif, 14, FontStyle.Bold);
                    btn.Tag = null;
                    btn.Text = "";
                    btn.Click += BoutonCarte_Click;

                    _boutonsCartes.Add(btn);
                    tablePlateau.Controls.Add(btn, c, r);
                }
            }
        }

        private void BoutonCarte_Click(object sender, EventArgs e)
        {
            if (_jeu.BlocageClics || _jeu.PartieTerminee)
                return;

            Button btn = sender as Button;
            if (btn == null)
                return;

            int index = _boutonsCartes.IndexOf(btn);
            if (index < 0 || index >= _jeu.Cartes.Count)
                return;

            var resultat = _jeu.CliquerSurCarte(index);

            MettreAJourAffichageCartes();

            if (resultat == ResultatClic.DeuxiemeCarteNonCorrespondante)
            {
                Timer timerRetard = new Timer();
                timerRetard.Interval = 800;
                timerRetard.Tick += (s, args) =>
                {
                    timerRetard.Stop();
                    timerRetard.Dispose();

                    _jeu.RecacherCartesNonCorrespondantes();
                    MettreAJourAffichageCartes();
                };
                timerRetard.Start();
            }
            else if (resultat == ResultatClic.Victoire)
            {
                timerTemps.Enabled = false;
                MessageBox.Show(
                    $"Bravo ! Vous avez gagné en {tempsEcoule} secondes avec {_jeu.NombreEssais} essais.",
                    "Victoire",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void MettreAJourAffichageCartes()
        {
            for (int i = 0; i < _boutonsCartes.Count && i < _jeu.Cartes.Count; i++)
            {
                var btn = _boutonsCartes[i];
                var carte = _jeu.Cartes[i];

                if (carte.Etat == EtatCarte.Cachee)
                {
                    btn.Text = "";
                    btn.Enabled = true;
                    btn.BackColor = SystemColors.Control;
                }
                else if (carte.Etat == EtatCarte.Revelee)
                {
                    btn.Text = carte.PaireId.ToString();
                    btn.Enabled = true;
                    btn.BackColor = Color.LightYellow;
                }
                else if (carte.Etat == EtatCarte.Trouvee)
                {
                    btn.Text = carte.PaireId.ToString();
                    btn.Enabled = false;
                    btn.BackColor = Color.LightGreen;
                }
            }
        }

        private void btnRejouer_Click(object sender, EventArgs e)
        {
            tempsEcoule = 0;
            lblTemps.Text = "Temps : 0 s";

            _jeu.Reinitialiser(8);      // pour l’instant 8 paires, on branchera sur les Options plus tard
            timerTemps.Enabled = true;

            InitialiserPlateau(4, 4);   // même grille 4x4 pour l’instant
            MettreAJourAffichageCartes();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            timerTemps.Enabled = false;

            Form1 menu = new Form1();
            menu.Show();

            this.Close();
        }
    }
}