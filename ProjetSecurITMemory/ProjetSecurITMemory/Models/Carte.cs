using System.Drawing;

namespace ProjetSecurITMemory.Models
{
    public enum EtatCarte
    {
        Cachee,
        Revelee,
        Trouvee
    }

    public class Carte
    {
        public int PaireId { get; private set; }
        public string NomImage { get; private set; }
        public Image Image { get; private set; }
        public EtatCarte Etat { get; private set; }

        public Carte(int paireId, string nomImage)
        {
            PaireId = paireId;
            NomImage = nomImage;

            // CHEMIN ABSOLU (ton dossier exact)
            string chemin = $@"C:\Users\harin\source\repos\SecurIT-Memory\ProjetSecurITMemory\ProjetSecurITMemory\Images\{nomImage}.png";

            Image = Image.FromFile(chemin);

            Etat = EtatCarte.Cachee;
        }

        public void Reveler() => Etat = EtatCarte.Revelee;
        public void Cacher() => Etat = EtatCarte.Cachee;
        public void MarquerTrouvee() => Etat = EtatCarte.Trouvee;
    }
}
