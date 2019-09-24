using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne, numberTwo;
//            string consoleInput;
            /*
            Console.Write("Enter First Number: ");
            numberOne = Convert.ToInt16(Console.ReadLine());
            
            Console.Write("Enter Second Number: ");
            numberTwo = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Sum: {0}", sum(ref numberOne, ref numberTwo));
            Console.WriteLine("Power: {0}", power(ref numberOne, ref numberTwo));
            */

            inputAverages();
        }

        static int sum(ref int xNew, ref int yNew)
        {
            return xNew + yNew;
        }

        static int power(ref int baseNum, ref int indexNumber)
        {
            int returnNumber = baseNum;
            
            for (int index = 1; index < indexNumber; index++)
                returnNumber *= baseNum;
            
            return returnNumber;
        }

        static void inputAverages()
        {
            int totalInputVal = 0, index = 0;
            bool loop = true;
            
            Console.WriteLine("Enter \'0\' to escape and calculate the average.");
            while (loop)
            {
                Console.WriteLine("Enter Number: ");
                int tempInput = Convert.ToInt16(Console.ReadLine());
                
                
                if (totalInputVal + tempInput == totalInputVal)
                {
                    loop = false;
                }
                else
                {
                    totalInputVal += tempInput;
                    index++;
                }
            }
            
            Console.WriteLine("Average: {0}", totalInputVal/index);
        }
    }
}