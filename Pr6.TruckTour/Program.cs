using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Pr6.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int pumpsCount = int.Parse(Console.ReadLine());

            var pumps = new Queue<BigInteger[]>();

            for (int i = 0; i < pumpsCount; i++)
            {
                pumps.Enqueue(Console.ReadLine()
                    .Trim()
                    .Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(BigInteger.Parse)
                    .ToArray());
            }

            for (int i = 0; i < pumpsCount; i++)
            {
                if (IsInitialPoint(pumps, pumpsCount))
                {
                    Console.WriteLine(i);
                    break;
                }
                var temp = pumps.Dequeue();
                pumps.Enqueue(temp);
            }

        }

        private static bool IsInitialPoint(Queue<BigInteger[]> pumps, int pumpsCount)
        {
            BigInteger fueu = 0;
            var isIt = true;

            for (int i = 0; i < pumpsCount; i++)
            {
                var curPump = pumps.Dequeue();
                fueu += curPump[0];

                if (fueu - curPump[1] >= 0)
                {
                    fueu -= curPump[1];
                }
                else
                {
                    isIt = false;
                }
                pumps.Enqueue(curPump);
            }

            return isIt;
        }
    }
}
