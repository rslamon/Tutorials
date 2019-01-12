using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Tutorial11
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList Code

            //ArrayList alist = new ArrayList();
            //alist.Add("Bob");
            //alist.Add(40);

            //Console.WriteLine("Count : {0}", alist.Count);

            //Console.WriteLine("Capacity : {0}", alist.Capacity);

            //ArrayList alist2 = new ArrayList();

            //alist2.AddRange(new object[] { "Mike", "Sally", "Egg" });

            //alist.AddRange(alist2);
            //alist2.Sort();
            //alist2.Reverse();

            //alist2.Insert(1, "Turkey");

            //ArrayList range = alist2.GetRange(0, 2);

            //foreach(object o in range)
            //{
            //    Console.WriteLine(o);
            //}
            ////alist2.RemoveAt(0);

            ////alist2.RemoveRange(0, 2);

            //Console.WriteLine("Turkey : index {0}", alist2.IndexOf("Turkey", 0));

            //string[] myArray = (string[])alist2.ToArray(typeof(string));

            //string[] customers = { "Bob", "Sally", "Sue" };

            //ArrayList custArrayList = new ArrayList();

            //custArrayList.AddRange(customers);

            //foreach(string s in custArrayList)
            //{
            //    Console.WriteLine(s);
            //}
            #endregion

            #region Superhero

            //Dictionary<string, string> Superhereos = new Dictionary<string, string>();

            //Superhereos.Add("Clark Kent", "Superman");

            //Superhereos.Add("Bruce Wayne", "Batman");

            //Superhereos.Add("Barry West", "Flash");

            //Superhereos.Remove("Barry West");

            //Console.WriteLine("Count :{0}", Superhereos.Count);

            //Console.WriteLine("Clark Kent :{0}", Superhereos.ContainsKey("Clark Kent"));

            //Superhereos.TryGetValue("Clark Kent", out string test);

            //Console.WriteLine($"Clark Kent : {test}");

            //foreach(KeyValuePair<string,string>item in Superhereos)
            //{
            //    Console.WriteLine("{0} : {1}", item.Key,item.Value);

            //}
            //Superhereos.Clear();
            #endregion

            #region Queues
            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);


            //Console.WriteLine("1 in Queue :{0}", queue.Contains(1));

            //Console.WriteLine("Remove 1 :{0}", queue.Dequeue());

            //Console.WriteLine("Peek 1 :{0}", queue.Peek());

            //Object[] numArray = queue.ToArray();

            //Console.WriteLine(string.Join(",", numArray));

            //foreach (object o in queue)
            //{
            //    Console.WriteLine($"Queue : {o}");
            //}
            #endregion

            #region Stacks
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("Peek 1 : {0}", stack.Peek());

            Console.WriteLine("Pop 1 : {0}", stack.Pop());

            Console.WriteLine("Contains 1 : {0}", stack.Contains(1));

            Object[] numArray2 = stack.ToArray();

            Console.WriteLine(string.Join(", ", numArray2));

            //stack.Clear();

            foreach (object o in stack)
            {
                Console.WriteLine($"Stack : {o}");
            }

            #endregion
            Console.ReadLine();
        }
    }
}
