
using System;

namespace Program
{
    class Student()
    {
        int id;
        string name;
        int age;
        static int Studentcount = 0;

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