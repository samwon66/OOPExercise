using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise
{
    public class Person
    {
        private int age;
        private string fName;
        private string lName;
        private int height;
        private int weight;

        public int Age 
        { 
            get { return age; } 
            set { age = Age; }
         }
        public string FName
        {
            get { return fName; }
            set { fName = FName; }
        }
        public string LName
        {
            get { return lName; }
            set { lName = LName; }
        }
        public int Height
        {
            get { return height;}
            set { height = Height;}
        }
        public int Weight
        {
            get { return weight;}
            set { weight = Weight;}
        }

        public Person(int age, string fName, string lName, int height, int weight) 
        {
            Age = age;
            FName = fName;
            LName = lName;
            Height = height;
            Weight = weight;
        }

        //Method for validating properties and return a bool value.
        public bool Validate()
        {
            bool validated = true;

            if (Age <= 0)
            {
                throw new ArgumentException("Ålder måste vara större än 0.");
            }
            if (!String.IsNullOrEmpty(FName))
            {
                if(FName.Length < 2 || FName.Length > 10)
                {
                    throw new ArgumentException("Förnamnet måste vara längre än 2 tecken och kortare än 10 tecken.");
                }
            }
            if (!String.IsNullOrEmpty(LName)) 
            { 
                if (LName.Length < 3 || LName.Length > 15)
                {
                    throw new ArgumentException("Efternamnet måste vara längre än 3 och kortare än 15 tecken.");
                }
            }
            return validated;
        }


    }
}
