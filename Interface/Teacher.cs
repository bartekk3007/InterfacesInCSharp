using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Teacher : IPersonal
    {
        string Name { get; set; }
        int Age { get; set; }
        public Teacher(string name, int age)
        {
            Name = name;
            Age = age;
        }
        void IPersonal.Introduce()
        {
            Console.WriteLine($"My name is {Name} and I am a teacher");
        }
        public void SayPersonal()
        {
            Console.WriteLine($"I am {Age} years old and I am a teacher");
        }
    }
}
