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
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to Linked List Operations");
                Console.WriteLine(" 1. Add LinkedList\n 2. Add data in reverse order\n 3. Insert data at particular position\n 4. Delete First Node\n 5. Delete Last Node ");
                Console.WriteLine("Enter above mention option");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        ls.Addnote(56);
                        ls.Addnote(30);
                        ls.Addnote(70);
                        ls.Display();
                        break;

                    case 2:
                        ls.Addrevers(70);
                        ls.Addrevers(30);
                        ls.Addrevers(56);
                        ls.Display();
                        break;
                    case 3:
                        ls.Addnote(56);
                        ls.Addnote(70);
                        ls.InsertAtMidil(1, 30);
                        ls.Display();
                        break;
                    case 4:
                        ls.Addnote(56);
                        ls.Addnote(30);
                        ls.Addnote(70);
                        ls.DeleteFirst();
                        ls.Display();
                        break;
                    case 5:
                        ls.Addnote(56);
                        ls.Addnote(30);
                        ls.Addnote(70);
                        ls.DeleteLast();
                        ls.Display();

                        break;
                    case 6:
                        flag = false;
                        Console.WriteLine("Try Again");
                        break;
                }
            }
        }
    }
}