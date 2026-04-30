using ProjetSecurITMemory.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetSecurITMemory
{
    public partial class FormGame : Form
    {
        private int tempsEcoule = 0;
        private int tempsRestant = 0;

        private List<Button> _boutonsCartes = new List<Button>();
        private JeuMemory _jeu;

        private Image _imageDos;
        private readonly GameOptions _options;

        public FormGame(GameOptions options)
        {
            InitializeComponent();

            _options = options;

            // MODE HARDCORE : 50 paires = 100 cartes, timer 2 min
            if (_options.ModeHardcore)
            {
                _options.NombrePaires = 50;
                _options.Lignes = 10;
                _options.Colonnes = 10;
                _options.ModeChronometre = true;
                _options.TempsLimite = 120; // 2 minutes
            }

            // Thème
            this.BackColor = ColorTranslator.FromHtml("#0A0F1F");
            this.ForeColor = Color.White;
            this.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            btnRejouer.BackColor = ColorTranslator.FromHtml("#1F6FEB");
            btnRejouer.ForeColor = Color.White;
            btnRejouer.FlatStyle = FlatStyle.Flat;
            btnRejouer.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#00E5FF");
            btnRejouer.FlatAppearance.BorderSize = 2;

            btnQuitter.BackColor = ColorTranslator.FromHtml("#1F6FEB");
            btnQuitter.ForeColor = Color.White;
            btnQuitter.FlatStyle = FlatStyle.Flat;
            btnQuitter.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#00E5FF");
            btnQuitter.FlatAppearance.BorderSize = 2;

            _imageDos = Image.FromFile(
                @"C:\Users\harin\source\repos\SecurIT-Memory\ProjetSecurITMemory\ProjetSecurITMemory\Images\dos.png"
            );

            _jeu = new JeuMemory();
            _jeu.InitialiserJeu(_options.NombrePaires);

            if (_options.ModeChronometre)
            {
                tempsRestant = _options.TempsLimite;
                lblTemps.Text = $"Temps restant : {tempsRestant} s";
            }
            else
            {
                lblTemps.Text = "Temps : 0 s";
            }

            timerTemps.Enabled = true;

            InitialiserPlateau(_options.Lignes, _options.Colonnes);

            if (_options.ModeMemoireInversee)
                RevelePuisCache();
            else
                MettreAJourAffichageCartes();
        }

        private void RevelePuisCache()
        {
            foreach (var carte in _jeu.Cartes)
                carte.Etat = EtatCarte.Revelee;

            MettreAJourAffichageCartes();

            Timer t = new Timer();
            t.Interval = 3000;
            t.Tick += (s, e) =>
            {
                t.Stop();
                t.Dispose();

                _jeu.RecacherToutesLesCartes();
                MettreAJourAffichageCartes();
            };
            t.Start();
        }

        private void timerTemps_Tick(object sender, EventArgs e)
        {
            if (_options.ModeChronometre)
            {
                tempsRestant--;

                if (tempsRestant <= 0)
                {
                    timerTemps.Enabled = false;
                    lblTemps.Text = "Temps restant : 0 s";

                    MessageBox.Show(
                        _options.ModeHardcore
                            ? "Temps écoulé ! Le mode Hardcore (100 cartes) est impitoyable."
                            : "Temps écoulé ! Partie perdue.",
                        "Défaite",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    _jeu.PartieTerminee = true;
                    return;
                }

                lblTemps.Text = $"Temps restant : {tempsRestant} s";
            }
            else
            {
                tempsEcoule++;
                lblTemps.Text = $"Temps : {tempsEcoule} s";
            }
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
                    btn.Margin = new Padding(3);
                    btn.BackgroundImageLayout = ImageLayout.Zoom;

                    btn.BackColor = ColorTranslator.FromHtml("#111827");
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#00E5FF");
                    btn.FlatAppearance.BorderSize = 1;

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
            int index = _boutonsCartes.IndexOf(btn);

            var resultat = _jeu.CliquerSurCarte(index);

            MettreAJourAffichageCartes();

            if (resultat == ResultatClic.DeuxiemeCarteNonCorrespondante)
            {
                Timer timerRetard = new Timer();
                timerRetard.Interval = _options.ModeHardcore ? 500 : 800;
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
                    _options.ModeHardcore
                        ? "INCROYABLE ! Tu as terminé le Mode HARDCORE (100 cartes) 🎯🔥"
                        : "Bravo ! Vous avez gagné !",
                    "Victoire",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void MettreAJourAffichageCartes()
        {
            for (int i = 0; i < _boutonsCartes.Count; i++)
            {
                var btn = _boutonsCartes[i];
                var carte = _jeu.Cartes[i];

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
            FormGame newGame = new FormGame(_options);
            newGame.Show();
            this.Close();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }
    }
}
