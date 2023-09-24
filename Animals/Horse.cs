using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise.Animals
{
    internal class Horse : Animal
    {
        public bool CanRide { get; set; }
        public Horse() { }
        public override void DoSound()
        {
            Console.WriteLine("The horse make a neigh.");
        }
    }
}
