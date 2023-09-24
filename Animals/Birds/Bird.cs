using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise.Animals.Birds
{
    internal class Bird : Animal
    {
        //Ett nytt attribut ska vara här hos Bird om det ska gällas för alla som tillhör den här klassen.
        public bool CanFly { get; set; }
        public Bird() { }

        public override void DoSound()
        {
            Console.WriteLine("The bird tweets.");
        }
    }
}
