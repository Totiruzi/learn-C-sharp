#define DEBUG
using System;
using System.Diagnostics;

namespace runoob
{
    class AttributeConditional
    {
        [Conditional("DEBUG")]
        public static void DebugMessage(string msg)
        {
            Console.WriteLine(msg);
        }
        public static void Test()
        {
            DebugMessage("debug");
            Console.ReadKey();
        }
    }
}

