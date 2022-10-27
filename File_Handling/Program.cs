using System;
using System.Text;
using System.Linq;
using System.IO;

namespace File_Handling
{
    class Person
    {
        // Attributes
        private string firstName;
        private string lastName;
        private string filename = "People.txt";
        private int age;

        // Class constructor
        public Person(string nFirstname, string nLastname, int nAge)
        {
            this.firstName = nFirstname;
            this.lastName = nLastname;
            this.age = nAge;
        }

        // Save information to a file
        public void Save()
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine($"Name: {firstName}, Surname: {lastName}, Age: {age}");
            sw.Close();
        }
        // Get information from a file
        public string View()
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string txt = sr.ReadToEnd();
            return txt;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Instance of a class
            Person p = new Person("Malakia", "Jeremia", 20);
            Console.WriteLine(p.View());
            
        }
    }
}