namespace ProjetSecurITMemory
{
    partial class FormOptions
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox grpDifficulte;
        private System.Windows.Forms.RadioButton rbFacile;
        private System.Windows.Forms.RadioButton rbMoyen;
        private System.Windows.Forms.RadioButton rbDifficile;

        private System.Windows.Forms.GroupBox grpModes;
        private System.Windows.Forms.CheckBox chkMemoireInversee;
        private System.Windows.Forms.CheckBox chkChronometre;
        private System.Windows.Forms.CheckBox chkHardcore;

        private System.Windows.Forms.Label lblErreursMax;
        private System.Windows.Forms.NumericUpDown numErreursMax;

        private System.Windows.Forms.Button btnValider;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpDifficulte = new System.Windows.Forms.GroupBox();
            this.rbFacile = new System.Windows.Forms.RadioButton();
            this.rbMoyen = new System.Windows.Forms.RadioButton();
            this.rbDifficile = new System.Windows.Forms.RadioButton();

            this.grpModes = new System.Windows.Forms.GroupBox();
            this.chkMemoireInversee = new System.Windows.Forms.CheckBox();
            this.chkChronometre = new System.Windows.Forms.CheckBox();
            this.chkHardcore = new System.Windows.Forms.CheckBox();

            this.lblErreursMax = new System.Windows.Forms.Label();
            this.numErreursMax = new System.Windows.Forms.NumericUpDown();

            this.btnValider = new System.Windows.Forms.Button();

            this.grpDifficulte.SuspendLayout();
            this.grpModes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numErreursMax)).BeginInit();
            this.SuspendLayout();

            // 
            // grpDifficulte
            // 
            this.grpDifficulte.Controls.Add(this.rbDifficile);
            this.grpDifficulte.Controls.Add(this.rbMoyen);
            this.grpDifficulte.Controls.Add(this.rbFacile);
            this.grpDifficulte.Location = new System.Drawing.Point(20, 20);
            this.grpDifficulte.Name = "grpDifficulte";
            this.grpDifficulte.Size = new System.Drawing.Size(240, 130);
            this.grpDifficulte.TabIndex = 0;
            this.grpDifficulte.TabStop = false;
            this.grpDifficulte.Text = "Difficulté";

            // 
            // rbFacile
            // 
            this.rbFacile.AutoSize = true;
            this.rbFacile.Location = new System.Drawing.Point(20, 25);
            this.rbFacile.Name = "rbFacile";
            this.rbFacile.Size = new System.Drawing.Size(90, 19);
            this.rbFacile.TabIndex = 0;
            this.rbFacile.TabStop = true;
            this.rbFacile.Text = "Facile (4x4)";
            this.rbFacile.UseVisualStyleBackColor = true;

            // 
            // rbMoyen
            // 
            this.rbMoyen.AutoSize = true;
            this.rbMoyen.Location = new System.Drawing.Point(20, 55);
            this.rbMoyen.Name = "rbMoyen";
            this.rbMoyen.Size = new System.Drawing.Size(96, 19);
            this.rbMoyen.TabIndex = 1;
            this.rbMoyen.TabStop = true;
            this.rbMoyen.Text = "Moyen (5x4)";
            this.rbMoyen.UseVisualStyleBackColor = true;

            // 
            // rbDifficile
            // 
            this.rbDifficile.AutoSize = true;
            this.rbDifficile.Location = new System.Drawing.Point(20, 85);
            this.rbDifficile.Name = "rbDifficile";
            this.rbDifficile.Size = new System.Drawing.Size(101, 19);
            this.rbDifficile.TabIndex = 2;
            this.rbDifficile.TabStop = true;
            this.rbDifficile.Text = "Difficile (6x6)";
            this.rbDifficile.UseVisualStyleBackColor = true;

            // 
            // grpModes
            // 
            this.grpModes.Controls.Add(this.chkMemoireInversee);
            this.grpModes.Controls.Add(this.chkChronometre);
            this.grpModes.Controls.Add(this.chkHardcore);
            this.grpModes.Controls.Add(this.lblErreursMax);
            this.grpModes.Controls.Add(this.numErreursMax);
            this.grpModes.Location = new System.Drawing.Point(20, 170);
            this.grpModes.Name = "grpModes";
            this.grpModes.Size = new System.Drawing.Size(240, 180);
            this.grpModes.TabIndex = 3;
            this.grpModes.TabStop = false;
            this.grpModes.Text = "Modes de jeu";

            // 
            // chkMemoireInversee
            // 
            this.chkMemoireInversee.AutoSize = true;
            this.chkMemoireInversee.Location = new System.Drawing.Point(20, 30);
            this.chkMemoireInversee.Name = "chkMemoireInversee";
            this.chkMemoireInversee.Size = new System.Drawing.Size(140, 19);
            this.chkMemoireInversee.TabIndex = 0;
            this.chkMemoireInversee.Text = "Mode Mémoire inversée";
            this.chkMemoireInversee.UseVisualStyleBackColor = true;

            // 
            // chkChronometre
            // 
            this.chkChronometre.AutoSize = true;
            this.chkChronometre.Location = new System.Drawing.Point(20, 60);
            this.chkChronometre.Name = "chkChronometre";
            this.chkChronometre.Size = new System.Drawing.Size(121, 19);
            this.chkChronometre.TabIndex = 1;
            this.chkChronometre.Text = "Mode Chronométré";
            this.chkChronometre.UseVisualStyleBackColor = true;

            // 
            // chkHardcore
            // 
            this.chkHardcore.AutoSize = true;
            this.chkHardcore.Location = new System.Drawing.Point(20, 90);
            this.chkHardcore.Name = "chkHardcore";
            this.chkHardcore.Size = new System.Drawing.Size(160, 19);
            this.chkHardcore.TabIndex = 2;
            this.chkHardcore.Text = "Hardcore (100 cartes)";
            this.chkHardcore.UseVisualStyleBackColor = true;

            // 
            // lblErreursMax
            // 
            this.lblErreursMax.AutoSize = true;
            this.lblErreursMax.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblErreursMax.Location = new System.Drawing.Point(20, 125);
            this.lblErreursMax.Name = "lblErreursMax";
            this.lblErreursMax.TabIndex = 3;
            this.lblErreursMax.Text = "Erreurs max :";
            this.lblErreursMax.Visible = false;

            // 
            // numErreursMax
            // 
            this.numErreursMax.Location = new System.Drawing.Point(200, 123);
            this.numErreursMax.Minimum = 1;
            this.numErreursMax.Maximum = 10;
            this.numErreursMax.Value = 3;
            this.numErreursMax.Name = "numErreursMax";
            this.numErreursMax.Size = new System.Drawing.Size(50, 23);
            this.numErreursMax.TabIndex = 4;
            this.numErreursMax.Visible = false;

            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(20, 370);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(240, 40);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);

            // 
            // FormOptions
            // 
            this.ClientSize = new System.Drawing.Size(284, 431);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.grpModes);
            this.Controls.Add(this.grpDifficulte);
            this.Name = "FormOptions";
            this.Text = "Options";

            this.grpDifficulte.ResumeLayout(false);
            this.grpDifficulte.PerformLayout();
            this.grpModes.ResumeLayout(false);
            this.grpModes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numErreursMax)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
