using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueues
{
    internal class Stack
    {
        public Node top;
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

        public Node Top()
        {
            return linkedList.Head;
        }

        public void PeekNode()
        {
            if (linkedList == null)
                return;
        }
        public void PopNode()
        {
            //Delete Node from stack
            linkedList.DeleteFirstNode();
        }

        public void DisplayStack()
        {
            Console.WriteLine("Stack:");
            linkedList.Display();
        }
    }
}
