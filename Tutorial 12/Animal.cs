﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_12
{
    class Animal
    {
        public string Name{ get; set; }

        public Animal(string name ="No Name")
        {
            Name = Name;
        }
        //Generics T = Data Type
        public static void GetSum<T>(ref T num1, ref T num2)
        {
            double dblX = Convert.ToDouble(num1);

            double dblY = Convert.ToDouble(num2);

            Console.WriteLine($"{dblX} + {dblY} = {dblX + dblY}");
        }
    }
}