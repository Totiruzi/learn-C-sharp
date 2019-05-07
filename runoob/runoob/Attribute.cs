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

    // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/attributes/index
    //creating custom Attributes
    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct)]
    public class Author : System.Attribute
    {
        private string name;
        public double version;

        public Author(string name)
        {
            this.name = name;
            version = 1.0;
        }
    }

    [Author("Han", version = 1.1)]
    class AuthorClass
    {
        // Han's code goes here...
    }
}

