using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace runoob
{
    /* 在子类中用 override 重写父类中用 virtual 申明的虚方法时，实例化父类调用该方法，执行时调用的是子类中重写的方法；
     * 如果子类中用 new 覆盖父类中用 virtual 申明的虚方法时，实例化父类调用该方法，执行时调用的是父类中的虚方法；
     * override是重写，即将基类的方法在派生类里直接抹去重新写，故而调用的方法就是子类方法；而new只是将基类的方法在派生类里隐藏起来，故而调用的仍旧是基类方法。
     */

    /// <summary>  
    /// 父类  
    /// </summary>  
    public class ParentClass
    {
        public virtual void ParVirMethod()
        {
            Console.WriteLine("父类的方法...");
        }
    }

    /// <summary>  
    /// 子类0 
    /// </summary>  
    public class ChildClass0 : ParentClass
    {
        public void ParVirMethod()
        {
            Console.WriteLine("子类0的方法...");
        }

        public void Test()
        {
            Console.WriteLine("子类0的其他方法...");
        }
    }

    /// <summary>  
    /// 子类1  
    /// </summary>  
    public class ChildClass1 : ParentClass
    {
        public override void ParVirMethod()
        {
            Console.WriteLine("子类1的方法...");
        }
    }

    /// <summary>  
    /// 子类2  
    /// </summary>  
    public class ChildClass2 : ParentClass
    {
        public new void ParVirMethod()
        {
            Console.WriteLine("子类2的方法...");
        }

        public void Test()
        {
            Console.WriteLine("子类2的其他方法...");
        }
    }
}
