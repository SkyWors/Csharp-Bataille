using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bataille
{
    internal class ft_addcard
    {
        public static void addcard(Stack<int> actual, Stack<int> value)
        {
            Stack<int> temp = new Stack<int>();

            foreach (int i in actual)
                temp.Push(i);
            actual.Clear();

            foreach (int i in value)
                actual.Push(i);

            foreach (int i in temp)
                actual.Push(i);
        }
    }
}
