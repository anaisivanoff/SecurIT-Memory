using System;
using System.Collections.Generic;

namespace ProjetSecurITMemory.Models
{
    public enum ResultatClic
    {
        Aucun,
        PremiereCarteRevelee,
        DeuxiemeCarteNonCorrespondante,
        PaireTrouvee,
        Victoire
    }

    public class JeuMemory
    {
        private readonly Random _random = new Random();

        public List<Carte> Cartes { get; private set; } = new List<Carte>();

        public int NombreEssais { get; private set; }

        public int TempsEnSecondes { get; private set; }

        private Carte _premiereCarteRevelee;
        private Carte _deuxiemeCarteRevelee;

        // 🔹 Ajout obligatoire pour FormGame
        public bool BlocageClics { get; set; } = false;
        public bool PartieTerminee { get; set; } = false;

        public void InitialiserJeu(int nombrePaires)
        {
            Cartes.Clear();
            NombreEssais = 0;
            TempsEnSecondes = 0;
            PartieTerminee = false;
            BlocageClics = false;
            _premiereCarteRevelee = null;
            _deuxiemeCarteRevelee = null;

            // Création des paires
            for (int paireId = 1; paireId <= nombrePaires; paireId++)
            {
                string nomImage = $"icone_{paireId}";
                Cartes.Add(new Carte(paireId, nomImage));
                Cartes.Add(new Carte(paireId, nomImage));
            }

            MelangerCartes();
        }

        private void MelangerCartes()
        {
            int n = Cartes.Count;
            while (n > 1)
            {
                n--;
                int k = _random.Next(n + 1);
                Carte valeur = Cartes[k];
                Cartes[k] = Cartes[n];
                Cartes[n] = valeur;
            }
        }

        public void IncrementerTemps()
        {
            if (!PartieTerminee)
                TempsEnSecondes++;
        }

        public ResultatClic CliquerSurCarte(int index)
        {
            if (BlocageClics || PartieTerminee)
                return ResultatClic.Aucun;

            if (index < 0 || index >= Cartes.Count)
                return ResultatClic.Aucun;

            var carte = Cartes[index];

            if (carte.Etat != EtatCarte.Cachee)
                return ResultatClic.Aucun;

            // Première carte
            if (_premiereCarteRevelee == null)
            {
                carte.Reveler();
                _premiereCarteRevelee = carte;
                return ResultatClic.PremiereCarteRevelee;
            }

            // Deuxième carte
            if (_deuxiemeCarteRevelee == null)
            {
                carte.Reveler();
                _deuxiemeCarteRevelee = carte;
                NombreEssais++;

                // Paire trouvée
                if (_premiereCarteRevelee.PaireId == _deuxiemeCarteRevelee.PaireId)
                {
                    _premiereCarteRevelee.MarquerTrouvee();
                    _deuxiemeCarteRevelee.MarquerTrouvee();

                    _premiereCarteRevelee = null;
                    _deuxiemeCarteRevelee = null;

                    if (ToutesLesCartesTrouvees())
                    {
                        PartieTerminee = true;
                        return ResultatClic.Victoire;
                    }

                    return ResultatClic.PaireTrouvee;
                }
                else
                {
                    // Mauvaise paire → blocage
                    BlocageClics = true;
                    return ResultatClic.DeuxiemeCarteNonCorrespondante;
                }
            }

            return ResultatClic.Aucun;
        }

        private bool ToutesLesCartesTrouvees()
        {
            foreach (var carte in Cartes)
            {
                if (carte.Etat != EtatCarte.Trouvee)
                    return false;
            }
            return true;
        }

        public void RecacherCartesNonCorrespondantes()
        {
            if (_premiereCarteRevelee != null)
                _premiereCarteRevelee.Cacher();

            if (_deuxiemeCarteRevelee != null)
                _deuxiemeCarteRevelee.Cacher();

            _premiereCarteRevelee = null;
            _deuxiemeCarteRevelee = null;
            BlocageClics = false;
        }

        // 🔹 Utilisé pour le mode Mémoire inversée
        public void RecacherToutesLesCartes()
        {
            foreach (var carte in Cartes)
            {
                if (carte.Etat != EtatCarte.Trouvee)
                    carte.Cacher();
            }

            _premiereCarteRevelee = null;
            _deuxiemeCarteRevelee = null;
            BlocageClics = false;
        }

        public void Reinitialiser(int nombrePaires)
        {
            InitialiserJeu(nombrePaires);
        }
    }
}
