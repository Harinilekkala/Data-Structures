// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure
{
    internal class mainClass
    {
        public static void Main(string[] args)
        {
            dataStructure.mainClass run = new dataStructure.mainClass();
            LinkedList.LinkedListClass list = new LinkedList.LinkedListClass();
            Console.WriteLine("1. to create simple linked list");
            Console.WriteLine("2. to swap position");
            Console.WriteLine("3. to append");
            Console.WriteLine("4. insert value between");
            Console.WriteLine("5. Remove First Value");
            Console.WriteLine("6. Remove Last VAlue");
            int select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1:
                    list.add(56);
                    list.add(30);
                    list.add(70);
                    list.display();
                    break;
                case 2:
                    list.swapValues(56);
                    list.swapValues(30);
                    list.swapValues(70);
                    list.display();
                    break;
                case 3:
                    list.add(56);
                    list.add(30);
                    list.add(70);
                    list.display();
                    list.Append(select);
                    break;

                case 4:
                    list.add(56);
                    list.add(70);
                    Console.WriteLine("Before insert");
                    list.display();
                    Console.WriteLine("After insert");
                    list.insertNodeInbetween(2, 30);
                    list.display();
                    break;

                case 5:
                    list.add(56);
                    list.add(30);
                    list.add(70);
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Values Present in List");
                    list.display();
                    list.removeFirst();
                    Console.WriteLine("After Remove First Value");
                    list.display();
                    break;

                case 6:
                    list.add(56);
                    list.add(30);
                    list.add(70);
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Values Present in List");
                    list.display();
                    list.removeLastValue();
                    Console.WriteLine("After Remove Last Value");
                    list.display();
                    break;
            }


        }
    }
}

