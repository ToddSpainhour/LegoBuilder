using LegoBuilder;
using LegoBuilder.Parts;
using System;

namespace LegoBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's assemble a Lego character!");
            Console.WriteLine('\n');





            var head = new Head()
            {
              Name = "Mr. Lego"
            };
            Console.WriteLine('\n');


            head.Hair = "green";

            Console.WriteLine($"Without {head.Name}'s hat, his {head.Hair} hair danced in the wind.");

            head.MagnifyVision(true);
            Console.WriteLine('\n');



            var torso = new Torso()
            {

            };
            Console.WriteLine('\n');


            Parts.Torso.haveExtraSupplies(true);
            Console.WriteLine('\n');





            var arms = new Arms();
            Console.WriteLine('\n');


            Console.WriteLine($"{head.Name} asked...");
            arms.UseArms("rectangular");
            Console.WriteLine('\n');


            var legs = new Legs()
            {
           
            };
            Console.WriteLine('\n');

            Console.WriteLine($"He looked down at his {legs._legColor} legs.");
            legs.Walk("stubby");

            






        }
    }
}
