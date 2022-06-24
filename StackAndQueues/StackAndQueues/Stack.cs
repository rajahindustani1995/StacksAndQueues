using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueues
{
    internal class Stack
    {
        LinkedList linkedList;

        public Stack()
        {

            linkedList = new LinkedList();
        }

        public void Push(int value)
        {
            //Adding new node in stack 
            linkedList.AddNode(value);
        }

        public void DisplayStack()
        {
            Console.WriteLine("Stack:");
            linkedList.Display();
        }

        public Node Top()
        {
            //Return top value of stack
            return linkedList.Head;
        }
    }
}
