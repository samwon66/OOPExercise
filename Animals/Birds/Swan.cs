﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise.Animals.Birds
{
    internal class Swan : Bird
    {
        public bool CanSwim { get; set; }
        public Swan() { }

        public override string Stats()
        {
            return $"Name: {Name}, age: {Age}, weight: {Weight}, can fly: {CanFly}, can swim: {CanSwim}";
        }

    }
}
