using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tutorial16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread t = new Thread(Print1);
            //t.Start();

            //for (int i = 0; i < 1000; i++)
            //{
            //    Console.Write(0);
            //}

            //int num = 1;

            //for(int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(num);
            //    Thread.Sleep(1000);
            //    num++;
            //}
            //Console.WriteLine("Thead ends");

            //BankAcct acct = new BankAcct(10);

            //Thread[] threads = new Thread[15];

            //Thread.CurrentThread.Name = "main";

            ////for (int i=0; i < 15; i++)
            ////{
            ////    Thread t = new Thread(new ThreadStart(acct.IssueWithDraw));
            ////    t.Name = i.ToString();
            ////    threads[i] = t;

            ////}

            //for (int i = 0; i < 15; i++)
            //{
            //    // You can only point at methods
            //    // without arguments and that return 
            //    // nothing
            //    Thread t = new Thread(new
            //        ThreadStart(acct.IssueWithdraw));
            //    t.Name = i.ToString();
            //    threads[i] = t;
            //}

            //for (int i=0; i < 15; i++)
            //{
            //    // Check if thread has started
            //    Console.WriteLine("Thread {0} Alive : {1}",
            //        threads[i].Name, threads[i].IsAlive);

            //    // Start thread
            //    threads[i].Start();

            //    // Check if thread has started
            //    Console.WriteLine("Thread {0} Alive : {1}",
            //        threads[i].Name, threads[i].IsAlive);
            //}
            //Console.WriteLine("Current Priority {0}", Thread.CurrentThread.Priority);

            //Console.WriteLine("Thread {0} Ending", Thread.CurrentThread.Name);

            Thread t = new Thread(() => CountTo(10));
            t.Start();

            new Thread(() => { CountTo(5);CountTo(6); }).Start();

            Console.ReadLine();
        }

        static void CountTo( int maxNum)
        {
            for(int i =0; i <= maxNum; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Print1()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(1);
            }
            
        }
    }

    class BankAcct
    {
        private Object acctLock = new object();
        double Balance { get; set; }

        public BankAcct(double bal)
        {
            Balance = bal;

        }

        public double Withdraw(double amt)
        {
            if((Balance - amt) < 0)
            {
                Console.WriteLine($"Sorry.${Balance} in account");
                return Balance;
            }
            lock (acctLock)
            {
                if(Balance >= amt)
                {
                    Console.WriteLine("Removed{0} and {1} left in account",amt,(Balance-amt));
                    Balance -= amt;
                }
                return Balance;
            }

        }

        public void IssueWithdraw()
        {
            Withdraw(1);
        }
    }
}
