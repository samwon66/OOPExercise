using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise.Animals
{
    internal class Wolfman : Wolf, IPerson
    {
        public void Talk()
        {
            Console.WriteLine("Wolfman can talk.");
        }
    }
}
