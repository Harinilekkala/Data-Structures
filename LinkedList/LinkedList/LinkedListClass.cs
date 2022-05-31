using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkedListClass
    
    {
        
        internal Node head;
        
        public void add(int id)
        {
           

            Node node = new Node(id);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {

                Node temp = head;
                while (temp.next != null)
                {
                    
                    temp = temp.next;
                }
                temp.next = node;
            }
            
            Console.WriteLine(" Adding values in linked list : {0} ", node.value);
            
        }
        public void display()
        {
            Console.WriteLine(" Displaying Stored Values in Linked list");
            Node currentNode = this.head;
            if (currentNode == null)
            {
                Console.WriteLine("Linked List Is Empty");
            }
            else
            {

                while (currentNode != null)
                {
                    
                    Console.WriteLine(currentNode.value);
                    
                    currentNode = currentNode.next;
                }
            }
        }
    }




}

