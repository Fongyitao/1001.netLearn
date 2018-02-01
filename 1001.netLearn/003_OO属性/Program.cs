using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_OO属性
{
    class Program
    {
        static void Main(string[] args)
        {
            Person zsPerson = new Person();
            zsPerson.Name = "张三";
            zsPerson.Age = -1;
            zsPerson.Gender = '春';

            zsPerson.SayHi();

            Person lsPerson = new Person("李四", -2, '夏');
            lsPerson.SayHi();

            Person wwPerson = new Person()
            {
                Name = "王舞",
                Age = 600,
                Gender='女'
            };
            wwPerson.SayHi();
            Console.ReadKey();
        }
    }
}
