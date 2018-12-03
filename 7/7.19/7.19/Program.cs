﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._19
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int n in nums)
            {
                if (!printZero && n == 0) continue;
                Console.Write("{0}\t", n);
            }
            Console.WriteLine();
        }


        static public void Main(string[] args)
        {
            List<int> nums = new List<int>();
            // 1 is not a prime number
            for (int i = 2; i <= 10000000; ++i) nums.Add(i);

            int p = 2;
            int indexAt = 0;
            bool limitReached = false;

            while (!limitReached)
            {
                for (int i = 0; i < nums.Count; ++i)
                {
                    int v = nums[i];
                    if (v % p == 0 && v != p) nums[i] = 0;
                }
                do
                {
                    p = nums[++indexAt];
                    if (indexAt >= nums.Count - 1)
                    {
                        limitReached = true;
                        break;
                    }
                } while (p == 0);
            }

            PrintList(nums, false);
        }
    }
}
