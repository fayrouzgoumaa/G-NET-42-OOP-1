using System.ComponentModel;
using System.Numerics;
using System.Runtime.Intrinsics.X86;

namespace G_NET_42_OOP_1
{
    class PersonClass
    {
        public string Name;
    }
    struct PersonStruct
    {
        public string Name;
    }
    class Student
    {
        public string Name;      // Accessible everywhere
        private int Age;         // Only accessible inside this class

        public void SetAge(int age)
        {
            Age = age;
        }

        public int GetAge()
        {
            return Age;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            // CLASS behavior
            PersonClass p1 = new PersonClass();
            p1.Name = "Fayrouz";

            PersonClass p2 = p1;  // Copies reference
            p2.Name = "Goumaa";

            Console.WriteLine(p1.Name); // Output: Goumaa


            // STRUCT behavior
            PersonStruct s1;
            s1.Name = "Fayrouz";

            PersonStruct s2 = s1; // Copies value
            s2.Name = "Goumaa";

            Console.WriteLine(s1.Name); // Output: Fayrouz
            #endregion
            #region Q2

            Student s = new Student();

            s.Name = "Fayrouz";   // Allowed
                                  // s.Age = 20;        // ERROR (private)

            s.SetAge(20);         // Correct way

            Console.WriteLine(s.Name);
            Console.WriteLine(s.GetAge());
            #endregion
            #region Q3
            //1-Create it
            //Write your classes
            //Build it
            //Add reference to another project
            //Use the classes normally
            #endregion
            #region Q4
            //A Class Library is a project that contains reusable classes and methods compiled into a.dll file that can be used by other projects.
            //Why We Use Class Libraries
            //    Code Reusability
            //    Separation of Concerns
            //    Maintainability
            #endregion
        }
    }
}
