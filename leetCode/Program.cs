using System;
using System.Collections.Generic;

namespace leetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            Dictionary<int,int> map = new Dictionary<int,int>();
            for(int i = 0; i < nums.Length; i++)
            {
                int containers = target - nums[i];
                if(map.ContainsKey(containers))
                {
                    Console.WriteLine($"{ map[containers]}, { i} ");
                }
                map[nums[i]] = i;
            }
            Console.WriteLine();
        }
    }
}
