﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasClassDanObject
{
    public class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        bool Duty = true;
        public int NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name: {0}", DriverName);
            Console.WriteLine("On Duty: {0}", Duty? "Yes" : "No");
            Console.WriteLine("Number Off Passenger: {0}", NumPassenger);

            Console.WriteLine();
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("{0} Sedang Menjemput Penumpang.\n", DriverName);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} Selesai Mengantar Penumpang.\n", DriverName);
        }
    }
}
