﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasClassTaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new TugasClassTaxi.Taxi();

            taxi.DriverName = "jarwo";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10 ;

            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
