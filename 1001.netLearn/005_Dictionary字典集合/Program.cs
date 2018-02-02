using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Dictionary字典集合
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "John");
            dic.Add(3, "Jack");
            dic.Add(5, "Rose");
            foreach (var item in dic.Keys)
            {
                Console.WriteLine("{0}--{1}",item,dic[item]);
            }

            Console.WriteLine("---------------");
            //Dictionary<T,T>集合独有的遍历方式
            foreach (KeyValuePair<int,string> item in dic)
            {
                Console.WriteLine("{0}--{1}", item.Key, item.Value);
            }
            Console.ReadKey();
        }
    }
}
