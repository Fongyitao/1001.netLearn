using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_进程
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ProcessStartInfo psi = new ProcessStartInfo(@"D:\test.txt");
            Process pro = new Process();
            pro.StartInfo = psi;
            pro.Start();
            Console.ReadKey();
        }
    }
}
