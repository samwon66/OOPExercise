﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise.Errors
{
    internal abstract class UserError
    {
        public virtual string UEMessage()
        {
            return "message";
        }
    }
}