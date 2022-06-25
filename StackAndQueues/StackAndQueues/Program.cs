namespace StackAndQueues
{
    class Program
    {
        public static void Main (String [] args)
        {
            Queues queue = new Queues();
            Node node1 = new Node(56);
            Node node2 = new Node(30);
            Node node3 = new Node(70);

            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.DisplayQueue();
            queue.Top();

            queue.Dequeue();
            queue.DisplayQueue();

        }
    }
}