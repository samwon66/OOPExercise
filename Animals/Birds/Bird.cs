using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise.Animals.Birds
{
    internal class Bird : Animal
    {
        public bool CanFly { get; set; }
        public Bird() { }

        public override void DoSound()
        {
            Console.WriteLine("The bird tweets.");
        }
    }
}
