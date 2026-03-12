using System;

namespace CountGoodTripletsApp
{
    public class Solution
    {
        public int CountGoodTriplets(int[] arr, int a, int b, int c)
        {
            int count = 0;
            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    if (Math.Abs(arr[i] - arr[j]) <= a)
                    {
                        for (int k = j + 1; k < arr.Length; k++)
                        {
                            if (Math.Abs(arr[j] - arr[k]) <= b && Math.Abs(arr[i] - arr[k]) <= c)
                            {
                                count++;
                            }
                        }
                    }
                }
            }
            return count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution çözüm = new Solution();

            int[] arr = { 3, 0, 1, 1, 9, 7 };
            int a = 7;
            int b = 2;
            int c = 3;

            int sonuc = çözüm.CountGoodTriplets(arr, a, b, c);

            Console.WriteLine("Bulunan 'iyi üçlü' sayısı: " + sonuc);

            Console.WriteLine("\nÇıkmak için Enter'a basın...");
            Console.ReadLine();
        }
    }
}