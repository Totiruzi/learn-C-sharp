using System;

namespace SingletonPatternEx
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();
        private int numberOfInstances = 0;
        //Private constructor is used to prevent
        //creation of instances with 'new' keyword outside this class
        private Singleton()
        {
            Console.WriteLine("Instantiating inside the private constructor.");
            numberOfInstances++;
            Console.WriteLine("Number of instances ={0}", numberOfInstances);
        }
        public static Singleton Instance
        {
            get
            {
                Console.WriteLine("We already have an instance now.Use it.");
                return instance;
            }
        }
        //public static int MyInt = 25;
    }
    // used sealed to guard one special case-if
    // you are tempted to use a derived nested class as below:
    public class SingletonWithoutSealed
    {
        private static readonly SingletonWithoutSealed instance = new SingletonWithoutSealed();
        private static int numberOfInstances = 0;
        //Private constructor is used to prevent
        //creation of instances with 'new' keyword outside this class
        //protected Singleton()
        private SingletonWithoutSealed()
        {
            Console.WriteLine("Instantiating inside the private constructor (without sealed).");
            numberOfInstances++;
            Console.WriteLine("Number of instances ={0}",
            numberOfInstances);
        }
        public static SingletonWithoutSealed Instance
        {
            get
            {
                Console.WriteLine("We already have an instance now.Use it.");
            return instance;
            }
        }
        //The keyword "sealed" can guard this scenario.
        public class NestedDerived : SingletonWithoutSealed { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Singleton Pattern Demo***\n");
            //Console.WriteLine(Singleton.MyInt);
            //Private Constructor.So,we cannot use 'new' keyword.
            Console.WriteLine("Trying to create instance s1.");
            //The public static member ensures a global point of access. It
            // confirms that the instantiation process will not start until you invoke
            //the Instance property of the class (in other words, it supports lazy instantiation). 
            Singleton s1 = Singleton.Instance;
            Console.WriteLine("Trying to create instance s2.");
            Singleton s2 = Singleton.Instance;
            if (s1 == s2)
            {
                Console.WriteLine("Only one instance exists.");
            }
            else
            {
                Console.WriteLine("Different instances exist.");
            }

            //Not using "sealed" keyword now
            Console.WriteLine("\n***Singleton Without sealed Pattern Demo***\n");
            SingletonWithoutSealed.NestedDerived nestedClassObject1 = new SingletonWithoutSealed.NestedDerived(); //1 1 ???
            SingletonWithoutSealed.NestedDerived nestedClassObject2 = new SingletonWithoutSealed.NestedDerived(); //2
            SingletonWithoutSealed.NestedDerived nestedClassObject3 = new SingletonWithoutSealed.NestedDerived(); //3
            if (nestedClassObject1 == nestedClassObject2)
            {
                Console.WriteLine("Only one instance exists.");
            }
            else
            {
                Console.WriteLine("Different instances exist.");
            }
            //Console.Read();
            Console.ReadKey(true);
        }
    }

}

