using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Bataille
{
    internal class ft_distrib
    {
        public static void distrib(Stack<int> player)
        {
            Random rnd = new Random();

            int a = 0;
            while (a < 16)
            {
                int randomCard = rnd.Next(32);
                if (!(global.randomSlot.Contains(randomCard)))
                {
                    player.Push(global.card[randomCard]);
                    global.randomSlot[randomCard] = randomCard;
                    a++;
                }
            }

            Console.WriteLine();
        }
    }
}
