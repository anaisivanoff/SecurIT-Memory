using System;
using System.Windows.Forms;
using ProjetSecurITMemory.Models;

namespace ProjetSecurITMemory
{
    public partial class FormOptions : Form
    {
        // Propriété qui contient la difficulté choisie
        public DifficultyLevel SelectedDifficulty { get; private set; }

        public FormOptions()
        {
            InitializeComponent();

            rbFacile.Checked = true; // valeur par défaut
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (rbMoyen.Checked)
                SelectedDifficulty = DifficultyLevel.Moyen;
            else if (rbDifficile.Checked)
                SelectedDifficulty = DifficultyLevel.Difficile;
            else
                SelectedDifficulty = DifficultyLevel.Facile;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
