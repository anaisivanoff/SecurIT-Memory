namespace ProjetSecurITMemory
{
    partial class FormGame
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tablePlateau = new System.Windows.Forms.TableLayoutPanel();
            this.lblTemps = new System.Windows.Forms.Label();
            this.timerTemps = new System.Windows.Forms.Timer(this.components);
            this.btnRejouer = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tablePlateau
            // 
            this.tablePlateau.ColumnCount = 4;
            this.tablePlateau.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePlateau.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePlateau.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePlateau.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePlateau.RowCount = 4;
            this.tablePlateau.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePlateau.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePlateau.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePlateau.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePlateau.Location = new System.Drawing.Point(12, 50);
            this.tablePlateau.Name = "tablePlateau";
            this.tablePlateau.Size = new System.Drawing.Size(776, 388);
            this.tablePlateau.TabIndex = 0;
            // 
            // lblTemps
            // 
            this.lblTemps.AutoSize = true;
            this.lblTemps.Location = new System.Drawing.Point(12, 15);
            this.lblTemps.Name = "lblTemps";
            this.lblTemps.Size = new System.Drawing.Size(73, 15);
            this.lblTemps.TabIndex = 1;
            this.lblTemps.Text = "Temps : 0 s";
            // 
            // timerTemps
            // 
            this.timerTemps.Interval = 1000;
            this.timerTemps.Tick += new System.EventHandler(this.timerTemps_Tick);
            // 
            // btnRejouer
            // 
            this.btnRejouer.Location = new System.Drawing.Point(600, 10);
            this.btnRejouer.Name = "btnRejouer";
            this.btnRejouer.Size = new System.Drawing.Size(80, 30);
            this.btnRejouer.TabIndex = 2;
            this.btnRejouer.Text = "Rejouer";
            this.btnRejouer.UseVisualStyleBackColor = true;
            this.btnRejouer.Click += new System.EventHandler(this.btnRejouer_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(690, 10);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(80, 30);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnRejouer);
            this.Controls.Add(this.lblTemps);
            this.Controls.Add(this.tablePlateau);
            this.Name = "FormGame";
            this.Text = "SecurIT Memory - Jeu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tablePlateau;
        private System.Windows.Forms.Label lblTemps;
        private System.Windows.Forms.Timer timerTemps;
        private System.Windows.Forms.Button btnRejouer;
        private System.Windows.Forms.Button btnQuitter;
    }
}
