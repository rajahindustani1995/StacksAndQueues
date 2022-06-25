using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueues
{
    internal class Queues
    {
        //Use linkedlist to perform operations
        LinkedList linkedList;

        public Queues()
        {
            linkedList = new LinkedList();
        }

        public void Enqueue(int value)
        {
            //Adding node in  queue
            linkedList.AppendNode(value);
        }

        public void Dequeue()
        {
            //Delete the node from queue
            linkedList.DeleteFirstNode();
        }


        public void DisplayQueue()
        {
            //Display the nodes in queue
            Console.WriteLine("Queue:");
            linkedList.Display();
        }

        public Node Top()
        {
            //Display the topmost node in queue
            return linkedList.Head;
        }
    }
}
