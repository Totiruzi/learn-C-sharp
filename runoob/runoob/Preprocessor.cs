﻿//#define DEBUG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
预处理器指令指导编译器在实际编译开始之前对信息进行预处理。
所有的预处理器指令都是以 # 开始。且在一行上，只有空白字符可以出现在预处理器指令之前。
预处理器指令不是语句，所以它们不以分号（;）结束。
C# 编译器没有一个单独的预处理器，但是，指令被处理时就像是有一个单独的预处理器一样。
在 C# 中，预处理器指令用于在条件编译中起作用。与 C 和 C++ 不同的是，它们不是用来创建宏。一个预处理器指令必须是该行上的唯一指令。
使用 #define 创建的符号的作用域是在其中定义它的文件。
VS中的Debug buid使用了#define DEBUG作用于整个解决方案
----------------------------------
#define	    用于定义一系列成为符号的字符。
#undef	    用于取消定义符号。
#if	        用于测试符号是否为真。
#else	    用于创建复合条件指令，与 #if 一起使用。
#elif	    用于创建复合条件指令。
#endif	    指定一个条件指令的结束。
#line	    可以让您修改编译器的行数以及（可选地）输出错误和警告的文件名。
#error	    允许从代码的指定位置生成一个错误。
#warning    允许从代码的指定位置生成一级警告。
#region	    在使用 Visual Studio Code Editor 的大纲特性时，指定一个可展开或折叠的代码块。
#endregion	标识 #region 块的结束。
-----------------------------------
 */

namespace runoob
{
    class Preprocessor
    {
        void PreprocessorTest()
        {
            #if (DEBUG)
                Console.WriteLine("DEBUG is defined");     
            #else
                Console.WriteLine("DEBUG is not defined"); 
            #endif
                Console.ReadKey();
        }
    }
}
