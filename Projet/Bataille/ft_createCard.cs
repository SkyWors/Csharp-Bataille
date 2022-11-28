namespace Bataille
{
    internal class ft_createCard
    {
        public const int PIQUE = 0, CARREAU = 1, COEUR = 2, TREFLE = 3;
        public const int SEPT = 7, HUIT = 8, NEUF = 9, DIX = 10, VALET = 11, DAME = 12, ROI = 13, AS = 14;
        public static int[] carte = new int[32];
        public static int[] couleur = new int[32];

        public static void createCard()
        {
            int i = 0;
            for (int c = 0; c < 4; c++)
            {
                for (int f = 7; f < 15; f++)
                {
                    carte[i] = f;
                    couleur[i] = c;
                    i++;
                }
            }
            ft_check.checkCard(carte, couleur);

            ft_randomizeCard.randomizeCard(carte, couleur);
        }
    }
}
