using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _011_File类
{
    class Program
    {
        static void Main(string[] args)
        {
            //File.Create(@"E:\C11XX数据后台\C11XX数据后台\new.txt");//创建一个文件
            //File.Delete(@"E:\C11XX数据后台\C11XX数据后台\new.txt");//删除一个文件

            //File.Copy(@"E:\C11XX数据后台\C11XX数据后台\固定长度文本.txt", @"E:\C11XX数据后台\C11XX数据后台\Copy固定长度文本.txt");//复制文件
            //File.Move(@"E:\C11XX数据后台\C11XX数据后台\固定长度文本.txt", @"E:\C11XX数据后台\C11XX数据后台\Move固定长度文本.txt");//剪切文件

            byte[] buffer = File.ReadAllBytes(@"E:\C11XX数据后台\C11XX数据后台\固定长度文本.txt");
            //将字节数组中每一个元素都按照我们指定的编码格式转换成字符串
            string s = Encoding.GetEncoding("UTF-8").GetString(buffer);
            Console.WriteLine(s);

            string s1 = "今天天气好晴朗，处处好风光！";
            byte[] buffer1 = Encoding.UTF8.GetBytes(s1);
            //没有这个文件的话会创建一个，有的话会覆盖掉
            File.WriteAllBytes(@"E:\C11XX数据后台\C11XX数据后台\TEST.txt", buffer1);
            Console.ReadKey();
        }
    }
}
