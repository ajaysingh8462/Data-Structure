using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Linked_List
{
    public class Linked_list
    {
        node head;
        public void Addnote(int data)
        {
            node Node = new node(data);
            if (head == null)
            {
                head = Node;

            }
            else
            {
                node temp = head;

                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = Node;
            }
            Console.WriteLine("{0} ", Node.data);
        }
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            Console.WriteLine("List contains");
            node tempnode = head;
            while (tempnode != null)
            {
                Console.WriteLine(tempnode.data + " ");
                tempnode = tempnode.next;
            }
            Console.WriteLine("\n");
        }
        public void Addrevers(int data)
        {
            node Node = new node(data);
            if (head == null)
            {
                head = Node;

            }
            else
            {
                node temp = head;
                head = Node;
                head.next = temp;
            }

        }
        public node InsertAtMidil(int position, int data)
        {
            node newestNode = new node(data);
            if (this.head == null)
            {
                return newestNode;
            }
            if (position == 0)
            {
                newestNode.next = this.head;
                this.head = newestNode;
                return this.head;
            }
            node prev = null;
            node current = this.head;
            int count = 0;
            while (current != null && count < position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            newestNode.next = prev.next;
            prev.next = newestNode;
            return this.head;
        }
        public void DeleteFirst()
        {
            if (this.head == null)
            {
                Console.WriteLine("Linkedlist is empty");
            }
            this.head = this.head.next;

        }
        public void DeleteLast()
        {
            if (head == null)
            {
                Console.WriteLine("Linkedlist is empty");
            }
            if (head.next == null)
            {
                head = null;
            }
            node NewNode = head;
            while (NewNode.next.next != null)
            {
                NewNode = NewNode.next;
            }
            NewNode.next = null;
        }
        public int Search(int value)
        {
            node Node = this.head;
            if (Node == null)
                return -1;
            int count = 0;
            while (Node != null)
            {
                if (Node.data == value)
                {
                    return count;
                }
                Node = Node.next;
                count++;
            }
            return count;
        }

    }
}
