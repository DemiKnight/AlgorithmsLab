using System;

namespace TestingArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new[] {1, 5, 21, 140, 2, 2, 10023};

            for (int targetIndex = 0; targetIndex < array.Length; targetIndex++)
            {
                int highIndexInRange = -1;

                for (int rangeSelectd = targetIndex+1; rangeSelectd < array.Length; rangeSelectd++)
                {
                    if (array[rangeSelectd] > array[targetIndex])
                    {
                        highIndexInRange = rangeSelectd;
                    }
                }

                if (highIndexInRange != -1)
                {
                    int tempVal = array[targetIndex];
                    array[targetIndex] = array[highIndexInRange];
                    array[highIndexInRange] = tempVal;
                }

            }

            foreach (var VARIABLE in array)
                Console.WriteLine(VARIABLE + ", ");

//            ArrayStuff array = new ArrayStuff();

//            array.DisplayItems();

//            array.sort();

//            array.DisplayItems();

//            array.insertSort(2);

//            Console.WriteLine("Hello World!");
        }
    }
}