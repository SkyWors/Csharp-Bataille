using System;
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
            Stack<int> tempo = new Stack<int>();

            Random rnd = new Random();

            if (value.Count > 1)
            {
                int randomard = rnd.Next(3);
                if (randomard == 0)
                {
                    tempo.Push(value.Peek());
                    value.Pop();

                    tempo.Push(value.Peek());
                    value.Pop();
                }

                foreach (int i in tempo)
                    actual.Push(i);
            }

            foreach (int i in value)
                actual.Push(i);

            foreach (int i in temp)
                actual.Push(i);
        }
    }
}
