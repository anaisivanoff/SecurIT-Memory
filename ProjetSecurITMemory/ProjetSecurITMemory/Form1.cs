using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetSecurITMemory.Models;

namespace ProjetSecurITMemory
{
    public partial class Form1 : Form
    {
        private JeuMemory _jeu;

        public Form1()
        {
            InitializeComponent();

            _jeu = new JeuMemory();
            _jeu.InitialiserJeu(8); // par exemple 8 paires pour commencer
        }
    }
}