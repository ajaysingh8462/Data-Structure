using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Stacks_and_Queues
{
    internal class Stack_Ex
    {
        Node top;
        public Stack_Ex()
        {
            this.top = null;

        }
        public void push(int data)
        {
            Node node = new Node(data);
            if (top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to stack", data);

        }
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        public void peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("stack is emmpty");

            }
            else
            {
                Console.WriteLine("{0} is in the top stack ", top.data);
            }
        }
        public void pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("stack is empty deletion is not possible");
            }
            else
            {
                Console.WriteLine("Value popped is {0}", top.data);
                top = top.next;
            }
        }
       
    }
}
