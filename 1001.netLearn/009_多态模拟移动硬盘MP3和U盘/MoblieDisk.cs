using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_多态模拟移动硬盘MP3和U盘
{
    class MoblieDisk : MoblieStorage
    {
        public override void Read()
        {
            Console.WriteLine("移动硬盘读取数据");
        }

        public override void Write()
        {
            Console.WriteLine("移动硬盘写入数据");
        }
    }
}
