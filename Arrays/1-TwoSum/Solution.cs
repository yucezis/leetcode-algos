using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target && i != j)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Solution mySolution = new Solution();

            int[] testDizisi = new int[] { 2, 7, 11, 15 };
            int testHedefi = 9;

            int[] sonuc = mySolution.TwoSum(testDizisi, testHedefi);

            if (sonuc != null)
            {
                Console.WriteLine("Sonuç bulundu!");
                Console.WriteLine("İndeks 1: " + sonuc[0]);
                Console.WriteLine("İndeks 2: " + sonuc[1]);

            }
            else
            {
                Console.WriteLine("Bu hedefle bir sonuç bulunamadı.");
            }

            Console.ReadLine();
        }
    }
}