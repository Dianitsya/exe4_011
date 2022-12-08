using System;


namespace Exercise_4
{
    class Stack
    {
        public string[] tasya;
        private int top;
        public int max;
        public Stack()
        {
            tasya = new string[30];
            top = -1;
            max = 30;
        }
        public void push()
        {
            if (top == max - 1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            else
            {
                top++;
                Console.Write(("Pushed element is: "));
                tasya[top] = Console.ReadLine();
            }
        }
        public void pop()
        {
            if (top == -1)
            {
                Console.Write("Stack Underflow");
                return -1;
            }
            else
            {
                Console.Write("Poped element is: " + tasya[top]);
                top--;
                return top;
            }
        }
        public void display()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + tasya[i]);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n***Stack Menu***\n");
                Console.WriteLine("1. Push ");
                Console.WriteLine("2. Pop ");
                Console.WriteLine("3. Display ");
                Console.WriteLine("4. Exit ");
                Console.Write("\nEnter your choice: ");
                string sInput = Console.ReadLine();
                char ch = Convert.ToChar(sInput == "" ? "0" : sInput);
                switch (ch)
                {
                    case '1':
                        s.push();
                        break;
                    case '2':
                        s.pop();
                        break;
                    case '3':
                        Sz.display();
                        break;
                    case '4':
                        return;
                    default:
                        Console.WriteLine("\nInvalid Choice");
                        break;
                }
            }
        }
    }
}