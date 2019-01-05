using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace runoob
{
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
    // https://www.geeksforgeeks.org/c-types-of-variables/
    class VarTest
    {
        // These variables are instance variables. 
        // These variables are in a class and are not inside any function 
        public int insVar;
        // static variable s
        public static int staVar = 0;

        // constant variable 
        // constant variables can’t be modified once after their declaration, 
        // so it’s must intialize at the time of declaration only.
        public const float consVar = 0;

        // readonly variables 
        // It’s not compulsory to initialize a read-only variable at the time of the declaration, 
        // they can also be initialized under the constructor.
        public readonly int readVar;

        public VarTest()
        {
            insVar = 0;

            readVar = 0;
        }
        
    }
}
