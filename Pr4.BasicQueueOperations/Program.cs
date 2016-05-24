using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr4.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine()
                 .Trim()
                 .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int[] NumsToAddInQueue = Console.ReadLine()
                .Trim()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var NumbersInQueue = new Queue<int>();

            for (int i = 0; i < commands[0]; i++)
            {
                NumbersInQueue.Enqueue(NumsToAddInQueue[i]);
            }

            for (int i = 0; i < commands[1]; i++)
            {
                NumbersInQueue.Dequeue();
            }
            if (NumbersInQueue.Contains(commands[2]))
            {
                Console.WriteLine("true");
            }
            else if (NumbersInQueue.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(NumbersInQueue.Min());
            }
        }
    }
}
