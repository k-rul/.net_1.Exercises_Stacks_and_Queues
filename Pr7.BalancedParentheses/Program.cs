using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr7.BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string seq = Console.ReadLine().Replace(" ", "");

            var stack = new Stack<string>();
            var queue = new Queue<string>();

            if (seq.Length <= 0 || seq.Length % 2 != 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                for (int i = 0; i < seq.Length; i++)
                {
                    if ((seq[i] == '{') || (seq[i] == '[') || (seq[i] == '('))
                    {
                        queue.Enqueue(seq[i].ToString());
                    }
                    else if ((seq[i] == '}') || (seq[i] == ']') || (seq[i] == ')'))
                    {
                        if (queue.Count <= stack.Count)
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        stack.Push(seq[i].ToString());
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }

                var isOk = true;
                if (queue.Count != stack.Count)
                {
                    Console.WriteLine("NO");
                    return;
                }
                for (int i = 0; i < seq.Length / 2; i++)
                {
                    if ((queue.Peek() == "{" && stack.Peek() == "}") || (queue.Peek() == "[" && stack.Peek() == "]") || (queue.Peek() == "(" && stack.Peek() == ")"))
                    {
                        queue.Dequeue();
                        stack.Pop();
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        isOk = false;
                        break;
                    }
                }
                if (isOk)
                {
                    Console.WriteLine("YES");
                }
            }
        }
    }
}
