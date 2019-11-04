using System;
using System.Linq;
using System.Security;

namespace TestingArea
{
    public class ArrayStuff
    {
        private int[] array;

        public ArrayStuff()
        {
            array = new[] {5,2,100,4/*,12*/};
        }
        
        public void sort()
        {

            for (uint indexSel = 0; //This will act as the offset. 
                indexSel < array.Length ;indexSel++) //Index of item to replace.
            {
                uint newPosition = indexSel;
                
//                Console.WriteLine("Target Val {0}", array[indexSel]);
//                Console.WriteLine("Val {0}", array[indexSel]);
                
                
                for (
                    uint indexSwap = indexSel+1; //The beginning of the range, between this and the end of the array. +1 to compare the next value.
                    indexSwap < array.Length;  //Sets the end of the range for the end fo the array.
                    indexSwap++)
                {
                    
//                    Console.WriteLine("Main Target is {0} which is greater than {1}, {2}", array[indexSel], array[indexSwap], array[indexSel] > array[indexSwap]);
                    
                    
                    //todo Issue is with this statement here 
                    if (array[indexSel] //The selected value to compare against 
                        > array[indexSwap] || array[newPosition] > array[indexSwap] ) //if is grater than. ...
                    {
                        Console.WriteLine("Max val changed to {0}", array[newPosition].ToString());
                        newPosition = indexSwap; //Mark position
//                        maxVal = array[indexSwap];
                    }
                }
                //With highest value found in range, replace the two.
                int tempVal = 0;

                DisplayItems();
                
                tempVal = array[indexSel];
                array[indexSel] = array[newPosition];
                array[newPosition] = tempVal;
                
                DisplayItems();
//                Console.WriteLine(array[newPosition]);
                
            }

            
        }

        public void DisplayItems()
        {
            foreach (int selectedInt in array)
            {
                Console.Write("{0}{1}", selectedInt.ToString(),(selectedInt==array.Last() ? "\n" : ", "));
            }
            
            
        }

        public void insertSort(int newIntInput)
        {
            int[] newArray = new int[array.Length+1];

            newArray[0] = array[0];
            newArray[1] = array[1];

            foreach (int originalInt in array.TakeLast(5).ToArray())
            {
                Console.WriteLine(originalInt);
                foreach (int newInt in newArray)
                {
                            
                }
            }
        }

        public void shiftArrayLeft(ref int[] inputArray, int index)
        {
            int previousInt = 0;

            foreach (int selectInt in inputArray.Skip(index+1))
            {
                
            }
        }
        
        
    }
}