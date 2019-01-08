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

    class ParentClass1
    {
        public virtual void ParVirMethod()
        {
            Console.WriteLine("parent1 virtual");
        }
    }

    abstract class ParentClass2
    {
        // 抽象函数只能在抽象类中定义，并且没有函数体
        public abstract void ParAbsMethod();
    }

    class ChildClass1 : ParentClass1
    {
        public override void ParVirMethod()
        {
            Console.WriteLine("class1 override virtual");
        }
    }
 
    class ChildClass2 : ParentClass1
    {
        public new void ParVirMethod()
        {
            Console.WriteLine("class2 new");
        }
    }
    class ChildClass3 : ParentClass2
    {
        public override void ParAbsMethod()
        {
            Console.WriteLine("class3 override abstract");
        }
    }
    class ChildTest
    {
        //---- 隐藏方法的调用----
        public void Test()
        {
            //---隐藏方法调用---
            //用什么类型来声明，在调用方法的时候就会调用什么类型的方法。
            ParentClass1 par1 = new ChildClass2();
            ChildClass2 child = new ChildClass2();
            par1.ParVirMethod();
            child.ParVirMethod();

            //---虚方法的调用---
            //用什么类型来实例化，在调用方法的时候就会调用什么类型的方法。
            par1 = new ChildClass1();
            par1.ParVirMethod();
            ParentClass2 par2 = new ChildClass3();
            par2.ParAbsMethod();

        }
          
    }
}
