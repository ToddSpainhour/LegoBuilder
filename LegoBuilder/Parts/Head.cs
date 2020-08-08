using System;
using System.Collections.Generic;
using System.Text;

namespace LegoBuilder
{
    class Head
    {






        // properties

        public string Hair { get; set; }
        public string Name { get; set; }








        // fields

        public bool _usingBinoculars = false;










        // constructor

        public Head()
        {
            //Console.WriteLine("inside your head constructor.");
        }









        // methods

        public void MagnifyVision(bool _usingBinoculars)
        {
            if (_usingBinoculars)
            {
                Console.WriteLine("\"I can see much further when using binoculars,\" he said.");
            }
            else
            {
                Console.WriteLine("\"I can't see that far,\" he said. \"I should use my binoculars.\"");
            }
        }



    }
}
