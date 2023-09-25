using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise
{
    public class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person person = new Person();
            person.Age = age;
            person.FName = fname;
            person.LName = lname;
            person.Height = height;
            person.Weight = weight;

            return person;
        }

        public string PrintPerson(Person pers)
        {
            return $"Forname: {pers.FName}\nLastname: {pers.LName}\nAge: {pers.Age}\nHeight: {pers.Height}\nWeight: {pers.Weight}";
        }

    }
}
