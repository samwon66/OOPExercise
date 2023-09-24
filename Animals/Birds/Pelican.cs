using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise.Animals.Birds
{
    internal class Pelican : Bird
    {
        public bool IsMigratory { get; set; }
        public Pelican() { }

        public override string Stats()
        {
            return $"Name: {Name}, age: {Age}, weight: {Weight}, can fly: {CanFly}, is migratory: {IsMigratory}";
        }

    }
}
