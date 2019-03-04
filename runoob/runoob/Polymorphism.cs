using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
C# 多态性
    静态多态性, 函数的响应是在编译时发生的: 函数重载,运算符重载
    动态多态性，函数的响应是在运行时发生的: 动态多态性是通过 抽象类 和 虚方法 实现的。

重载(overload): 
在同一个作用域(一般指一个类)的两个或多个方法函数名相同，参数列表不同的方法叫做重载，它们有三个特点(俗称两必须一可以):
1.方法名必须相同
2.参数列表必须不相同
3.返回值类型可以不相同

重写(override):
子类中为满足自己的需要来重复定义某个方法的不同实现，
需要用 override 关键字，被重写的方法必须是虚方法，用的是 virtual 关键字。它的特点是(三个相同):
1.相同的方法名
2.相同的参数列表
3.相同的返回值

虚方法：即为基类中定义的允许在派生类中重写的方法，使用virtual关键字定义。虚方法也可以被直接调用。
抽象方法：在基类中定义的并且必须在派生类中重写的方法，使用 abstract 关键字定义。抽象方法只能在抽象类中定义。
（区别：virtual可以被子类重写，而abstract必须被子类重写）
隐藏方法：在派生类中定义的和基类中的某个方法同名的方法，使用 new 关键字定义。
 */

namespace runoob
{
    class Polymorphism
    {
    }
}
