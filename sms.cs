using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2
{
    public class SchoolM
    {
        public string title;
        public string firstname;
        public string lastname;

        public SchoolM(string firstname, string lastname, string title)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.title = title;
        }
    }



    public class Lecturer : SchoolM
    {
        public double salary;
        public int id;
        public Lecturer(int id, string title, string firstname, string lastname, double salary) : base(firstname, lastname, title)
        {
            this.id = id;
            this.salary = salary;
        }

        public void ViewDetails()
        {
            Console.WriteLine("\n\nTeacher Details");
            Console.WriteLine("Id: {0}", id);
            Console.WriteLine("Name: {0} {1} {2}", title, firstname, lastname);
            Console.WriteLine("Salary: {0}", salary);
        }
    }



    public class Student : SchoolM
    {
        public int id;
        public int age;
        public string studclass;
        public Student(int id, string title, string firstname, string lastname, int age, string studclass) : base(firstname, lastname, title)
        {
            this.id = id;
            this.age = age;
            this.studclass = studclass;
        }
        public void ViewDetails()
        {
            Console.WriteLine("\n\nStudent Details");
            Console.WriteLine("Id: {0}", id);
            Console.WriteLine("Name: {0} {1} {2}", title, firstname, lastname);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Class: {0}", studclass);
        }
    }



    public class Parent : SchoolM
    {
        public int studid;
        public Parent(string title, string firstname, string lastname, int studid) : base(firstname, lastname, title)
        {
            this.studid = studid;
        }

        public void ViewDetails()
        {
            Console.WriteLine("\n\nParent Details");
            Console.WriteLine("Name: {0} {1} {2}", title, firstname, lastname);
            Console.WriteLine("Your Child Id: {0}", studid);
        }
    }
}
