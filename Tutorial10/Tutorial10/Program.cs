using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tutorial10
{
    interface IDrivable
    {
        int Wheels { get; set; }
        double Speed { get; set; }
        void Move();
        void Stop();


    }
}

    class Program
    {
        static void Main(string[] args)
        {
        Tutorial10.Vehicle Buick = new Tutorial10.Vehicle("Buick", 4, 160);

        if(Buick is Tutorial10.IDrivable)
        {
            Buick.Move();
            Buick.Stop();
        }
        else
        {
            Console.WriteLine("The {0}can't be driven", Buick.Brand);
        }

        Tutorial10.IElectronicDevice TV = Tutorial10.TVRemote.GetDevice();

        Tutorial10.PowerButton PowBut = new Tutorial10.PowerButton(TV);

        PowBut.Execute();
        PowBut.Undo();

        Console.ReadLine();
        }
    }

