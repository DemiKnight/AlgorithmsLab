using System;
using System.Collections;

namespace L6_Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable strNum = new Hashtable();
            
            strNum.Add('0',"zero");
            strNum.Add('1',"one");
            strNum.Add('2',"two");
            strNum.Add('3',"three");
            strNum.Add('4',"four");
            strNum.Add('5',"five");
            strNum.Add('6',"six");
            strNum.Add('7',"seven");
            strNum.Add('8',"eight");
            strNum.Add('9',"nine");

            string testStr = "152";

            foreach (char character in testStr)
            {

                foreach (DictionaryEntry o in strNum)
                {
                    if ((char) o.Key == character) Console.Write(o.Value +  " ");
                    
                }
            }
        }
    }
}