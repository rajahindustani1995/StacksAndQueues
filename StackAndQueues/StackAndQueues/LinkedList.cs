using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueues
{
    internal class LinkedList
    {
        public Node Head;
        public Node Tail;


        public LinkedList()
        {
            Head = null;
            Tail = null;
        }

        public void AddNode(int value)    //56 30 70
        {
            Node node = new Node(value);
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.next = Head;
                Head = node;
            }

        }

        public void AppendNode(Node node)           // 70 30 56
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.next = node;
                Tail = node;
            }
        }


        public void InsertNode(int value, int Previousvalue)
        {
            Node newNode = new Node(value);
            if (Head == null & Tail == null)
            {
                Head = newNode;
            }
            else
            {
                Node temp = Head;
                //Checking until temp variable data equal to the previous value of value to be added
                while (temp.data != Previousvalue)
                {
                    temp = temp.next;
                }
                newNode.next = temp.next;
                temp.next = newNode;
            }
        }

        public void DeleteFirstNode()
        {
            if (Head == null & Tail == null)
            {
                Console.WriteLine("Nothing to delete list is empty");
            }
            Node temp = Head;
            
            Head = Head.next;

            Console.WriteLine("Removed from linkedlist :" + temp.data);
        }

        public void DeleteLastNode()
        {

            if (Head == null & Tail == null)
            {
                Console.WriteLine("Nothing to delete list is empty");

            }

            Node temp = Head;
            
            while (temp.next.next != null)
            {

                temp = temp.next;
            }
           
            temp.next = null;
        }
        internal void Search(int value)
        {
            Node tempHead = Head;

            int position = 1;

            if (Head == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            while (tempHead.next != null)
            {
                
                if (tempHead.data == value)
                {
                    Console.WriteLine("Value " + value + " is found at position " + position);
                }
                tempHead = tempHead.next;
                position++;
            }
        }

        internal void InsertNewNode(int value, int data)  //int value - the node after which new node should added
                                                          //int data  - the new data or new node
        {
            Node tempHead = Head;
            Node newNode = new Node(data);

            if (Head == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }

            while (tempHead.next != null)
            {
                
                if (tempHead.data == value)
                {
                    Console.WriteLine(newNode.data + " is inserted after " + tempHead.data);
                    newNode.next = tempHead.next;
                    tempHead.next = newNode;
                    break;
                }
                tempHead = tempHead.next;
            }
        }

        internal void DeleteNode(int value)
        {
            Node tempHead = Head;

            if (Head == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            
            while (tempHead.next != null)
            {
                
                if (tempHead.next.data == value)
                {
                    tempHead.next = tempHead.next.next;
                    Console.WriteLine("The value " + value + " is deleted from the list");
                }
                tempHead = tempHead.next;
            }
        }

        
        internal void ListSize()
        {
            
            int size = 0;

            Node tempHead = Head;
            while (tempHead != null)
            {
                tempHead = tempHead.next;
                size++;
            }
            Console.WriteLine("Linked List size is : " + size);
        }

        internal void OrderedList(int data)
        {
            Node newNode = new Node(data);

            Node tempHead = Head;

            
            if (Head == null || Head.data >= newNode.data)
            {
                
                newNode.next = Head;

                
                Head = newNode;
            }

            else
            {
                
                while (tempHead.next != null && tempHead.next.data < newNode.data)
                {
                    tempHead = tempHead.next;
                }

                //then newNode will be inserted after tempHead node
                newNode.next = tempHead.next;
                tempHead.next = newNode;
            }
            Console.WriteLine(newNode.data + " is inserted in the Linked List");
        }



        internal void Display()
        {
             Node temp = Head;
             if (temp == null)
                Console.WriteLine("Linked List is empty");
             else
                Console.WriteLine("Linked List");
            while (temp != null)
            {
                Console.Write(temp.data);
                if (temp.data != null)
                    Console.Write("->");
                temp = temp.next;
            }
        }
    }
}
