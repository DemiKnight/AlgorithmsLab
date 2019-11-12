using System;
using System.Net;

namespace L7_Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isPrime(4));
            
            
        }

        static int dec(int x) => x - 1;
        static int inc(int x) => x + 1;
        
        static int multiply(int num1, int num2)
        {
            return (num1 == 1 ? num2 :  multiply(dec(num1), num2+num2));
        }

        static int power(int num, int pow)
        {
            
            if (pow == 0) return 1;
            if (pow == 1) return num;
            
            return num*power(num, dec(pow));
        }

        static int isPrimeTester(int test, int divisor)
        {
            if (test % divisor == 0)
            {
                return divisor;
            }
            
            return isPrimeTester(test, divisor+1);
            
        }
        
        static bool isPrime(int num)
        {
            if (num == isPrimeTester(num, 2) && num % num == 0)
            {
                return true;
            }
            
            return false;
        }

    }
}