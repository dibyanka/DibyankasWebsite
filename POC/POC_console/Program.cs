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
            Console.WriteLine("Enter the number from which repeated characters are to be removed: ");
            string inputStrDup = Console.ReadLine();
            RemoveDuplicateCharacters(inputStrDup);
            Console.WriteLine("Enter the number whose factorial needs to be calculated:");
            int factOf = int.Parse(Console.ReadLine());
            Console.WriteLine("CalculateFactorial is: {0}" ,CalculateFactorial(factOf));
            Console.WriteLine("Input string for pallindromeCheck is: ");
            string inputStr1 = Console.ReadLine();
            Console.WriteLine(checkPalindrome(inputStr1));            

            Console.WriteLine("Input string for reverse string is: ");
            string inputStr2 = Console.ReadLine();
            Console.WriteLine(reverseString(inputStr2));
            Console.Write("Enter the set of numbers separated with comma:");
            string numbers=Console.ReadLine();
            List<int> inputSeries = new List<int>();
            inputSeries = numbers.Split(',').Select(int.Parse).ToList();
            printAllOdds(inputSeries);            
            Console.WriteLine("The largest number among the given series is:{0} ", GetLargest(inputSeries));
            Console.WriteLine("Enter the number to check if it's a perfect square: ");
            int inputNum2 =int.Parse (Console.ReadLine());
            Console.WriteLine(CheckPerfectSquare(inputNum2));

            Console.WriteLine("Enter the numbers to be swapped:");
            string numbers1 = Console.ReadLine();
            List<int> inputSeries1 = new List<int>();
            inputSeries1 = numbers1.Split(',').Select(int.Parse).ToList();
            SwapTwoNumbers(inputSeries1[0],inputSeries1[1]);
            Console.WriteLine("Enter the nth index in fibbonacci series:" );
            int nth = int.Parse(Console.ReadLine());
            Console.WriteLine("The nth element in fibbonacci series is: {0}", printNthFibbonacciSeries(nth));
                       
            Console.ReadLine();

		}
        
        /// <summary>
        /// Program to check if a given string is pallindrome or not
        /// </summary>
        /// <param name="inputStr"></param>
        /// <returns></returns>
        public static bool checkPalindrome(string inputStr)
        {
            char[] inputStr1 = inputStr.ToCharArray();
            char[] oStr1 = new char[inputStr.Length];
            bool ispallindrome = false;

            //revrse the given string
            for (int i = 0, j = inputStr.Length - 1; i < inputStr.Length; i++, j--)
            {

                oStr1[i] = inputStr1[j];                

            }
            string outputstr = new string(oStr1);
            //compare both the strings
            if (inputStr.Equals(outputstr))
            {
                ispallindrome= true;
            }
            return ispallindrome;
        
        
        }

        /// <summary>
        /// Program to get the reversed value of a string
        /// </summary>
        /// <param name="istr"></param>
        /// <returns></returns>
        public static string reverseString(string istr)
        {          
            char[] istrarr = istr.ToCharArray();
            Array.Reverse(istrarr);
            return new String(istrarr);
        }

        /// <summary>
        /// program to select and print all the odd numbers in given set of input numbers
        /// </summary>
        /// <param name="inputNumbers"></param>
        public static void printAllOdds(List<int> inputNumbers)
        {
           var oddNumbers=(from odd in inputNumbers
                              where odd % 2 != 0
                              select odd).ToList();  
      
            foreach (var num in oddNumbers)
            {
                Console.WriteLine(num);
            }
        }

        /// <summary>
        /// program to select the largest number among the set of given numbers
        /// </summary>
        /// <param name="inputNumbers"></param>

        public static int GetLargest( List<int> inputNumbers)
        {

            int largest = inputNumbers.Max();
            return largest;
        }
        /// <summary>
        /// Program to check if given number is a perfect square root
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>

        public static bool CheckPerfectSquare(int number)
        {
            bool isPerfectSquare = false;

            isPerfectSquare = Math.Sqrt(number) % 1 == 0;
            return isPerfectSquare;
        
        }

        /// <summary>
        /// Program which checks if two Strings are Anagram or not
        /// </summary>
        /// <param name="inputStr1"></param>
        /// <param name="inputStr2"></param>
        /// <returns></returns>

        public static bool checkAnagrams(string inputStr1, string inputStr2)
        {
            bool areAnagrams = false;
        //1. convert the given strings into char arrays
            char[] inputArr1 = inputStr1.ToCharArray();
            char[] inputArr2 = inputStr2.ToCharArray();

        //2. sort the arrays
            Array.Sort(inputArr1);
            Array.Sort(inputArr2);

            //3.convert back to strings
            string inputStr1new = new string(inputArr1);
            string inputStr2new = new string(inputArr2);

            //4. compare the two strings, keep tolower to avoid any discrepency in cases
            if (inputStr1new.ToLower().Equals(inputStr2new.ToLower()))
            {
                areAnagrams = true;
            }

            return areAnagrams;

        }

        /// <summary>
        /// to swap two numbers without using a temp variable, write code which is free from Integer overflow
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        public static void SwapTwoNumbers(int num1, int num2)
        {
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine("swapped nubers are: {0},{1}" , num1, num2 );
        }

        /// <summary>
        /// Program to print nth number in Fibonacci series 0,1,1,2,3,5,8,13...
        /// </summary>
        /// <returns></returns>

        public static int printNthFibbonacciSeries( int n)
        {
            int nth=0;
            int [] fib = new int[n];
          
            fib[0] = 0; fib[1]= 1; 

            if (n == 0) { nth= fib[0] ;}
            else if (n == 1) { nth= fib[1]; }
            else{

            for (int i = 2; i < n; i++)
            {
                fib[i] = fib[i - 2] + fib[i - 1];
                nth = fib[i];
            }

            }
            return nth;

        }
        /// <summary>
        /// Program to calculate factorial
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int CalculateFactorial(int n)
        {
            int result=1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
                return result;
        }

        /// <summary>
        /// Program to find all pairs of elements in an integer array, whose sum is equal to a given number
        /// </summary>
        /// <returns></returns>
        //public static int[] FindPairOfNumbers()
        // { 
        
        //}


        /// <summary>
        /// Program to print the string after removing duplicate chars in it
        /// </summary>
        /// <param name="inputStr"></param>
        public static void RemoveDuplicateCharacters(string inputStr)
        {
            string result = new string(inputStr.ToLower().Distinct().ToArray());
            Console.WriteLine("Resulting string is: {0}", result);
        }


	}
}
