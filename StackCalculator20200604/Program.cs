using System;
using System.Collections.Generic;

namespace StackCalculator20200604
{
    class Program
    {
        static Stack<decimal> stack = new Stack<decimal>();
        //decimal number = decimal.Zero;

        static void Push(string[] splits)
        {
            if (splits.Length > 1)
            {
                var number = decimal.Parse(splits[1]);
                stack.Push(number);
            }
        }

        static void Print()
        {
            Console.WriteLine(stack.Peek().ToString());
        }

        static void Main(string[] args)
        {
            decimal number = decimal.Zero;
            while (true)
            {
                Console.WriteLine("ENTER COMMAND: ");
                var command = Console.ReadLine();
                var splits = command.Split(' ');

                if (splits.Length > 0)
                {

                    switch (splits[0])
                    {

                        case "ADD":
                            stack.Push(stack.Pop() + stack.Pop());
                            break;

                        case "SUBTRACT":
                            number = stack.Pop();
                            stack.Push(stack.Pop() - number);
                            break;
                        case "MULTIPLY":
                            stack.Push(stack.Pop() * stack.Pop());
                            break;

                        case "DIVIDE":
                            number = stack.Pop();
                            stack.Push(stack.Pop() / number);
                            break;

                        case "PUSH":
                            Push(splits);
                            break;
                        case "PRINT":
                            Print();
                            break;
                        case "EXIT":
                            return; // exit program
                        default:
                            Console.WriteLine("Unknown command");
                            break;
                    }
                }
            }
        }
    }
}
