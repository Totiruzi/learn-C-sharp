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
            ArrayTest nums = new ArrayTest(10);
            nums.printArray();
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
