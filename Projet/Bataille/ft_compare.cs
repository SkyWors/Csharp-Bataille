using System.Collections.Generic;

namespace Bataille
{
    internal class ft_compare
    {
        public static void compare(int valuePlayer1, int valuePlayer2, out Stack<int> result1, out Stack<int> result2)
        {
            result1 = new Stack<int>();
            result2 = new Stack<int>();

            Stack<int> temp = new Stack<int>();

            temp.Push(valuePlayer1);
            temp.Push(valuePlayer2);

            if ((valuePlayer1%8) == (valuePlayer2%8))
            {
                result1.Push(valuePlayer1);
                result2.Push(valuePlayer2);
                ft_design.design(">>  Egalité", true);
            }
            else
            {
                if ((valuePlayer1%8) > (valuePlayer2%8))
                {
                    foreach (int value in temp)
                        result1.Push(value);
                    ft_design.design(">>  Le Joueur 1 a gagné le tour !", true);
                }
                else
                {
                    foreach (int value in temp)
                        result2.Push(value);
                    ft_design.design(">>  Le Joueur 2 a gagné le tour !", true);
                }
            }
        }
    }
}
