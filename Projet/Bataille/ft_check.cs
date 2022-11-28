using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bataille
{
    internal class ft_check
    {
        public static void check(Stack<int> pile, string title)
        {
            ft_design.design(title, true);
            int i = 1;
            foreach (int value in pile)
            {
                Console.Write($"C{i} : {value}   ");
                i++;
            }
            Console.WriteLine();
        }
        public static void checkCard(int[] card, int[] color)
        {
            for (int i = 0; i < card.Length; i++)
            {
                ft_design.design($"C{i} : {ft_design.translate(card[i], "card")} {ft_design.translate(color[i], "color")}", true);
            }
            Console.WriteLine();
        }
        //public static void cardColor()
        //{
        //    for (int i = 0; i < color.Length; i++)
        //    {
        //        ft_design.design($"C{i} : {ft_design.translate(color[i], "color")}", false);
        //    }
        //    Console.WriteLine();
        //}
    }
}
