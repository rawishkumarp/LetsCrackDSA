using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsCrackDSA
{
    internal class MinStack
    {

        private Stack<int> regularStack;
        private Stack<int> minStack;
        public MinStack()
        {
            regularStack = new Stack<int>();
            minStack = new Stack<int>();
        }
         
        public void Push(int val) // Changed from private static to public
        {
            regularStack.Push(val);

            val = System.Math.Min(val, minStack.Count == 0 ? val : minStack.Peek()); // for max
            minStack.Push(val);
        }

        public void Pop()
        {
            regularStack.Pop();
            minStack.Pop();
        }

        public int Peek()
        {
            return regularStack.Peek();
        }

        public int GetMin()
        {
            return minStack.Peek();
        }
    }
}
