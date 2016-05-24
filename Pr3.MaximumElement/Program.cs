using System;
using System.Collections.Generic;
using System.Linq;

namespace StacksAndQueues
{
    class Program
    {
        static void Main()
        {
            ulong numbEntries = ulong.Parse(Console.ReadLine());

            var numStack = new Stack<ulong>();
            ulong maxVal = 0;

            for (ulong i = 0; i < numbEntries; i++)
            {
                ulong[] ulLine = Console.ReadLine()
                    .Trim()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(ulong.Parse)
                    .ToArray();

                switch (ulLine[0])
                {
                    case 1:
                        //ulong bNumber = ulLine[1];
                        numStack.Push(ulLine[1]);
                        if (ulLine[1] > maxVal)
                        {
                            maxVal = ulLine[1];
                        }
                        break;

                    case 2:
                        var elem = numStack.Pop();
                        if (numStack.Count > 0 && elem == maxVal)
                        {
                            maxVal = numStack.Max();
                        }
                        else if (numStack.Count == 0 && elem == maxVal)
                        {
                            maxVal = 0;
                        }
                        break;

                    case 3:
                        Console.WriteLine(maxVal);
                        break;
                }
            }
        }
    }
}
