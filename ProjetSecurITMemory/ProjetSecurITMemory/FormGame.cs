using ProjetSecurITMemory.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjetSecurITMemory
{
    public partial class FormGame : Form
    {
        private int tempsEcoule = 0;
        private List<Button> _boutonsCartes = new List<Button>();
        private JeuMemory _jeu;

        private Image _imageDos;
        private readonly GameOptions _options;

        public FormGame(GameOptions options)
        {
            InitializeComponent();

            _options = options;

            // CHEMIN ABSOLU
            _imageDos = Image.FromFile(
                @"C:\Users\harin\source\repos\SecurIT-Memory\ProjetSecurITMemory\ProjetSecurITMemory\Images\dos.png"
            );

            _jeu = new JeuMemory();
            _jeu.InitialiserJeu(_options.NombrePaires);

            tempsEcoule = 0;
            lblTemps.Text = "Temps : 0 s";
            timerTemps.Enabled = true;

            InitialiserPlateau(_options.Lignes, _options.Colonnes);
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
                tablePlateau.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / colonnes));

            for (int r = 0; r < lignes; r++)
                tablePlateau.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / lignes));

            _boutonsCartes.Clear();

            for (int r = 0; r < lignes; r++)
            {
                for (int c = 0; c < colonnes; c++)
                {
                    Button btn = new Button();
                    btn.Dock = DockStyle.Fill;
                    btn.Margin = new Padding(5);
                    btn.BackgroundImageLayout = ImageLayout.Zoom;
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

                btn.Text = "";
                btn.BackColor = Color.White;

                if (carte.Etat == EtatCarte.Cachee)
                {
                    btn.BackgroundImage = _imageDos;
                    btn.Enabled = true;
                }
                else if (carte.Etat == EtatCarte.Revelee)
                {
                    btn.BackgroundImage = carte.Image;
                    btn.Enabled = true;
                }
                else if (carte.Etat == EtatCarte.Trouvee)
                {
                    btn.BackgroundImage = carte.Image;
                    btn.Enabled = false;
                }
            }
        }

        private void btnRejouer_Click(object sender, EventArgs e)
        {
            tempsEcoule = 0;
            lblTemps.Text = "Temps : 0 s";

            _jeu.Reinitialiser(_options.NombrePaires);
            timerTemps.Enabled = true;

            InitialiserPlateau(_options.Lignes, _options.Colonnes);
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
