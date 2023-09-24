using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise.Animals
{
    internal abstract class Animal
    {
        //Ett nytt attribut ska vara här om det ska gälla för alla som tillhör denna klass.
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public Animal() { }

        public virtual void DoSound() 
        {
            Console.WriteLine("That's how animal sounds.");
        }

    }
}
