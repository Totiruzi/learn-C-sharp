using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace runoob
{
    public class Person
    {
        private string _firstName;
        private string _lastName;

        public Person(string first, string last)
        {
            _firstName = first;
            _lastName = last;
        }
        //  the read-only Name property as an expression-bodied member.
        public string Name => $"{_firstName} {_lastName}";
    }
}
