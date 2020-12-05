using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StructureTasks
{
    public class Stack : IEnumerable<int>
    {
        private int size;
        private int[] stackArray;
        private int top = -1;

        public int Count { get { return top + 1; } }

        public Stack(int size)
        {
            this.size = size;
            stackArray = new int[size];
        }

        public void Push(int item)
        {
            if ((top + 1) == size)
            {
                Array.Resize(ref stackArray, ++size);
            }

            top++;
            stackArray[top] = item;
        }

        public int Pop()
        {
            int value = stackArray[top];
            top--;
            return value;
        }

        public int Peek()
        {
            return stackArray[top];
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i <= top; i++)
            {
                yield return stackArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
