using System;
using System.Collections.Generic;

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
                ft_design.design(($"  {ft_design.translate(value)}"), true);
                i++;
            }
            Console.WriteLine();
        }
    }
}
