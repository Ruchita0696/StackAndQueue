namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stacks stack = new Stacks();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
        }
    }
}