using System;

namespace Bataille
{
    internal class ft_createCard
    {

        public static void createCard()
        {
            int i = 0;
            for (int c = 0; c < 4; c++)
            {
                for (int f = 7; f < 15; f++)
                {
                    global.carte[i] = f;
                    global.couleur[i] = c;
                    i++;
                }
            }
        }
        public static void addCard()
        {
            int j = 0;
            for (int i = 0; i < 32; i++)
            {
                if (j % 8 == 0) Console.WriteLine();

                global.card[i] = i;
                j++;
            }
        }
    }
}
