using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Pr5.CalculateSequenceWithQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger baseNum = BigInteger.Parse(Console.ReadLine());

            Queue<BigInteger> q = new Queue<BigInteger>();
            Queue<BigInteger> s = new Queue<BigInteger>();

            s.Enqueue(baseNum);
            q.Enqueue(baseNum);

            for (int i = 0; i < 20; i++)
            {
                BigInteger curS = s.Dequeue();

                q.Enqueue(curS + 1);
                s.Enqueue(curS + 1);

                q.Enqueue(2 * curS + 1);
                s.Enqueue(2 * curS + 1);

                q.Enqueue(curS + 2);
                s.Enqueue(curS + 2);
            }

            for (int i = 0; i < 50; i++)
            {
                Console.Write($"{q.Dequeue()} ");
            }
        }
    }
}
