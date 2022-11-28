using System;
using System.Collections.Generic;


namespace Bataille
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Stack<int> player1 = new Stack<int>();
            Stack<int> player2 = new Stack<int>();

            ft_createCard.createCard();

            ft_design.design("Couper ou ? ", false);
            int slot = Convert.ToInt32(Console.ReadLine());

            ft_distrib.distrib(player1, slot);
            ft_distrib.distrib(player2, 0);

            ft_check.check(player1, "Player1");
            ft_check.check(player2, "Player2");

            ft_design.design("Combien de tours ? ", false);
            int tours = Convert.ToInt32(Console.ReadLine());

            //int Timestamp = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;

            for (int i = 0; i < tours; i++)
            {
                int count1 = player1.Count;
                int count2 = player2.Count;
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
                    int cardPlayer1 = player1.Pop();
                    int cardPlayer2 = player2.Pop();

                    ft_design.design($"Joueur 1 : {cardPlayer1}", true);
                    ft_design.design($"Joueur 2 : {cardPlayer2}", true);

                    ft_compare.compare(cardPlayer1, cardPlayer2, out Stack<int> result1, out Stack<int> result2);

                    ft_addcard.addcard(player1, result1);
                    ft_addcard.addcard(player2, result2);

                    ft_check.check(player1, "Player1");
                    ft_check.check(player2, "Player2");
                }
            }

            ft_design.design("Jeux terminé.", true);

            //int Timestamp2 = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds;
            //ft_design.design($"Temp passé : {Timestamp2 - Timestamp} MilliSecondes");
            Console.ReadKey();
        }
    }
}
