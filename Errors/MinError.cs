﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise.Errors
{
    internal class MinError : UserError
    {
        public override string UEMessage()
        {
            return "You have entered a number less than 3. This fire an error!";
        }
    }
}
