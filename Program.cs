// See https://aka.ms/new-console-template for more information
using System;
namespace CustomTemplated
{
    class program
    {
        public static void Main()
        {
            // StackExample();
            queueExample();
        }
        public static void StackExample()
        {
            programStack<int> obj1 = new programStack<int>();

            programStack<string> obj2 = new programStack<string>();
            obj1.push(5);
            obj1.push(40);
            obj1.push(20);
            obj1.push(67);
            obj1.pop();

            obj2.push("Ranjeet");
            obj2.push("Prashant");
            obj2.push("Prazol");
            obj2.push("Parashar");
            obj2.push("Anjal");
            obj2.print();
            obj2.pop();

        }

        public static void queueExample()
        {
            programQueue<int> obj1 = new programQueue<int>();
            obj1.enqueue(40);
            obj1.enqueue(23);
            obj1.enqueue(54);
            obj1.enqueue(3);
            obj1.dequeu();
        }
    }
}
