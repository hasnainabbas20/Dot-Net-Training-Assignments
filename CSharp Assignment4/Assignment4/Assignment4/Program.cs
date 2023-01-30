using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Concession;

namespace Assignment4
{
    class Program
    {
        string Name;
        int Age;
        static void Main()
        {
            Program p = new Program();
            Fare f = new Fare();
            Console.Write("Enter Name: "); p.Name = Console.ReadLine();
            Console.Write("Enter Age: "); p.Age = int.Parse(Console.ReadLine());
            f.CalculateConsession(p.Age);
            Console.Read();
        }
    }
}
