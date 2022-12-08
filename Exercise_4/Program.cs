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
        public int pop()
        {
            if (top == -1)
            {
                Console.Write("Stack Underflow");
                return -1;
            }
        }   
    }
}