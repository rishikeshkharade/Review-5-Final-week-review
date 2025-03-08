namespace Review_5__Final_week_Review_
{
    class StackImplementation
    {
        public static void StackOperations()
        {
            Stack<int> stack = new Stack<int>();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nStackOperations");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Peek");
                Console.WriteLine("4. Display stack");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your chioce");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter an integer value to push");
                        int value = Convert.ToInt32(Console.ReadLine());
                        stack.Push(value);
                        break;
                    case "2":
                        try
                        { 
                            int poppedValue = stack.Pop();
                            Console.WriteLine($"Popped value: {poppedValue}");
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine("Error: Stack is empty.");
                        }
                        break;
                    
                    case "3":
                        try
                        {
                            int top = stack.Peek();
                            Console.WriteLine($"Peek value: {stack.Peek()}");
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine("Error: Stack is empty.");
                        }
                        break;
                    
                    case "4":
                        if (stack.IsEmpty())
                        {
                            Console.WriteLine("Stack is empty.");
                        }
                        else
                        {
                            Console.WriteLine("Stack Contents:");
                            stack.Display();
                        }
                        break;

                    case "5":
                        exit = true;
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }

    class Stack<T>
    {

        private class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }

            public Node(T data)
            {

                Data = data;
                Next = null;
            }
        }

        private Node top;

        private int size;

        public Stack()
        {
            top = null;
            size = 0;
        }

        public void Push(T data)
        {
            Node newNode = new Node(data);
            newNode.Next = top;
            top = newNode;
            size++;

        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }

            T data = top.Data;
            top = top.Next;
            size--;

            return data;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return top.Data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public int Count()
        {
            return size;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return;
            }

            Node current = top;
            int position = 1;

            while (current != null)
            {
                Console.WriteLine($"{position}. {current.Data}");
                current = current.Next;
                position++;
            }
        }
    }
}