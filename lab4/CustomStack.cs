namespace NccLab
{
    public class CustomStack{
         private int[] _container = new int[5];
        private int counter = -1;

        public void Push(int item)
        {
            if (counter < 4)
            {
                counter++;
                _container[counter] = item;
                System.Console.WriteLine($"Item Added to stack: {item}");
            }
            else
            {
                Console.WriteLine("Stack is full");
            }
        }

        public void Pop()
        {
            if (counter >= 0)
            {
                _container[counter] = default(int);
                counter--;
                System.Console.WriteLine("Item removed");

            }
            else
            {
                Console.WriteLine("Stack is empty");
            }
        }
    }

    
    public class CustomStackString
    {
        private string[] _container = new string[5];
        private int counter = -1;

        public void Push(string item)
        {
            if (counter < 4)
            {
                counter++;
                _container[counter] = item;
                System.Console.WriteLine($"Item Added to stack: {item}");

            }
            else
            {
                Console.WriteLine("Stack is full");
            }
        }

        public void Pop()
        {
            if (counter >= 0)
            {
                _container[counter] = default(string);
                counter--;
                System.Console.WriteLine("Item removed");

            }
            else
            {
                Console.WriteLine("Stack is empty");
            }
        }
    }

    public class CustomStackTemplated<T>
    {
       
        public T[] _container = new T[5];
        private int counter = -1;

        public void Push(T item)
        {
            if (counter < 4)
            {
                counter++;
                _container[counter] = item;
                System.Console.WriteLine($"Item Added: {item}");
            }
            else
            {
                Console.WriteLine("Stack is full");
            }
        }

        public void Pop()
        {
            if (counter >= 0)
            {
                _container[counter] = default(T);
                counter--;
                System.Console.WriteLine("Item removed");
            }
            else
            {
                Console.WriteLine("Stack is empty");
            }
        }
    }
}

