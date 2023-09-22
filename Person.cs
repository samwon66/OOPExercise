using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise
{
    public class Person
    {
        public int Age { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        

        //Method for validating properties and return a bool value.
        public bool Validate()
        {
            bool validated = true;

            if (Age <= 0)
            {
                throw new ArgumentException("Ålder måste vara större än 0.");
            }
            else 
            { 
                return validated; 
            }
            
        }

        //Override ToString to print out all properties of the class.
        public override string ToString()
        {
            return $"Förnamn: {FName}\nEfternamn: {LName}\nÅlder: {Age}\nLängd: {Height}\nVikt: {Weight}";
        }


    }
}
