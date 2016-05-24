using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Pr8.RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(GetFibonachi(n));
        }

       private static Dictionary<int, long> fib = new Dictionary<int, long>(); 

        private static long GetFibonachi(int n)
        {
            if (n ==0)
            {
                if (!fib.ContainsKey(0))
                {
                    fib.Add(0,0);
                }
                return fib[0];
            }
            else if(n==1)
            {
                if (!fib.ContainsKey(1))
                {
                    fib.Add(1,1);
                }
                return fib[1];
            }
            else if (n == 2)
            {
                if (!fib.ContainsKey(2))
                {
                    fib.Add(2, 1);
                }
                return fib[2];
            }
            else
            {
                if (fib.ContainsKey(n))
                {
                    return fib[n];
                }
                else
                {
                    fib.Add(n, GetFibonachi(n - 1) + GetFibonachi(n - 2));
                    return fib[n];
                }
            }
        }
    }
}
