using System;
using System.Diagnostics;
using System.IO;

namespace _002_打开文件练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入要打开文件的路径：");
            string filePath = Console.ReadLine();
            Console.WriteLine("请输入要打开的文件名");
            string fileName = Console.ReadLine();

            BaseFile bf = GetFile(filePath, fileName);
            if (bf!=null)
            {
                bf.OpenFile();
            }

        }
        static BaseFile GetFile(string filePath,string fileName)
        {
            BaseFile bf = null;
            string strExtension = Path.GetExtension(fileName);
            switch (strExtension)
            {
                case ".txt":
                    bf = new TxtFile(filePath, fileName);
                    break;
                default:
                    break;
            }
            return bf;
        }
    }

    class BaseFile
    {
        private string _filePath;

        public string FilePath { get => _filePath; set => _filePath = value; }
        public string FileName { get; set; }

        public BaseFile(string filePaht,string fileName)
        {
            this.FilePath = filePaht;
            this.FileName = fileName;
        }

        //设计一个打开文件的函数,//抛异常不知道什么问题
        public void OpenFile()
        {
            ProcessStartInfo psi = new ProcessStartInfo(this.FilePath + "\\" + this.FileName);
            Process pro = new Process();
            pro.StartInfo = psi;
            pro.Start();
        }
    }
    class TxtFile : BaseFile
    {
        public TxtFile(string filePaht, string fileName) : base(filePaht, fileName)
        {
        }
    }


}
