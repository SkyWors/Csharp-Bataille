using System.Collections.Generic;

namespace Bataille
{
    internal class ft_addcard
    {
        public static void revertCard(Stack<int> actual, Stack<int> value)
        {
            Stack<int> temp = new Stack<int>();

            foreach (int i in actual)
                temp.Push(i);
            actual.Clear();

            //Randomize value
            //value.Sh



            foreach (int i in value)
                actual.Push(i);

            foreach (int i in temp)
                actual.Push(i);
        }
    }
}
