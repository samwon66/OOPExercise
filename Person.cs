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
            { if (age > 0)
                { age = Age; }
                else 
                { Console.WriteLine("Age have to be greater than 0."); }
            } 
        }
        public string FName { get; set; }
        public string LName { get; set; }
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
