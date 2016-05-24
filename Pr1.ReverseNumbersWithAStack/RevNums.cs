using System;
using System.Collections.Generic;
using System.Linq;

namespace Pr1.ReverseNumbersWithAStack
{
    public class RevNums
    {
        public static void Main()
        {
            int[] arrNums = Console.ReadLine()
                .Trim()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> sNums = new Stack<int>();

            foreach (var arrNum in arrNums)
            {
                sNums.Push(arrNum);
            }

            Console.WriteLine(string.Join(" ", sNums));
        }
    }
}
