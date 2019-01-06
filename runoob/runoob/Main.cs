using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace runoob
{
    class main
    {
        static void Main(string[] args)
        {
            ParentClass par = new ChildClass0();
            par.ParVirMethod(); //结果："子类0的方法"

            par = new ChildClass1();
            par.ParVirMethod(); //结果："子类1的方法"，调用子类的方法，实现了多态

            par = new ChildClass2();
            par.ParVirMethod(); //结果："父类的方法"，调用父类的方法，没有实现多态  
            Console.ReadKey();
        }
    }
}
