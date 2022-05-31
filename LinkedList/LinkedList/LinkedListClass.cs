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
        public void swapValues(int id)
        {
            Console.WriteLine(" Replacing position before of values");
            Node node = new Node(id);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                node.next = this.head;
                head = node;
            }
            //  Console.WriteLine("After positioning of values :" + head);
            Console.WriteLine("Added :" + node.value);
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
        public void Append(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node position = head;
                while (position.next != null)
                {
                    position = position.next;
                }
                position.next = node;
            }
            Console.WriteLine("{0} Values Appended in linkedlist", node.value);
        }
        public void insertNodeInbetween(int position, int data)
        {
            int check = 1;
            Node newNode = new Node(data);
            if (position == 1)
            {
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                Node temp = head;
                while (position != check)
                {
                    check++;
                    if (position == check)
                    {
                        newNode.next = temp.next;
                        temp.next = newNode;
                        break;
                    }

                    temp = temp.next;
                }
            }
        }

        public void removeFirst()
        {
            if (this.head == null)
            {
                Console.WriteLine("List Empty");
            }
            this.head = this.head.next;
        }
        public void removeLastValue()
        {
            Node temp = head;
            if (this.head == null)
            {
                Console.WriteLine("List Empty");
            }
            if (temp.next == null)
            {
                this.head = null;
            }
            else
            {
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                temp.next = null;
            }
        }

    }


}

