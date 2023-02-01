using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    interface IStudent
    {
        int StudentID { get; set; }
        string Name { get; set; }
        void ShowDetails();
    }

    class DayScholar : IStudent
    {
        public int StudentID { get; set; }
        public string Name { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine("Student ID: " + StudentID);
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Student is a Day Scholar");
            Console.WriteLine();
        }
    }

    class Resident : IStudent
    {
        public int StudentID { get; set; }
        public string Name { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine("Student ID: " + StudentID);
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Student is a Resident");
            Console.WriteLine();
        }
    }

    class Interface
    {
        public static void Main()
        {
            DayScholar ds = new DayScholar();
            ds.StudentID = 2001;
            ds.Name = "Hasnain";
            ds.ShowDetails();
            Resident rs = new Resident();
            rs.StudentID = 2002;
            rs.Name = "Abbas";
            rs.ShowDetails();
            Console.Read();
        }
    }
}
