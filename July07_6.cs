using System;

    //interface Stack with methods Push(), Pop() and property length.
    interface StackA 
    {
        void Push(int v); 
        int Pop(); 
        int Length { get; }  
    }

    // Creating user defined exceptions StackFullException and StackEmptyException
    public class StackFullException : Exception 
    {
        public StackFullException()
            : base("Stack Full") 
        {
        }
    }

   public class StackEmptyException : Exception
    {
        public StackEmptyException()
            : base("Stack Empty")
        {
        }
    }

    // Class Stack implementing StackA interface
    public class Stack  : StackA 
    {

        // array to implement stack data structure
        private int[] a = new int[10];
        public int top = 0;

        public void Push(int v) 
        {

            if (top == 10)
			{
                // User defined exception
                throw new StackFullException();
			}

            a[top] = v;
            top++;
        }

        public int Pop()
        {
		
            if (top == 0)
            
                // User defined exception
                throw new StackEmptyException(); 
			
            top--;
            return a[top];
        }

        public int Length
        {
            get
            {
                return top;
            }
        }
    }

    public class MainStack
    {
        public static void Main()
        {
            Stack s = new Stack();
            s.Push(20);

            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Length);
			
            
			s.top=10;
			s.Push(20);
        
    }
}

/*
OUTPUT1:
20
0
Unhandled exception. StackFullException: Stack Full
OUTPUT2:
20
0
Unhandled exception. StackEmptyException: Stack Empty
*/