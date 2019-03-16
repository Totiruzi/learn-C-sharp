using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 命名空间的设计目的是提供一种让一组名称与其他名称分隔开的方式。
// 在一个命名空间中声明的类的名称与另一个命名空间中声明的相同的类的名称不冲突。
namespace spaceA
{
    class Test
    {
        public void Func()
        {
            Console.WriteLine("Inside spaceA");
        }
    }
}
namespace spaceB
{
    class Test
    {
        public void Func()
        {
            Console.WriteLine("Inside spaceB");
        }
    }
}

/*
1. using指令：引入命名空间
using System;
using Namespace1.SubNameSpace;

2. using static 指令：指定无需指定类型名称即可访问其静态成员的类型
using static System.Math;var = PI; // 直接使用System.Math.PI

3. 起别名
using Project = PC.MyCompany.Project;

4. using语句：将实例与代码绑定
using (Font font3 = new Font("Arial", 10.0f),
            font4 = new Font("Arial", 10.0f))
{
    // Use font3 and font4.
}
代码段结束时，自动调用font3和font4的Dispose方法，释放实例。
 */
