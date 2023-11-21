using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDatabase
{
    internal class Employee
    {
        private int id;
        private string name; 
        private string position;

        public Employee(int id, string name, string position)
        {
            this.id = id;
            this.name = name;
            this.position = position;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Position { get => position; set => position = value; }
        public override string ToString()
        {
            return $"{this.name}, id: {this.id}, pozicio: {this.position}";
        }
    }
}
