using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_多态模拟移动硬盘MP3和U盘
{
    class Program
    {
        static void Main(string[] args)
        {
            //用多态来实现,移动硬盘  U盘  MP3插到电脑上读写数据
            //由于子类读写方式不一样,所以使用抽象类

            Computer cpu1 = new Computer(new UDisk());
            cpu1.ComputerRead();
            cpu1.ComputerWrite();

            Console.ReadKey();
        }
    }
}
