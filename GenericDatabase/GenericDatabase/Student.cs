using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDatabase
{
    internal class Student
    {
        private int id;
        private string name;
        private int age;

        public Student(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public override string ToString()
        {
            return $"{this.name}, id: {this.id}, kor: {this.age}";
        }
    }
}
