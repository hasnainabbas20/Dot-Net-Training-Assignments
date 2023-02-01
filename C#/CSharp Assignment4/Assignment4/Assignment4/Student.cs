using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    abstract class Student
    {
        public string Name, StudentID;
        public double Grade;

        public abstract bool Ispassed(double grd);
    }

    class UnderGraduate : Student
    {
        public override bool Ispassed(double grd)
        {
            if(grd > 70.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Graduate : Student
    {
        public override bool Ispassed(double grd)
        {
            if(grd > 80.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class AbstractMain
    {
        static void Main()
        {
            Console.WriteLine("Enter Student Details:");
            Console.Write("U for UnderGraduation/G for Graduation: "); string stype = Console.ReadLine();
            Console.Write("Name: "); string sname = Console.ReadLine();
            Console.Write("ID: "); string sid = Console.ReadLine();
            Console.Write("Grade: "); double sgrade = double.Parse(Console.ReadLine());

            Student s;
            if (stype.ToUpper() == "U")
            {
                s = new UnderGraduate();
            }
            else
            {
                s = new Graduate();
            }

            s.Name = sname;
            s.StudentID = sid;
            s.Grade = sgrade;
            Console.WriteLine("\n------------------------------\n");
            if (s.Ispassed(sgrade))
            {
                Console.WriteLine("Result: Passed");
            }
            else
            {
                Console.WriteLine("Result: Failed");
            }
            Console.ReadLine();
        }
    }
}
