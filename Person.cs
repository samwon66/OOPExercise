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
        private string fName = String.Empty;
        private string lName = String.Empty;
        private int height;
        private int weight;

        public int Age 
        { 
            get { return age; } 
            set
            {
                if (Age > 0)
                { age = Age; }
                else
                { Console.WriteLine("Ålder måste vara större än 0."); }
            } 
        }
        public string FName
        {
            get { return fName; }
            set 
            { 
                if (String.IsNullOrEmpty(FName) || FName.Length < 2 || FName.Length > 10 )
                {
                    Console.WriteLine("Förnamnet är obligatoriskt, måste vara längre än 2 tecken eller kortare än 10 tecken.");
                }
                else
                {
                    fName = FName;
                }
            }
        }
        public string LName
        {
            get { return lName; }
            set
            {
                if (String.IsNullOrEmpty(LName) || LName.Length < 3 || LName.Length > 15)
                {
                    Console.WriteLine("EFternamnet är obligatoriskt, måste vara längre än 3 tecken eller kortare än 15 tecken.");
                }
                else
                {
                    lName = LName;
                }
            }
        }
        public int Height { get; set; }
        public int Weight { get; set; }

        public Person(int age, string fName, string lName, int height, int weight) 
        {
            Age = age;
            FName = fName;
            LName = lName;
            Height = height;
            Weight = weight;
        }


    }
}
