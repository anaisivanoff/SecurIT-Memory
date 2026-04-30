using System;
using System.Drawing;
using System.Windows.Forms;
using ProjetSecurITMemory.Models;

namespace ProjetSecurITMemory
{
    public partial class FormOptions : Form
    {
        public DifficultyLevel SelectedDifficulty { get; private set; }

        public bool SelectedModeMemoireInversee { get; private set; }
        public bool SelectedModeChronometre { get; private set; }
        public bool SelectedModeHardcore { get; private set; }

        public FormOptions()
        {
            InitializeComponent();

            this.BackColor = ColorTranslator.FromHtml("#0A0F1F");
            this.ForeColor = Color.White;
            this.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            grpDifficulte.ForeColor = Color.White;
            grpModes.ForeColor = Color.White;

            btnValider.BackColor = ColorTranslator.FromHtml("#1F6FEB");
            btnValider.ForeColor = Color.White;
            btnValider.FlatStyle = FlatStyle.Flat;
            btnValider.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#00E5FF");
            btnValider.FlatAppearance.BorderSize = 2;

            rbFacile.Checked = true;

            lblErreursMax.Visible = false;
            numErreursMax.Visible = false;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (rbMoyen.Checked)
                SelectedDifficulty = DifficultyLevel.Moyen;
            else if (rbDifficile.Checked)
                SelectedDifficulty = DifficultyLevel.Difficile;
            else
                SelectedDifficulty = DifficultyLevel.Facile;

            SelectedModeMemoireInversee = chkMemoireInversee.Checked;
            SelectedModeChronometre = chkChronometre.Checked;
            SelectedModeHardcore = chkHardcore.Checked;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
