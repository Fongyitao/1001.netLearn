using System;
using System.Diagnostics;

namespace _001.进程
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Process.Start("explorer", "www.baidu.com");
        }
    }
}
