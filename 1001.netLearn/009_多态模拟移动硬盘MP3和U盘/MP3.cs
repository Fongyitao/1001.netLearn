using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_多态模拟移动硬盘MP3和U盘
{
    class MP3 : MoblieStorage
    {
        public override void Read()
        {
            Console.WriteLine("MP3读入数据");
        }

        public override void Write()
        {
            Console.WriteLine("MP3写入数据");
        }
    }
}
