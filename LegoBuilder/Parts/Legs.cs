using System;
using System.Collections.Generic;
using System.Text;

namespace LegoBuilder.Parts
{
    class Legs
    {

        //properties
        public string LegColor { get; }



        // fields
        
        public string _legColor = "blue";

        // constructors

        public Legs()
        {
            //Console.WriteLine("Inside your legs constructor");
        }

        // methods

        public void Walk (string _legDescription)
        {
            if (_legDescription == "blue")
            {
                Console.WriteLine($"\"Let's get moving,\" he said as his {_legDescription} legs shuffled down the slope.");
            }
            else
            {
                Console.WriteLine($"\"Something seems different. Wait my legs are {_legDescription}!\"");
            }
        }

    }
}
