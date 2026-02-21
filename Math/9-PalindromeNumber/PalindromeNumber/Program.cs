using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace PalindromeNumber
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            string a = x.ToString();
            string ters = "";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                ters += a[i];
            }
            return a == ters;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution mySolution = new Solution();

            int test1 = 121;
            int test2 = -121;
            int test3 = 10;

            bool sonuc1 = mySolution.IsPalindrome(test1);
            Console.WriteLine("Test 1 (" + test1 + "): " + (sonuc1 ? "Palindrom" : "Palindrom Değil"));

            bool sonuc2 = mySolution.IsPalindrome(test2);
            Console.WriteLine("Test 2 (" + test2 + "): " + (sonuc2 ? "Palindrom" : "Palindrom Değil"));

            bool sonuc3 = mySolution.IsPalindrome(test3);
            Console.WriteLine("Test 3 (" + test3 + "): " + (sonuc3 ? "Palindrom" : "Palindrom Değil"));

            Console.ReadLine();
        }
    }
}