using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_显示实现接口
{
    class Program
    {
        static void Main(string[] args)
        {
            IFlyable fly = new Bird();
            fly.fly();

            Bird b = new Bird();
            b.fly();
            Console.ReadKey();
        }
    }
}
