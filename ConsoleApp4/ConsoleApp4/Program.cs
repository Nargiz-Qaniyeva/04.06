using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        public static int SelectedIndex { get; private set; }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
        }
        private void picture(object sender, EventArgs e) // Buton tıklandığında
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);
            myStack.Push(6);
            myStack.Push(7);
            Console.WriteLine("https://media.moddb.com/images/members/5/4550/4549205/duck.jpg: {7}", myStack.Count);

            if (myStack.Count > 0)
            {
                Console.WriteLine(myStack.Peek()); // prints 4
                Console.WriteLine(myStack.Peek()); // prints 4
            }

            Console.Write("https://media.moddb.com/images/members/5/4550/4549205/duck.jpg: {7}", myStack.Count);

            //if (Program.SelectedIndex == 0) //a harfin seçiliyse
            //{
            //    Console.WriteLine("https://media.moddb.com/images/members/5/4550/4549205/duck.jpg");
            //}
            //else if (Combobox1.SelectedIndex == 1) // b harfin seçiliyse
            //{
            //    System.Diagnostics.Process.Start("http://yandex.com"); //verdiğin linke gitsin. 
            //}

        }
    }
}
