using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise.Animals
{
    internal class Worm : Animal
    {
        public bool CanDig {  get; set; }
        public Worm() { }
        public override void DoSound()
        {
            Console.WriteLine("The worm sounds nothing.");
        }

    }
}
