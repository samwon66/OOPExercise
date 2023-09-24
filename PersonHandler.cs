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

        public string PrintPerson(int age, string fname, string lname, double height, double weight) 
        {
            Person person = CreatePerson(age, fname, lname, height, weight);
            return $"Förnamn: {person.FName}\nEfternamn: {person.LName}\nÅlder: {person.Age}\nLängd: {person.Height}\nVikt: {person.Weight}";
        }

    }
}
