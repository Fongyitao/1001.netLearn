using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_多态之虚方法
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            虚方法
            1、将父类的方法标记为虚方法 ，使用关键字 virtual，这个函数可以被子类重新写一个遍(都是同一个函数名)。
            父类用virtual,子类方法用override
            使用虚方法，可以重写也可以不重写
            */

            Person[] pers = { new Chinese("张三"), new Korean("全智贤") };
            foreach (var item in pers)
            {
                item.SayHi();
            }

            Console.ReadKey();

        }
    }

    class Person
    {
        private string _name;

        public string Name { get => _name; set => _name = value; }

        public Person(string name)
        {
            this.Name = name;
        }
        public Person() { }

        public virtual void SayHi()
        {
            Console.WriteLine("大家好，我叫{0}",this.Name);
        }
    }

    class Chinese : Person
    {
        public Chinese(string name):base(name)
        {

        }
        public override void SayHi()
        {
            Console.WriteLine("大家好,我是中国人，我叫{0}", this.Name);
        }
    }
    class Korean : Person
    {
        public Korean(string name) : base(name)
        {

        }
        public override void SayHi()
        {
            Console.WriteLine("大家好,我是韩国人，我叫{0}", this.Name);
        }
    }
}
