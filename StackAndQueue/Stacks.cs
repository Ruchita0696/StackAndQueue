using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class Stacks
    {
        public Node top;
        public Stacks()
        {
            this.top = null;
        }
        public void Push(int data)
        {
            Node newNode = new Node(data);
            if (top == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = top;
            }
            top = newNode;
            Console.WriteLine("{0} pushed to stack", data);
        
        }
        public void Display()
        {
            int i = 1;
            int Size = 0;
            Node temp = top;

            Console.WriteLine();
            if (temp == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            while (temp != null)
            {
                Console.WriteLine($"Element {i} in Stack is : " + temp.data);
                temp = temp.next;
                Size = i;
                i++;
            }
            Console.WriteLine("\nTotal Elements in Stack is : " + Size);
        }
    }
}
