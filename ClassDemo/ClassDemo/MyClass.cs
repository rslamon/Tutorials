using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class MyClass
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
            Console.WriteLine("Age={0}", Age);
        }

        public static void PrintFirstElement(int[] a)
        {
            Console.WriteLine("The first element is {0}. \n", a[0]);
        }

        public static void PrintFirstElementList(List<int> a)
        {
            Console.WriteLine("The first List element is {0}. \n", a[0]);
        }

        public static int[] ReturnUserInput()
        {
            int[] a = new int[3];

            for (int i = 0; i< a.Length; i++){
                Console.WriteLine("Enter an integer : ");
                a[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Integer added to arrary. \n");
               
            }
            
            return a;
        }

        public List<int> ReturnUserInputList()
        {
            List<int> a = new List<int>();

            int input;

            for(int i =0; i < 3; i++)
            {
                Console.WriteLine("Enter an integer : ");
                input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Integer added to list \n");
                a.Add(input);
            }
            return a;
        }

        public void PrintNames(params string[] names)
        {
            for(int i = 0; i < names.Length; i++)
            {
                Console.Write(names[i] + " ");

            }
            Console.WriteLine();
        }
    }
}
