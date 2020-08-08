using System;
using System.Collections.Generic;
using System.Text;

namespace LegoBuilder.Parts
{
    class Torso
    {


        // properties
        
        public bool _wearingVest { get; set; }





        // fields





        // constructor

        public Torso()
        {
            //Console.WriteLine("Inside your Torso constructor...");
        }





        // methods

        public static void haveExtraSupplies (bool _wearingVest)
        {
            if (_wearingVest)
            {
                Console.WriteLine("\"I came prepared,\" he said while tapping the bulging vest pockets.");
            }
            else
            {
                Console.WriteLine("\"I should have brought my vest.\"");
            }
        }


    }
}
