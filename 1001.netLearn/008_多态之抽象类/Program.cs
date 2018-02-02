using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_多态之抽象类
{
    class Program
    {
        /*
        当父类中的方法不知道如何去实现的时候，可以考虑将父类写成抽象类，将方法写成抽象方法。
        用abstract来标记抽象类
        用abstract标记抽象方法,抽象方法不许有方法体.
        抽象成员必须在抽象类中
        抽象类不能被实例化
        子类继承抽象类后，必须把父类中的所有抽象成员都重写。（除非子类也是一个抽象类，则可以不重写）
        抽象成员的访问修饰符不能是private
        在抽象类中可以包含实例成员。
        并且抽象类的实例成员可以不被子类实现
        抽象类是有构造函数的，虽然不能被实例化
        如果父类的抽象方法中有参数，那么，继承这个抽象父类的子类在重写父类的方法的时候必须传入对应的参数
        若果抽象父类的抽象方法中有返回值，那么子类在重写这个抽象方法的时候，也必须要传入返回值
        如果父类中的方法有默认的实现，并且父类需要被实例化，这时可以考虑将父类定义成一个普通类，用虚方法类
        如果父类中的方法没有默认实现，父类也不需要被实例化，则可以将该类定义为抽象类。
        抽象类最终目的也是实现子类重写
         */
        static void Main(string[] args)
        {
            //例题：用抽象类求面积和周长
            double r = 3;
            Sharp sharp = new Cricle(r);
            Console.WriteLine("半径为{0}的圆:\n面积是：{1}\n周长是：{2}",r,sharp.GetArea(), sharp.GetPerimeter());

            double width = -3.1;
            double length = -4;
            Sharp sharp1 = new Squareness(width,length);
            Console.WriteLine("长为{0},宽为{1}的矩形:\n面积是：{2}\n周长是：{3}", length,width, sharp1.GetArea(), sharp1.GetPerimeter());
            Console.ReadKey();
        }
    }
    public abstract class Sharp
    {
        public abstract double GetArea();

        public abstract double GetPerimeter();
    }

    public class Cricle : Sharp
    {
        private double _r;

        public double R { get => _r; set => _r = value; }

        public Cricle(double r)
        {
            this.R = r;
        }
        public Cricle() { }

        public override double GetArea()
        {
            return Math.PI * R * R;
        }

        public override double GetPerimeter()
        {
            return Math.PI * R * 2;
        }
    }

    public class Squareness : Sharp
    {
        private double _width;
        private double _length;

        public double GetWidth()
        {
            if (_width<0)
            {
                _width = Math.Abs(_width);
            }
            return _width;
        }

        public void SetWidth(double value)
        {
            _width = value;
        }

        public double GetLength()
        {
            return _length;
        }

        public void SetLength(double value)
        {
            if (value < 0)
            {
                value = Math.Abs(value);
            }
            _length = value;
        }

        public Squareness(double width,double length)
        {
            SetWidth(width);
            SetLength(length);
        }
        public Squareness() { }

        public override double GetArea() => GetLength() * GetWidth();

        public override double GetPerimeter() => 2 * (GetWidth() + GetLength());
    }

}
