using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace runoob
{
    class Box
    {
        private double length;      // 长度
        private double breadth;     // 宽度
        private double height;      // 高度

        public Box(double _length=0, double _breadth=0, double _height=0)
        {
            length = _length;
            breadth = _breadth;
            height = _height;
        }

        public double GetVolume()
        {
            return length * breadth * height;
        }
        public void SetLength(double len)
        {
            length = len;
        }

        public void SetBreadth(double bre)
        {
            breadth = bre;
        }

        public void SetHeight(double hei)
        {
            height = hei;
        }
        /*
         * 运算符重载必须是 public 且 static
         */
        public static Box operator +(Box b, Box c)
        {
            Box box = new Box
            {
                length = b.length + c.length,
                breadth = b.breadth + c.breadth,
                height = b.height + c.height
            };
            return box;
        }

        public static bool operator ==(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length == rhs.length && lhs.height == rhs.height
               && lhs.breadth == rhs.breadth)
            {
                status = true;
            }
            return status;
        }
        public static bool operator !=(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length != rhs.length || lhs.height != rhs.height
                || lhs.breadth != rhs.breadth)
            {
                status = true;
            }
            return status;
        }
        public static bool operator <(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length < rhs.length && lhs.height
                < rhs.height && lhs.breadth < rhs.breadth)
            {
                status = true;
            }
            return status;
        }

        public static bool operator >(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length > rhs.length && lhs.height
                > rhs.height && lhs.breadth > rhs.breadth)
            {
                status = true;
            }
            return status;
        }

        public static bool operator <=(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length <= rhs.length && lhs.height
                <= rhs.height && lhs.breadth <= rhs.breadth)
            {
                status = true;
            }
            return status;
        }

        public static bool operator >=(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length >= rhs.length && lhs.height
               >= rhs.height && lhs.breadth >= rhs.breadth)
            {
                status = true;
            }
            return status;
        }
        public override string ToString()
        {
            return String.Format("({0}, {1}, {2})", length, breadth, height);
        }

        public static void Test()
        {
            Box box1 = new Box(6.0, 7.0, 5.0);          
            Box box2 = new Box(12.0, 13.0, 10.0);          
            Box box3 = new Box();          
            Box box4 = new Box();
            Console.WriteLine("box1： {0}", box1.ToString());
            Console.WriteLine("box2： {0}", box2.ToString());
     
            Console.WriteLine("box1 的体积： {0}", box1.GetVolume());
            Console.WriteLine("box2 的体积： {0}", box2.GetVolume());

            box3 = box1 + box2;
            Console.WriteLine("box3： {0}", box3.ToString());
            Console.WriteLine("box3 的体积： {0}", box3.GetVolume());

            Console.WriteLine("box1 > box2 : {0}", box1 > box2);
            Console.WriteLine("box1 < box2 : {0}", box1 < box2);
            Console.WriteLine("box1 <= box2 : {0}", box1 <= box2);
            Console.WriteLine("box1 >= box2 : {0}", box1 >= box2);

            box4 = box3;
            Console.WriteLine("box3 == box4 : {0}", box3 == box4);
        }
    }
}
