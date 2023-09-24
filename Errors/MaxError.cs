using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise.Errors
{
    internal class MaxError : UserError
    {
        public override string UEMessage()
        {
            return "You have entered a number greater than 10. This fire an error!";
        }
    }
}
