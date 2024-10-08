
using System;

namespace Program
{
    class StudentLibrary()
    {
        private int id;
        private string name;
        private int age;
        private static int Studentcount = 0;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int ID
        {
            get { return id; }
        }

        public static int StudentCount
        {
            get { return Studentcount; }
        }

        public void Details(int id, string name, int age, int studentCount)
        {
            this.name = "John Doe";
            this.age = 16;
            Studentcount = 1;
            this.id = Studentcount++;
        }

        public void Display()
        {
            Console.WriteLine(id);
            Console.WriteLine(name);
            Console.WriteLine(age);
        }

        public int GetOlder()
        {
            age = age++;
            return age;
        }
    }
}