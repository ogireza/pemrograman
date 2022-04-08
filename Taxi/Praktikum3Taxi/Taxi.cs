using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum3Taxi
{
    class Taxi
    {
        // PROPERTIES //
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }
        
        
        public void TaxiInfo() //METHOD
        {
            Console.WriteLine("Driver Information\n");
            Console.WriteLine("Driver Name          : {0}", DriverName);
            Console.WriteLine("ON DUty              : {0}", OnDuty);
            Console.WriteLine("Number of Passenger  : {0}", NumPassenger);
        }

        public void PickUpPassanger() //METHOD
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }

        public void DropOffPassagner() //METHOD
        {
            Console.WriteLine("{0} selesai menganmtar penumpang", DriverName);
        }
    }
}
