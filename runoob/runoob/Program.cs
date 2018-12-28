using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace runoob
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
                nums[i] = i * 2;
            for (int i = 0; i < n; i++)
                Console.WriteLine("num[{0}] = {1}", i, nums[i]);
            Console.ReadKey();   
        }
    }
}
