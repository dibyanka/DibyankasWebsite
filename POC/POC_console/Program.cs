using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POC_console
{
	class Program
	{
		static void Main(string[] args)
        {
            //Console.WriteLine("Input string for pallindromeCheck is: ");
            //string inputStr1 = Console.ReadLine();
            //Console.WriteLine(checkPalindrome(inputStr1));
            //Console.ReadLine();

            Console.WriteLine("Input string for reverse string is: ");
            string inputStr2 = Console.ReadLine();
            Console.WriteLine(reverseString(inputStr2));
            Console.ReadLine();
		}

        public static bool checkPalindrome(string inputStr)
        {
            char[] inputStr1 = inputStr.ToCharArray();
            char[] oStr1 = new char[inputStr.Length];
            bool ispallindrome = false;

            for (int i = 0, j = inputStr.Length - 1; i < inputStr.Length; i++, j--)
            {

                oStr1[i] = inputStr1[j];                

            }
            string outputstr = new string(oStr1);
            if (inputStr.Equals(outputstr))
            {
                ispallindrome= true;
            }
            return ispallindrome;
        
        
        }
        public static string reverseString(string istr)
        {          
            char[] istrarr = istr.ToCharArray();
            Array.Reverse(istrarr);
            return new String(istrarr);
        }

        public static string getallodds()
        { 
        
        }
	}
}
