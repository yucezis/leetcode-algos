using System;

namespace ArrayTransformApp
{
    // Sizin yazdığınız ve düzeltilmiş Solution sınıfı
    public class Solution
    {
        public int[] TransformArray(int[] nums)
        {

            for (int i = 0; i<nums.Length; i++)
            {
                if (nums[i] % 2 == 0)nums[i] = 0;
                else nums[i] = 1;
                
            }
            Array.Sort(nums);
            return nums;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution cozum = new Solution();

            int[] ornekDizi = { 5, 2, 8, 7, 3, 4, 10 };

            int[] orijinalDizi = (int[])ornekDizi.Clone();
            Console.WriteLine("Orijinal Dizi: [" + string.Join(", ", orijinalDizi) + "]");

            int[] sonucDizisi = cozum.TransformArray(ornekDizi);

            Console.WriteLine("Dönüştürülmüş ve Sıralı Dizi: [" + string.Join(", ", sonucDizisi) + "]");

            Console.WriteLine("\nÇıkmak için herhangi bir tuşa basın...");
            Console.ReadKey();
        }
    }
}