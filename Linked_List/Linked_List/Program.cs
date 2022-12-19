using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    class Program
    {
        public static void Main(string[] args)
        {
            Linked_list ls = new Linked_list();
            ls.Addnote(56);
            ls.Addnote(30);
            ls.Addnote(70);
            ls.Display();

        }
    }
}