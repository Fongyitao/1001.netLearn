using System;
using System.Diagnostics;

namespace _001.进程
{
    class Program
    {
        static void Main(string[] args)
        {
            //Process.Start("explorer", "https://www.baidu.com");
            //Process.Start("notepad","test.txt");//有这个文件就打开，没有就创建

            //Process[] pros = Process.GetProcesses();
            //foreach (var item in pros)
            //{
            //    Console.WriteLine(item.ProcessName);
            //}

            Process pro = new Process();
            ProcessStartInfo psi = new ProcessStartInfo("test.txt");
            pro.StartInfo = psi;
            pro.Start();
            
            Console.ReadKey();
        }
    }
}
