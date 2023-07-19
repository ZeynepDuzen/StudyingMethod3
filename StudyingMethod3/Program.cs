using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyingMethod3
{
    internal class Program
    {
        static void MyMethod()
        {
            Console.WriteLine("I created a method");
        }

        static void Main(string[] args)
        {
            MyMethod();
            MyMethod();
            MyMethod();
            MyMethod();
            MyMethod();

            Console.Read();
        }
    }
}
