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
            Console.WriteLine("num = {0}", StaticTest.getNum());

            Console.ReadKey();   
        }
    }
    class ArrayTest
    {
        private int length;
        int[] nums;
        public ArrayTest(int _length = 10)
        {
            length = _length;
            nums = new int[length];
        }
        public void printArray()
        {
            for (int i = 0; i < length; i++)
                nums[i] = i * 2;
            for (int i = 0; i < length; i++)
                Console.WriteLine("num[{0}] = {1}", i, nums[i]);
        }
    }
    class RefTest
    {
        public void refSwap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

    }
    class OutTest
    {
        public void outNums(out int a, out int b)
        {
            DateTime today = DateTime.Today;
            a = today.Month;
            b = today.Day;
        }
    }
    class StaticTest
    {
        public static int num = 1;
        public void count()
        {
            num++;
        }
        public static int getNum()
        {
            return num;
        }
    }
    int StaticTest::num = 1;
}
