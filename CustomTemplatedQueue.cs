namespace CustomTemplated
{
    public class programQueue<T>
    {
        public T[] t1 = new T[5];
        public int rear = -1;
        public int front = -1;

        public void enqueue(T item)
        {
            if(front == -1 && rear == -1) 
            {
                
                rear++;
                t1[rear] =  item;
            }
            else if(front != rear)
            {
                if(rear<5)
                {
                    rear++;
                    t1[rear]=item;
                }

            }
            else
            {
                Console.WriteLine("Queue Overflow.");
            }
        }

        public void dequeu()
        {
            if(front!=rear)
            {
                front++;
                Console.WriteLine($"Deqeued item is : {t1[front]}");
                t1[front] = default(T);
                front++;
            }
            else{
                Console.WriteLine("Queue Underflow");
            }
        }

        public void print()
        {
            Console.WriteLine("Items in the Queue:");
            for(int i = 0; i<=rear; i++)
            {
                Console.WriteLine(t1[i]);
            }
        }
    }
}