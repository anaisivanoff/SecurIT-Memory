namespace ProjetSecurITMemory.Models
{
    public class GameOptions
    {
        public DifficultyLevel Difficulty { get; set; }
        public int NombrePaires { get; set; }
        public int Lignes { get; set; }
        public int Colonnes { get; set; }

        // 🔹 Modes
        public bool ModeMemoireInversee { get; set; }
        public bool ModeChronometre { get; set; }
        public bool ModeHardcore { get; set; }
        public int ErreursMax { get; set; } = 3;

        // 🔹 Temps limite (si mode chronométré)
        public int TempsLimite { get; set; }

        public GameOptions(DifficultyLevel difficulty)
        {
            Difficulty = difficulty;

            switch (difficulty)
            {
                case DifficultyLevel.Facile:
                    NombrePaires = 8;
                    Lignes = 4;
                    Colonnes = 4;
                    TempsLimite = 30;
                    break;

                case DifficultyLevel.Moyen:
                    NombrePaires = 10;
                    Lignes = 5;
                    Colonnes = 4;
                    TempsLimite = 45;
                    break;

                case DifficultyLevel.Difficile:
                    NombrePaires = 18;
                    Lignes = 6;
                    Colonnes = 6;
                    TempsLimite = 60;
                    break;
            }
        }
    }
}
