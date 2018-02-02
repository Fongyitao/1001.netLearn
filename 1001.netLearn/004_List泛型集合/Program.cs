using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_List泛型集合
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(5);
            list.Add(3);

            //遍历集合
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //list泛型集合装换成数组
            int[] nums = list.ToArray();
            foreach (var item in nums)
            {
                Console.WriteLine("{0}", item);
            }

            //char数组转成list集合
            char[] chs = { 'I', 'O', 'U' };
            List<char> listChar = chs.ToList();
            foreach (var item in listChar)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
