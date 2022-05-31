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
            
            LinkedList.LinkedListClass list = new LinkedList.LinkedListClass();
            Console.WriteLine("--------------------Welcome to data structure concept------------------------");
            list.add(56);
            list.add(30);
            list.add(70);
            list.display();
        }
    }
}

