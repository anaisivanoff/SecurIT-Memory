namespace ProjetSecurITMemory.Models
{
    public class GameOptions
    {
        public DifficultyLevel Difficulty { get; set; }
        public int NombrePaires { get; set; }
        public int Lignes { get; set; }
        public int Colonnes { get; set; }

        public GameOptions(DifficultyLevel difficulty)
        {
            Difficulty = difficulty;

            switch (difficulty)
            {
                case DifficultyLevel.Facile:
                    NombrePaires = 8;   // 4x4
                    Lignes = 4;
                    Colonnes = 4;
                    break;

                case DifficultyLevel.Moyen:
                    NombrePaires = 10;  // 5x4
                    Lignes = 5;
                    Colonnes = 4;
                    break;

                case DifficultyLevel.Difficile:
                    NombrePaires = 18;  // 6x6
                    Lignes = 6;
                    Colonnes = 6;
                    break;
            }
        }
    }
}
