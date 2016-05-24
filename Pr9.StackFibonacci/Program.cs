using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Pr9.StackFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<long> fib = new Stack<long>();
            fib.Push(1);
            fib.Push(1);

            for (int i = 3; i <= n; i++)
            {
                long n1 = fib.Pop();
                long n2 = fib.Peek();

                long n3 = n1 + n2;
                fib.Push(n1);
                fib.Push(n3);
            }
            Console.WriteLine(fib.Peek());
        }
    }
}
