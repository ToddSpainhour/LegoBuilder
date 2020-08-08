using System;
using System.Collections.Generic;
using System.Text;

namespace LegoBuilder.Parts
{
    class Arms
    {
        //properties
        public string armDescription { get; set; }

        //fields


        // constructor
        public Arms()
        {
            //Console.WriteLine("Inside your arms constructor");
        }

        // methods

        public void UseArms(string armDescription)
            {
            Console.WriteLine($"\"Do my arms look {armDescription}?\"");
            }
    }
}
