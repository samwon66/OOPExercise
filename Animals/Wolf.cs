using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise.Animals
{
    internal class Wolf : Animal   
    {
        public bool IsDangerous { get; set; }
        public Wolf() { }
        public override void DoSound()
        {
            Console.WriteLine("The wolf moans.");
        }

        public override string Stats()
        {
            return $"Name: {Name}, age: {Age}, weight: {Weight}, is Dangerous: {IsDangerous}";
        }
    }
}
