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
            int a = 0, b = 1;
            RefTest reftest = new RefTest();
            reftest.refSwap(ref a, ref b);
            Console.WriteLine("a = {0}, b = {1}", a, b);

            OutTest outtest = new OutTest();
            outtest.outNums(out a, out b);
            Console.WriteLine("a = {0}, b = {1}", a, b);

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
    class Box
    {
        private double length;   
        private double breadth;  
        private double height;   
        public void setLength(double len)
        {
            length = len;
        }

        public void setBreadth(double bre)
        {
            breadth = bre;
        }

        public void setHeight(double hei)
        {
            height = hei;
        }
        public double getVolume()
        {
            return length * breadth * height;
        }
    }

}
