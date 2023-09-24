using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise.Errors
{
    internal class ValidError : UserError
    {
        public override string UEMessage()
        {
            return "You have entered an invalid input. This fire an error!";
        }
    }
}
