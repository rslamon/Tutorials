using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class MyClass1
    {

        //Non staic memebers
        public string message = "Hello World";
        public string Name { get; set; }

        public void DisplayName()
        {
            Console.WriteLine("Name = {0}", Name);
        }

        //static memebers

        public static string greetings = "Good Morning";
        public static int Age { get; set; }
        public static void DisplayAge()
        {
            Console.WriteLine("Age={0}",Age);
        }
    }
}
