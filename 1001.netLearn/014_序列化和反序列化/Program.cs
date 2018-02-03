using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _014_序列化和反序列化
{
    public enum Gender
    {
        female,
        male
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person zsPerson = new Person("Jack", 18, Gender.male);
            // 序列化对象
            using (FileStream fsWrite = new FileStream(@"D:\test\zsPerson序列化.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter bf1 = new BinaryFormatter();
                bf1.Serialize(fsWrite, zsPerson);
            }

            Person p;//接收序列化的对象
            using (FileStream fsRead = new FileStream(@"D:\test\zsPerson序列化.txt",FileMode.Open,FileAccess.Read))
            {
                BinaryFormatter bf2 = new BinaryFormatter();
                p = bf2.Deserialize(fsRead) as Person;
            }
            p.SayHi();
            Console.ReadKey();
        }
    }

    [Serializable]
    class Person
    {
        private string _name;
        private int _age;
        private Gender _gengder;

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public Gender Gengder { get => _gengder; set => _gengder = value; }

        public Person(string name, int age, Gender gengder)
        {
            Name = name;
            Age = age;
            Gengder= gengder;
        }

        public Person()
        {
        }

        public void SayHi()
        {
            Console.WriteLine("Hello,my name is {0},I'm {1} years old. I'm a {2}",Name,Age,Gengder);
        }
    }
}
