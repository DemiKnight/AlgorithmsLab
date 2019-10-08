using System;
using System.Text;

namespace L3_EX2
{
    public class IntStack
    {
        private const int MaximumSize = 10;
        private int top = 0;
        private int[] mainArray = new int[MaximumSize];

        /**
         * 0 - Fine.
         * 1 - Full.
         */    
        public short PushR(int newValue)
        {
            if (IsFull()) return 1;

            mainArray[top++] = newValue;
            return 0;
        }
        public void Push(int newValue)
        {
            if (PushR(newValue) == 1)
            {
                Console.Error.WriteLine("Stack is too full1");
            }
        
        }

        public short PopR(ref int valueToCHange)
        {
            if (IsEmpty()) return 2;
            valueToCHange = mainArray[--top];
            mainArray[top] = 0;
            return 0;
        }

        public int Pop()
        {
            int valueToCHange = 0;

            switch (PopR(ref valueToCHange))
            {
                case 0:
                    return valueToCHange;
                case 2:
                    Console.Error.WriteLine("Intstack was empty, returning 0");
                    return 0;
                default:
                    return valueToCHange;                            
            }
            
            
        }

        public short PeekR(ref int valueToChange)
        {
            if (IsEmpty()) return 2;

            valueToChange = mainArray[--top];
            
            return 0;
        }

        public int Peek()
        {
            int placeHOlderValue = 0;
            if (PeekR(ref placeHOlderValue) == 2) 
            {
                Console.Error.WriteLine("Array is empty, returning  0 ");
                return 0;
            }
            else
            {
                return placeHOlderValue;
            }
            
        }

        public bool IsEmpty()
        {
            return top == 0;
        }

        public bool IsFull()
        {
            return mainArray.Length == top;
        }
        public string Print()
        {
            StringBuilder output = new StringBuilder();
            
            for (int index = top - 1; index >= 0; index--)
                output.Append(mainArray[index] + Environment.NewLine);
            
            return output.ToString();
        }

        public int Length
        {
            get => MaximumSize;
        }


    }
}