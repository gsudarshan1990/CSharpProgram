using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListAndListExamples
{
    
    class StackExample
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            Console.WriteLine();
            Console.WriteLine();

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            int[] arr1 = new int[] { 2, 4, 6, 8, 10 };
            Stack<int> stack1 = new Stack<int>(arr1);

            foreach (var item in stack1)
            {
                Console.WriteLine(item);
            }

           
            Console.WriteLine(stack.Count);
            Console.WriteLine(stack1.Count);

            while(stack.Count > 0) 
            {
                Console.WriteLine(stack.Pop());
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(stack.Count);

            Console.WriteLine();
            Console.WriteLine();
            if (stack1.Count > 0)
            {
                Console.WriteLine(stack1.Peek());
            }


            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(stack1.Contains(2));
        }
    }
}
