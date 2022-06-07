namespace CustomTemplated
{
    public class programStack<T>
    {
        private T[] s1 = new T[5];
        private int counter= -1;

        public void push(T item)
        {
            if(counter<4){
                counter++;
                s1[counter]=item;
            }
            else{
                Console.WriteLine("Overflow");
            }
        }

        public void pop()
        {
            if(counter>=0)
            {
                Console.WriteLine($"Popped item is {s1[counter]}");
                s1[counter]=default(T);
                counter--;
            }
            else{
                Console.WriteLine("UnderFlow.");
            }
        }

         public void print()
        {
            Console.WriteLine("The element of stack are =");
            for(int c=counter; c>=0;c--)
            {
                Console.WriteLine(s1[c]);
                Console.WriteLine("");
            }
        }
    }
}