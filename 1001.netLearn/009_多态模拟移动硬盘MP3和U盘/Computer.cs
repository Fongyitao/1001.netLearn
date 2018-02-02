using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_多态模拟移动硬盘MP3和U盘
{
    class Computer
    {
        private MoblieStorage _ms;

        internal MoblieStorage Ms { get => _ms; set => _ms = value; }

        public Computer(MoblieStorage ms) => Ms = ms;

        public Computer()
        {
        }

        public void ComputerRead()
        {
            Ms.Read();
        }
        public void ComputerWrite()
        {
            Ms.Write();
        }
    }
}
