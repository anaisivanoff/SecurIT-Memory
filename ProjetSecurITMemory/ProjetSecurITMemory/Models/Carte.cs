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
        public int PaireId { get; set; }
        public string NomImage { get; set; }
        public EtatCarte Etat { get; private set; }

        public Carte(int paireId, string nomImage)
        {
            PaireId = paireId;
            NomImage = nomImage;
            Etat = EtatCarte.Cachee;
        }

        public void Reveler()
        {
            if (Etat == EtatCarte.Cachee)
            {
                Etat = EtatCarte.Revelee;
            }
        }

        public void Cacher()
        {
            if (Etat == EtatCarte.Revelee)
            {
                Etat = EtatCarte.Cachee;
            }
        }

        public void MarquerTrouvee()
        {
            Etat = EtatCarte.Trouvee;
        }
    }
}