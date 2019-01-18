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
            //-------------------------------------------------
            //MyClass classA = new MyClass();
            //Console.WriteLine(classA.message);
            //classA.Name = "Jamie";
            //classA.DisplayName();

            //Console.WriteLine(MyClass.greetings);
            //MyClass.Age = 39;
            //MyClass.DisplayAge();
            //-----------------------------------------------------------

            //int[] myArray = { 1, 2, 3, 4, 5 };
            //MyClass.PrintFirstElement(myArray);

            //List<int> myList = new List<int> { 1, 2, 3, 4, 5 };
            //MyClass.PrintFirstElementList(myList);

            //int[] myArray2 = MyClass.ReturnUserInput();

            MyClass my = new MyClass();

            // List<int> myList2 = my.ReturnUserInputList();

            //my.PrintNames("Peter");
            //my.PrintNames("Brian", "Meg");

            int a = 2;
            int[] b = {1,2,3 };
            MethodDemo obj = new MethodDemo();

            Console.WriteLine("a before = {0}", a);
            obj.PassByValue(a);
            Console.WriteLine("a after = {0}", a);

            Console.WriteLine("\n\n");
            Console.WriteLine("b[0] before = {0}", b[0]);
            obj.PassByReference(b);
            Console.WriteLine("b[0] after = {0}", b[0]);

            Console.ReadLine();

            

        }

       
    }

}
