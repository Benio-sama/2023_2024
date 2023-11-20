using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DatabaseManager<Student> students = new DatabaseManager<Student>();
            DatabaseManager<Book> books = new DatabaseManager<Book>();
            DatabaseManager<Employee> employees = new DatabaseManager<Employee>();

            students.AddRecord(new Student(3, "tomi", 21));
            students.AddRecord(new Student(3, "asd", 14));
            students.AddRecord(new Student(1, "mici", 19));
            students.AddRecord(new Student(4, "bali", 24));

            employees.AddRecord(new Employee(1, "marton", "ceo"));
            employees.AddRecord(new Employee(2, "mate", "cto"));
            employees.AddRecord(new Employee(3, "kata", "trainee"));

            books.AddRecord(new Book(1, "asd", "asd"));
            books.AddRecord(new Book(2, "dsa", "dsa"));
            books.AddRecord(new Book(3, "ewq", "qwe"));

            books.RemoveRecord(1);
            students.GetRecord(3);

            students.PrintDatabase();
            books.PrintDatabase();
            employees.PrintDatabase();

            Console.ReadKey();
        }
    }
}
