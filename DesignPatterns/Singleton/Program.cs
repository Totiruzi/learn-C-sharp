using System;

namespace Singleton
{
    //参考《剑指offer》
    //利用静态构造函数，当 .NET运行时发现第一次使用一个类型的，就自动调用该类型的静态构造函数
    // c#的语法保证静态构造函数只调用一次
    public sealed class Singleton_1
    {
        private Singleton_1() { }
        private static Singleton_1 instance = new Singleton_1();
        public static Singleton_1 Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
