using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise.Animals
{
    internal class Dog : Animal
    { 
        public bool HumanFriendly { get; set; }
        public Dog() { }

        public override void DoSound()
        {
            Console.WriteLine("The dog barks");
        }
    }
}
