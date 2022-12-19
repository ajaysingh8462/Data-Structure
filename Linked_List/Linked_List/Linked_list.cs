﻿using System;
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
    }
}
