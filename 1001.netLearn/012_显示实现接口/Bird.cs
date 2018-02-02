using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_显示实现接口
{
    class Bird : IFlyable
    {
        public void fly()
        {
            Console.WriteLine("鸟儿自己的飞");
        }
        void IFlyable.fly()
        {
            Console.WriteLine("接口的飞");
        }
    }
}
