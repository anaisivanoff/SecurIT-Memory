namespace ProjetSecurITMemory
{
    partial class FormOptions
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox grpDifficulte;
        private System.Windows.Forms.RadioButton rbFacile;
        private System.Windows.Forms.RadioButton rbMoyen;
        private System.Windows.Forms.RadioButton rbDifficile;
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
            this.btnValider = new System.Windows.Forms.Button();
            this.grpDifficulte.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDifficulte
            // 
            this.grpDifficulte.Controls.Add(this.rbDifficile);
            this.grpDifficulte.Controls.Add(this.rbMoyen);
            this.grpDifficulte.Controls.Add(this.rbFacile);
            this.grpDifficulte.Location = new System.Drawing.Point(30, 30);
            this.grpDifficulte.Name = "grpDifficulte";
            this.grpDifficulte.Size = new System.Drawing.Size(200, 120);
            this.grpDifficulte.TabIndex = 0;
            this.grpDifficulte.TabStop = false;
            this.grpDifficulte.Text = "Difficulté";
            // 
            // rbFacile
            // 
            this.rbFacile.AutoSize = true;
            this.rbFacile.Location = new System.Drawing.Point(20, 25);
            this.rbFacile.Name = "rbFacile";
            this.rbFacile.Size = new System.Drawing.Size(78, 19);
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
            this.rbMoyen.Size = new System.Drawing.Size(89, 19);
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
            this.rbDifficile.Size = new System.Drawing.Size(92, 19);
            this.rbDifficile.TabIndex = 2;
            this.rbDifficile.TabStop = true;
            this.rbDifficile.Text = "Difficile (6x6)";
            this.rbDifficile.UseVisualStyleBackColor = true;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(30, 170);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(200, 35);
            this.btnValider.TabIndex = 1;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // FormOptions
            // 
            this.ClientSize = new System.Drawing.Size(284, 241);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.grpDifficulte);
            this.Name = "FormOptions";
            this.Text = "Options";
            this.grpDifficulte.ResumeLayout(false);
            this.grpDifficulte.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
