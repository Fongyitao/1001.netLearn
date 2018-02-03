using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_FileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                FileStream 操作字节,可以操作任何文件
                StreamReader和StreamWriter //操作字符,文本
            */
            //FileStream 操作字节的
            FileStream fsRead = new FileStream(@"D:\test.txt", FileMode.OpenOrCreate, FileAccess.Read);
            byte[] buffer = new byte[1024 * 1024 * 5];
            int r = fsRead.Read(buffer, 0, buffer.Length);
            //将字节数组中的字节按照指定编码解码
            string str = Encoding.UTF8.GetString(buffer,0,r);//仅解码有效字节
            fsRead.Close();//关闭字节流
            fsRead.Dispose();//释放资源

            Console.WriteLine(str);

            //将创建文件流对象的过程写在using当中，会自动的帮助我们释放流所占用的资源。
            //使用FileStream来写入数据
            using (FileStream fsRead1 = new FileStream(@"D:\test.txt", FileMode.OpenOrCreate, FileAccess.Read)) //创建一个负责读的流对象
            {
                using(FileStream fsWrite = new FileStream(@"D:\test1.txt", FileMode.OpenOrCreate, FileAccess.Write))//创建一个负责写的流对象
                {
                    byte[] buffer1 = new byte[1024 * 1024];
                    //while (true)
                    //{
                    //    int n = fsRead1.Read(buffer1, 0, buffer1.Length);
                    //    if (n == 0)
                    //    {
                    //        break;
                    //    }
                    //    fsWrite.Write(buffer1, 0, n);

                    //}


                    for (int len ;(len = fsRead1.Read(buffer1,0,buffer1.Length)) != -1;)
                    {
                        fsWrite.Write(buffer1, 0, count: len);
                    }
                    
                }

            }

        }
    }
}
