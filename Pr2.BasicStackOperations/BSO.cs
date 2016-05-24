using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Pr2.BasicStackOperations
{
    class BSO
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine()
                .Trim()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] NumsToAddInStack = Console.ReadLine()
                .Trim()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var NumbersInStack = new Stack<int>();

            for (int i = 0; i < commands[0]; i++)
            {
                NumbersInStack.Push(NumsToAddInStack[i]);
            }

            for (int i = 0; i < commands[1]; i++)
            {
                NumbersInStack.Pop();
            }
            if (NumbersInStack.Contains(commands[2]))
            {
                Console.WriteLine("true");
            }
            else if (NumbersInStack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(NumbersInStack.Min());
            }

        }
    }
}
