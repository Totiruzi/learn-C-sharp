using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace runoob
{
    class SampleCollection<T>
    {
        private T[] arr = new T[100];

        //define the indexer to allow client code to use [] notation
        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
        
    }

    //Starting with C# 7.0, both the get and set accessor can be an implemented as expression-bodied members. 
    //In this case, both get and set keywords must be used.
    class SampleCollectionExpression<T>
    {
        private T[] arr = new T[100];
        public T this[int i]
        {
            get => arr[i];
            set => arr[i] = value;
        }
    }
    class IndexerTest
    {
        public static void Test()
        {
            SampleCollection<String> stringCollection = new SampleCollection<string>();
            var stringCollectionExp = new SampleCollectionExpression<string>();
            stringCollection[0] = "hello";
            stringCollectionExp[0] = "world";
            System.Console.WriteLine(stringCollection[0] + " " + stringCollectionExp[0]);
        }
    }
}
