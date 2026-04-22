namespace ProjetSecurITMemory
{
    partial class FormGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TableLayoutPanel tablePlateau;
            tablePlateau = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tablePlateau
            // 
            tablePlateau.ColumnCount = 4;
            tablePlateau.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tablePlateau.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tablePlateau.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tablePlateau.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tablePlateau.Dock = System.Windows.Forms.DockStyle.Fill;
            tablePlateau.Location = new System.Drawing.Point(0, 0);
            tablePlateau.Name = "tablePlateau";
            tablePlateau.RowCount = 4;
            tablePlateau.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tablePlateau.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tablePlateau.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tablePlateau.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tablePlateau.Size = new System.Drawing.Size(800, 450);
            tablePlateau.TabIndex = 0;
            tablePlateau.Paint += new System.Windows.Forms.PaintEventHandler(this.tablePlateau_Paint);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(tablePlateau);
            this.Name = "FormGame";
            this.Text = "FormGame";
            this.ResumeLayout(false);

        }

        #endregion
    }
}