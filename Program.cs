namespace OOPExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    var person = new Person();
            //    person.Age = 40;
            //    person.FName = "Gordon";
            //    person.LName = "Long";
            //    person.Height = 170.6;
            //    person.Weight = 70.9;
            //    bool isValid = person.ValidateProp(person.Age, person.FName, person.LName);
            //    if (isValid)
            //    {
            //        Console.WriteLine(person.ToString());
            //    }
                
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            PersonHandler handler = new PersonHandler();
            handler.CreatePerson(70, "Joe", "Biden", 1.80, 87.5);


        }
    }
}