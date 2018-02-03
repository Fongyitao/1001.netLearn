using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_BufferedStream
{
    class Program
    {
        static void Main(string[] args)
        {
            using (BufferedStream bsRead = new BufferedStream(new FileStream(@"D:\Silverlight4.exe", FileMode.OpenOrCreate, FileAccess.Read)))
            {
                using (BufferedStream bsWrite = new BufferedStream(new FileStream(@"D:\TEST\Silverlight4.exe", FileMode.OpenOrCreate,FileAccess.Write)))
                {
                    byte[] buffer = new byte[bsRead.Length];
                    for (int len;(len = bsRead.Read(buffer,0,buffer.Length)) > 0;)
                    {
                        bsWrite.Write(buffer, 0, len);
                    }
                }
            }
            Console.WriteLine("done");
            Console.ReadKey();
        }
    }
}
