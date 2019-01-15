using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 (1)通过接口可以实现多重继承，C# 接口的成员不能有 public、protected、internal、private 等修饰符。接口里面的方法都需要由外面接口实现去实现方法体，那么其修饰符必然是 public。C# 接口中的成员默认是 public 的，java 中是可以加 public 的。
 (2)接口成员不能有 new、static、abstract、override、virtual 修饰符。有一点要注意，当一个接口实现一个接口，这2个接口中有相同的方法时，可用 new 关键字隐藏父接口中的方法。
 (3)接口中只包含成员的签名，接口没有构造函数，所有不能直接使用 new 对接口进行实例化。接口中只能包含方法、属性、事件和索引的组合。接口一旦被实现，实现类必须实现接口中的所有成员，除非实现类本身是抽象类。
 (4)C# 是单继承，接口是解决 C# 里面类可以同时继承多个基类的问题。
 */
namespace runoob
{
    interface IWorker
    {
        void Work();
    }
    class Tom : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Tom");
        }
    }
    class Bob : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Bob");
        }
    }
    class TestInterface
    {
        public void Test()
        {
            Tom tom = new Tom();
            Bob bob = new Bob();
            tom.Work();
            bob.Work();
        }
    }
}
