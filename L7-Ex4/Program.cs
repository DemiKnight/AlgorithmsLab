using System;

namespace L7_Ex4
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            Console.WriteLine(getNumberString(3));
        }
        
        static string getNumberString(int n)
        {
            return (n > 0 ? n.ToString() + " " + getNumberString(n - 1) : "");
            /*if (n == 0)
                return "";
            //            return (n > 0 ? : "");
            else
            {
                ;
                return n.ToString() + " " + getNumberString(n-1);
            }*/
        }
    }
}