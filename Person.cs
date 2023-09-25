using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise
{
    public class Person
    {
        
        public int Age { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }



        //A collections of functions for validating properties and return a bool value.
        public bool ValidateProp(int age, string fName, string lName)
        {
            bool validated = true;
            int minFName = 2, maxFName = 10, minLName = 3, maxLName = 15;
            
            ValidateAge(Age);
            NameIsNotEmpty(FName);
            NameIsValid(FName, minFName, maxFName);
            NameIsNotEmpty(LName);
            NameIsValid(LName, minLName, maxLName);
            return validated;
        }
     
        //Check if age less than 0.
        public void ValidateAge(int age)
        {
            const int minimum = 0;
            
            if (age <= minimum)
            {
                throw new ArgumentException($"Age have to been greater than {minimum}.");
            }
        }

        //Check if the string is empty.
        public void NameIsNotEmpty(string name)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name can not be empty.");
            }
        }

        //Check the length of the string meets requirement by sending in the highest and the lowest number.
        public void NameIsValid(string name, int lowest, int highest)
        {
            if (name.Length < lowest || name.Length > highest)
            {
                throw new ArgumentException($"The name has to been more than {lowest} or shorter than {highest}.");
            }
        }


        //Override ToString to print out all properties of the class.
        public override string ToString()
        {
            return $"Forname: {FName}\nLastname: {LName}\nAge: {Age}\nHeight: {Height}\nWeight: {Weight}";
        }


    }
}
