using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            if (valuePlayer1 == valuePlayer2)
            {
                result1.Push(valuePlayer1);
                result1.Push(valuePlayer2);
            }
            else
            {
                if (valuePlayer1 > valuePlayer2)
                {
                    foreach (int value in temp)
                        result1.Push(value);
                }
                else
                {
                    foreach (int value in temp)
                        result2.Push(value);
                }
            }
        }
    }
}
