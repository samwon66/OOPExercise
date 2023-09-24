using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise.Animals
{
    internal class Hedgehog: Animal
    {
        public int NrOfSpikes { get; set; }
        public Hedgehog() { }
        public override void DoSound()
        {
            Console.WriteLine("The hedgehog purrs.");
        }

        public override string Stats()
        {
            return $"Name: {Name}, age: {Age}, weight: {Weight}, number of spikes: {NrOfSpikes}";
        }
    }
}
