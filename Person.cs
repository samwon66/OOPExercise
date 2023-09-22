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
        public void ValidateAge(int age)
        {

            if (age <= 0)
            {
                throw new ArgumentException("Ålder måste vara större än 0.");
            }
            //return validated;
        }

        public void NameIsNotEmpty(string name)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Namnet får inte vara tomt.");
            }
            //return validated;
        }

        public void NameIsValid(string name, int lowest, int highest)
        {
            if (name.Length < lowest || name.Length > highest)
            {
                throw new ArgumentException($"Namnet måste vara längre än {lowest} eller kortare {highest}.");
            }
            //return validated;
        }

        public bool ValidateProp(int age, string fName, string lName)
        {
            bool validated = true;
            ValidateAge(Age);
            NameIsNotEmpty(FName);
            NameIsValid(FName, 2, 10);
            NameIsNotEmpty(LName);
            NameIsValid(LName, 3, 15);
            return validated;
        }
            //if (!string.IsNullOrWhiteSpace(LName))
            //{
            //    if (LName.Length < 2 || LName.Length > 10) 
            //    {
            //        throw new ArgumentException("Namnet måste vara längre än 2 eller kortare än 10 tecken.");
            //    }

            //}


            //if (String.IsNullOrWhiteSpace(LName))
            //{
            //    throw new ArgumentException("Du måste ha ett efternamn.");
            //}
            //else if (LName.Length < 3 || LName.Length > 15)
            //{
            //    throw new ArgumentException("Namnet måste vara längre än 3 och kortare än 15 tecken.");
            //}
       

        //Override ToString to print out all properties of the class.
        public override string ToString()
        {
            return $"Förnamn: {FName}\nEfternamn: {LName}\nÅlder: {Age}\nLängd: {Height}\nVikt: {Weight}";
        }


    }
}
