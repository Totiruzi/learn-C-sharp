using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
operator 关键字用于在类或结构声明中声明运算符。运算符声明可以采用下列四种形式之一：
 public static result-type operator unary-operator ( op-type operand )
 public static result-type operator binary-operator ( op-type operand, op-type2 operand2 )
    //转换运算符
 public static implicit operator conv-type-out ( conv-type-in operand )
 public static explicit operator conv-type-out ( conv-type-in operand )
参数：
 result-type 运算符的结果类型。
 unary-operator 下列运算符之一：+ - ! ~ ++ — true false
 op-type 第一个（或唯一一个）参数的类型。
 operand 第一个（或唯一一个）参数的名称。
 binary-operator 其中一个：+ - * / % & | ^ << >> == != > < >= <=
 op-type2 第二个参数的类型。
 operand2 第二个参数的名称。
 conv-type-out 类型转换运算符的目标类型。
 conv-type-in 类型转换运算符的输入类型。
*/
namespace runoob
{
    class Complex
    {
        private int a;  //real 
        private int b;  //imaginary
        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void Print()
        {
            Console.Write("({0},{1})", this.a, this.b);
        }
        public static Complex operator +(Complex lhs, Complex rhs)
        {
            return new Complex(lhs.a + rhs.a, lhs.b + rhs.b);
        }
        public static Complex operator -(Complex lhs, Complex rhs)
        {
            return new Complex(lhs.a - rhs.a, lhs.b - rhs.b);
        }
        //C# 要求成对重载比较运算符。如果重载了==，则也必须重载!=，否则产生编译错误。同时，比较运算符必须返回bool类型的值，这是与其他算术运算符的根本区别。
        public static bool operator ==(Complex lhs, Complex rhs)
        {
            return lhs.a == rhs.a && lhs.b == rhs.b;
        }
        public static bool operator !=(Complex lhs, Complex rhs)
        {
            return lhs.a != rhs.a || lhs.b != rhs.b;
        }
        public static implicit operator int(Complex c)
        {
            return c.a;
        }
        public static explicit operator Complex(int i)
        {
            return new Complex(i, 0);
        }
    }

    class OperatorOverload
    { 
        public static void Test()
        {
            Complex c1 = new Complex(1, 2);
            int i = c1, j = 2;
            Complex c2 = (Complex)j;
            Console.WriteLine("i={0}", i);
            c2.Print();
            Console.ReadKey();
        }
    }
}
