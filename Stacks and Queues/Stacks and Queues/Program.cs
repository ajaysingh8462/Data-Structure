using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to stacks and queues");
                Console.WriteLine("1. Stacks"+"\n" + "2.Queues" );
                Console.WriteLine("Enter The Above Mention Option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Stack_Ex stack = new Stack_Ex();
                        Console.WriteLine("Enter Any key to Push values");
                        Console.ReadKey();
                        Console.WriteLine();
                        stack.push(70);
                        stack.push(30);
                        stack.push(56);
                        stack.Display();
                        Console.WriteLine("Enter Any key to Peek value");
                        Console.ReadKey();
                        Console.WriteLine();
                        stack.peek();
                        stack.Display();
                        Console.WriteLine("Enter Any key to Pop value");
                        Console.ReadKey();
                        Console.WriteLine();
                        stack.pop();
                        stack.Display();
                        Console.WriteLine("Enter Any key to Peek Next value");
                        Console.ReadKey();
                        Console.WriteLine();
                        stack.peek();
                        stack.Display();
                        Console.WriteLine("Enter Any key to Pop Next value");
                        Console.ReadKey();
                        Console.WriteLine();
                        stack.pop();
                        stack.Display();
                        Console.WriteLine("Enter Any key to Peek Next value ");
                        Console.ReadKey();
                        Console.WriteLine();
                        stack.peek();
                        stack.Display();
                        Console.WriteLine("Enter Any key to Pop Next value");
                        Console.ReadKey();
                        Console.WriteLine();
                        stack.pop();
                        stack.Display();
                        break;
                    case 2:
                        Queue_Ex queue = new Queue_Ex();
                        queue.Enqueue(56);
                        queue.Enqueue(30);
                        queue.Enqueue(70);
                        queue.Display();
                        break;
                    default:
                        Console.WriteLine("Enter Valid option");
                        break;
                }
                

            }
                        
        }

    }
}