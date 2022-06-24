namespace StackAndQueues
{
    class Program
    {
        public static void Main (String [] args)
        {
            Stack stack = new Stack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.DisplayStack();
            stack.Top();
        }
    }
}