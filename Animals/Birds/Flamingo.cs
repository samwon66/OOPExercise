﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise.Animals.Birds
{
    internal class Flamingo : Bird
    {
        public string Color { get; set; }
        public Flamingo() { }

        public override string Stats()
        {
            return $"Name: {Name}, age: {Age}, weight: {Weight}, can fly: {CanFly}, color: {Color}";
        }

    }
}
