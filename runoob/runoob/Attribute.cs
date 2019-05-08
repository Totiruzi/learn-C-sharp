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
    [System.AttributeUsage(System.AttributeTargets.Class | 
                           System.AttributeTargets.Struct,
                           AllowMultiple = true) //Multiuse attribute
    ]
    public class Author : System.Attribute
    {
        private string name;
        public double version;

        public Author(string name)
        {
            this.name = name;
            //default = 1.0
            version = 1.0;
        }
        public string GetName()
        {
            return name;
        }
    }

    [Author("Han", version = 1.1)]
    public class Class1
    {
        // Han's code goes here...
    }
    public class Class2
    {
        
    }
    [Author("a1"), Author("a2", version = 2.0)]
    public class Class3
    {

    }
    class TestAuthorAttribute
    {
        public static void Test()
        {
            PrintAuthorInfo(typeof(Class1));
            PrintAuthorInfo(typeof(Class2));
            PrintAuthorInfo(typeof(Class3));

        }
        private static void PrintAuthorInfo(System.Type t)
        {
            System.Console.WriteLine("Author information for {0}", t);

            // Using reflection.  
            System.Attribute[] attrs = System.Attribute.GetCustomAttributes(t);  // Reflection.  

            // Displaying output.  
            foreach (System.Attribute attr in attrs)
            {
                if (attr is Author)
                {
                    Author a = (Author)attr;
                    System.Console.WriteLine("   {0}, version {1:f}", a.GetName(), a.version);
                }
            }

        }
    }

}

