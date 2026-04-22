using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetSecurITMemory
{
    public partial class FormGame : Form
    {
        private int tempsEcoule = 0;
        private List<Button> _boutonsCartes = new List<Button>();

        public FormGame()
        {
            InitializeComponent();

            tempsEcoule = 0;
            lblTemps.Text = "Temps : 0 s";
            timerTemps.Enabled = true;

            InitialiserPlateau(4, 4);
        }

        private void timerTemps_Tick(object sender, EventArgs e)
        {
            tempsEcoule++;
            lblTemps.Text = $"Temps : {tempsEcoule} s";
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
            Button btn = sender as Button;
            if (btn == null)
                return;

            btn.Text = "X";
        }
    }
}