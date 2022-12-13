using System;
using System.Collections.Generic;
using System.Linq;

namespace Bataille
{
    internal class ft_check
    {
        public static void check()
        {
            ft_design.design($"\tJoueur 1 ({global.player1.Count}) \t\t   Joueur 2 ({global.player2.Count})\n", true);
            for (int i = 0; i < 32; i++)
            {
                int value1 = -1;
                int value2 = -1;

                if (global.player1.Count > i)
                    value1 = global.player1.ElementAt(i);

                if (global.player2.Count > i)
                    value2 = global.player2.ElementAt(i);

                ft_design.design(($" {ft_design.translate(value1)} \t\t {ft_design.translate(value2)}"), true);
            }
            Console.WriteLine();
        }
    }
}
