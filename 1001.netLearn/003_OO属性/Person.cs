using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_OO属性
{
    class Person
    {
        private string _name;
        private int _age;
        private char _gender;
        public string Name { get => _name; set => _name = value; }
        public int Age
        {
            get
            {
                if (_age > 200 || _age < 0)
                {
                    _age = 0;
                }
                return _age;
            }
            set => _age = value;
        }
        public char Gender
        {
            get => _gender;
            set
            {
                if (value != '男' && value !='女')
                {
                    value = '男';
                }
                _gender = value;
            }
        }
        public Person() { }
        public Person(string name, int age,char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public void SayHi()
        {
            Console.WriteLine("大家好，我是{0}，我今年{1}岁了，我是{2}生，我来自中国。",this.Name,this.Age,this.Gender);
        }
    }
}
