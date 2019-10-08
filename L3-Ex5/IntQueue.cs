using System.Text;

namespace L3_Ex5
{
    public class IntQueue
    {
        private readonly int maxsize = 10;
        private int[] store;
        private int head = 0;
        private int tail = 0;
        private int numItems = 0;
        
        public IntQueue()
        {
            store = new int[maxsize];
        }

        public IntQueue(int size)
        {
            maxsize = size;
            store = new int[maxsize];
        }

        public void Enqueue(int value)
        {
            store[tail++] = value;
            numItems++;
            
        }

        public int Dequeue()
        {
            numItems--;    
            int temp = store[head];
            store[head++] = 0;
            return temp;
        }

        public int Peek()
        {
            return store[head];
        }

        public bool IsEmpty()
        {
            return head == tail;
        }

        public bool IsFull()
        {
            return head == 0 && tail == maxsize;
        }

        public int NumOfItems
        {
            get => numItems;
        }

        public override string ToString()
        {
            StringBuilder newString = new StringBuilder();

            foreach (int select in store)
            {
                newString.Append(" : " + select + " : ");
            }
            return newString.ToString();
        }
    }
}    