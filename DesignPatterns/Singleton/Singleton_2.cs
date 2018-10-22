using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    // 实现按需创建实例
    public sealed class Singleton_2
    {
        Singleton_2() {}
        public static Singleton_2 Instance
        {
            get
            {
                return Nested.instance;
            }
        }
        class Nested
        {
            static Nested() {}
            internal static readonly Singleton_2 instance = new Singleton_2();
        }
    }
}
