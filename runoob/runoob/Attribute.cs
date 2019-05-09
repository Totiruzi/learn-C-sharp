#define TRACE_ON  
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;



namespace runoob
{
    //Obsolete Attribute
    [System.Obsolete("use class B")]
    class A
    {
        public void Method() { }
    }
    class B
    {
        [System.Obsolete("use NewMethod", true)]
        public void OldMethod() { }
        public void NewMethod() { }
    }

    // Conditional Attribute
    public class Trace
    {
        [Conditional("TRACE_ON")]
        public static void Msg(string msg)
        {
            Console.WriteLine(msg);
        }
    }
    // Using Multiple Identifiers
    class MultiIdentif
    {
        //  using the OR operator
        [Conditional("A"), Conditional("B")]
        static void DoIfAorB()
        {
            // ...  
        }
        // using the AND operator
        [Conditional("A")]
        static void DoIfA()
        {
            DoIfAandB();
        }
        [Conditional("B")]
        static void DoIfAandB()
        {
            // Code to execute when both A and B are defined...  
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

    // Add a using directive for System.Runtime.InteropServices.  
    // All of the fields of TestUnion start at the same location in memory
    [System.Runtime.InteropServices.StructLayout(LayoutKind.Explicit)]
    struct TestUnion
    {
        [System.Runtime.InteropServices.FieldOffset(0)]
        public int i;

        [System.Runtime.InteropServices.FieldOffset(0)]
        public double d;

        [System.Runtime.InteropServices.FieldOffset(0)]
        public char c;

        [System.Runtime.InteropServices.FieldOffset(0)]
        public byte b;
    }

}

