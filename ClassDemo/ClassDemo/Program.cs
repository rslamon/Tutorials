using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int pay;

            //Staff staff1 = new Staff("Peter");
            //staff1.HoursWorked = 160;
            //pay = staff1.CalculatePay(1000, 400);
            //Console.WriteLine("Pay = {0}",pay);

            //Staff staff2 = new Staff("Jane");
            //staff2.HoursWorked = 160;
            //pay = staff2.CalculatePay();
            //Console.WriteLine("Pay = {0}", pay);

            //Staff staff3 = new Staff("Carol");
            //staff3.HoursWorked = -10;
            //pay = staff3.CalculatePay();
            //Console.WriteLine("Pay = {0}", pay);

            MyClass1 classA = new MyClass1();
            Console.WriteLine(classA.message);
            classA.Name = "Jamie";
            classA.DisplayName();

            Console.WriteLine(MyClass1.greetings);
            MyClass1.Age = 39;
            MyClass1.DisplayAge();

            Console.ReadLine();


        }
    }
}
