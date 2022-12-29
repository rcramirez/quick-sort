using Microsoft.AspNetCore.WebUtilities;
using System.Collections.Concurrent;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var nums = new int[11]{8, 3, 6, 1, 2, 9, 10, 7, 5, 4, 0 };
            QuickSort(nums, 0, nums.Length - 1);
            foreach(var num in nums)
            {
                Console.WriteLine($"{num} |");
            }
        }


        private static void QuickSort(int[] nums, int left, int right)
        {
            if(left < right)
            {
                var pivot = Partition(nums, left, right);
                QuickSort(nums, left, pivot-1);//left
                QuickSort(nums, pivot+1, right);//right
            }
        }

        private static int Partition(int[] nums, int left, int right)
        {
            var isLeft = true;
            while(left != right)
            {
                if (nums[right] < nums[left])
                {
                    var temp = nums[left];
                    nums[left] = nums[right];
                    nums[right] = temp;
                    isLeft = !isLeft;
                }
                else
                {
                    if (isLeft) left++;
                    else right--;
                }
            }

            return left;
        }
    }
}