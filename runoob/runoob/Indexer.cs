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
        public static void Test()
        {
            SampleCollection<String> stringCollection = new SampleCollection<string>();
            stringCollection[0] = "hello world";
            System.Console.WriteLine(stringCollection[0]);
        }
    }
}
