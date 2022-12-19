using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Stacks_and_Queues
{
    internal class Queue_Ex
    {
        Node rear;
        Node front;
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (front == null)
            {
                rear = node;
                front = rear;
            }
            else
            {
                rear.next = node;
                rear = rear.next;
            }
        }
        public void Display()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty");

            }
            Node temp = front;
            while (temp != null)
            {
                Console.WriteLine("|" + temp.data + "|");
                temp = temp.next;
            }
        }
    }
}
