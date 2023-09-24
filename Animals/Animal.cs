using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise.Animals
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public Animal() { }

        public void DoSound() { }

    }
}
