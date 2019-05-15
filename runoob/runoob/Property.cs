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
        //Starting with C# 6, read-only properties can implement the get accessor as an expression-bodied member. 
        //The read-only Name property as an expression-bodied member.
        public string Name => $"{_firstName} {_lastName}";
    }

    public class SaleItem
    {
        string _name;
        decimal _cost;
        public SaleItem(string name, decimal cost)
        {
            _name = name;
            _cost = cost;
        }

        // property
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public decimal Price
        {

            get => _cost;
            set => _cost = value;
        }
        static public void Test()
        {
            var item = new SaleItem("shoes", 19.95m);
            Console.WriteLine($"{item.Name}: sells for {item.Price}");
        }
    }

    //Auto-implemented properties
    public class SaleItemAuto
    {
        public string Name
        { get; set; }
        public decimal Price
        { get; set; }
    }
}
