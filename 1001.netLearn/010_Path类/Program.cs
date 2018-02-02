using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Path类
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"E:\C11XX数据后台\C11XX数据后台\固定长度文本.txt";
            Console.WriteLine(Path.GetFileName(filePath));//获得文件名和扩展名
            Console.WriteLine("=================");
            Console.WriteLine(Path.GetFileNameWithoutExtension(filePath));//只获得文件名不包括扩展名
            Console.WriteLine("=================");
            Console.WriteLine(Path.GetExtension(filePath));//只获得扩展名,不包括文件名
            Console.WriteLine("=================");
            Console.WriteLine(Path.GetDirectoryName(filePath));//获得文件所在文件夹名
            Console.WriteLine("=================");
            Console.WriteLine(Path.GetFullPath(filePath));//文件绝对路径,全路径
            Console.WriteLine("=================");
            Console.WriteLine(Path.Combine(@"D:\a", @"b.txt"));//连接两个字符串作为路径
            Console.ReadKey();
        }
    }
}
