using System;
using System.Collections.Generic;

namespace Bataille
{
    static class global
    {
        public static Stack<int> player1 = new Stack<int>();
        public static Stack<int> player2 = new Stack<int>();

        public static int[] randomSlot = new int[32];

        public const int PIQUE = 0, CARREAU = 1, COEUR = 2, TREFLE = 3;
        public const int SEPT = 7, HUIT = 8, NEUF = 9, DIX = 10, VALET = 11, DAME = 12, ROI = 13, AS = 14;
        public static int[] carte = new int[32];
        public static int[] couleur = new int[32];
        public static int[] card = new int[32];
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            foreach (int items in global.card)
            {
                global.randomSlot[items] = -1;
            }

            ft_createCard.createCard();
            ft_createCard.addCard();

            ft_distrib.distrib(global.player1);
            ft_distrib.distrib(global.player2);

            ft_check.check(global.player1, "Joueur 1");
            ft_check.check(global.player2, "Joueur 2");

            ft_design.design("Combien de tours ? ", false);
            int tours = Convert.ToInt32(Console.ReadLine());

            //int Timestamp = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds

            for (int i = 0; i < tours; i++)
            {
                int count1 = global.player1.Count;
                int count2 = global.player2.Count;
                if (count1 == 0 || count2 == 0)
                {
                    if (count1 == 0)
                    {
                        ft_design.design("Joueur 2 Gagnant", true);
                        break;
                    }
                    else
                    {
                        ft_design.design("Joueur 1 Gagnant", true);
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"    _____________________________________ [Tours {i+1}/{tours}]\n");

                    int cardPlayer1 = global.player1.Pop();
                    int cardPlayer2 = global.player2.Pop();

                    ft_design.design($"Joueur 1 : {ft_design.translate(cardPlayer1)}", true);
                    ft_design.design($"Joueur 2 : {ft_design.translate(cardPlayer2)}", true);

                    Console.WriteLine();

                    ft_compare.compare(cardPlayer1, cardPlayer2, out Stack<int> result1, out Stack<int> result2);

                    ft_addcard.revertCard(global.player1, result1);
                    ft_addcard.revertCard(global.player2, result2);
                    
                    Console.WriteLine("    _____________________________________\n");

                    ft_check.check(global.player1, $"Carte du Joueur 1 ({global.player1.Count})");
                    ft_check.check(global.player2, $"Carte du Joueur 2 ({global.player2.Count})");
                }
            }

            ft_design.design("Jeux terminé.", true);

            //int Timestamp2 = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds;
            //ft_design.design($"Temp passé : {Timestamp2 - Timestamp} MilliSecondes");
            Console.ReadKey();
        }
    }
}
