using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_多态模拟移动硬盘MP3和U盘
{
    abstract class MoblieStorage
    {
        public abstract void Read();
        public abstract void Write();
    }
}
