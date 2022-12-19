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
            Stack_Ex stack = new Stack_Ex();
            stack.push(70);
            stack.push(30);
            stack.push(56);
            stack.Display();
        }
            
    }
}