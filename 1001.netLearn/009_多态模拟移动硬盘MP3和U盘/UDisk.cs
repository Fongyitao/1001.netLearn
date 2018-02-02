using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_多态模拟移动硬盘MP3和U盘
{
    class UDisk : MoblieStorage
    {
        public override void Read()
        {
            Console.WriteLine("U盘读入数据");
        }

        public override void Write()
        {
            Console.WriteLine("U盘写入数据");
        }
    }
}
