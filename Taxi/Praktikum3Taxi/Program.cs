using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum3Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek taxi
            Taxi taxi = new Taxi();

            // pengisian nilai properties
            taxi.DriverName = "Jono";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            //pemanggilan method

            taxi.TaxiInfo();
            taxi.PickUpPassanger();
            taxi.DropOffPassagner();

            Console.ReadKey();
        }
    }
}
