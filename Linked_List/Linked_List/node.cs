using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    public class node
    {
        public int data;
        public node next;
        public node(int data)
        {
            this.data = data;
            next = null;
        }
    }
}
