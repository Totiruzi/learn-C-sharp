using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
operator 关键字用于在类或结构声明中声明运算符。运算符声明可以采用下列四种形式之一：
 public static result-type operator unary-operator ( op-type operand )
 public static result-type operator binary-operator ( op-type operand, op-type2 operand2 )
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
    class OperatorOverload
    {
    }
}
