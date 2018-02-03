using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_里式转换
{
    public enum Gender
    {
        male,
        female
    }
    class Program
    {
        static void Main(string[] args)
        {
            //子类可以赋值给父类：
            //如果有一个地方需要一个父类作为参数，我们可以给一个子类作为代替 （例如string.Join()；里面要求我们放object[]数组，即父类数组，我们可以给子类数组）
            Person zsPerson = new Student("张三", 12, Gender.male);
            zsPerson.SayHi();
            Console.WriteLine("--------------------------------");

            //如果父类中装的是子类对象，那么可以将这个父类强转为子类对象。
            Student zsStudent = (Student)zsPerson;
            zsStudent.Study();
            Console.WriteLine("--------------------------------");

            //子类对象可以调用父类中的成员，但是父类对象永远都只能调用自己的成员。

            //is：表示类型转换，如果能够转换成功，则返回一个true，否则返回一个false
            Person liPerson = new Student();
            if (liPerson is Student)
            {
                Console.WriteLine("转换成功{0}",liPerson is Student);
            }
            else
            {
                Console.WriteLine("转换失败{0}",liPerson is Student);
            }
            Console.WriteLine("--------------------------------");

            //as：表示类型转换，如果能够转换则返回对应的对象，否则返回一个null
            Person wwPerson = new Student("王舞",-8,Gender.female);
            Student wwStudent = wwPerson as Student;
            if (wwStudent == null)
            {
                Console.WriteLine("转换失败{0}",wwStudent);
            }
            else
            {
                Console.WriteLine("转换成功");
                wwStudent.Study();
            }


            Console.ReadKey();

        }
    }
    class Person
    {
        private string _name;
        private int _age;
        public Gender Gender { get; set; }

        public string Name { get => _name; set => _name = value; }

        public int GetAge()
        {
            return _age;
        }

        public void SetAge(int value)
        {
            if (value < 0 || value > 200)
            {
                value = 0;
            }
            _age = value;
        }

        public Person(string name, int age, Gender gender)
        {
            Name = name;
            SetAge(age);
            Gender = gender;
        }

        public Person()
        {
        }

        public void SayHi()
        {
            Console.WriteLine("Hi,my name is {0}.I'm {1} years old.I'm a {2}.", Name, GetAge(), Gender);
        }
    }
    class Student : Person
    {
        public Student(string name,int age,Gender gender) : base(name, age, gender)
        {

        }
        public Student() { }

        public void Study()
        {
            SayHi();
            Console.WriteLine("I'm a Student");
        }
    }

}
