namespace OOPExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person person = new Person();
                person.Age = 0;
                person.FName = "Gordon";
                person.LName = "Long";
                person.Height = 170;
                person.Weight = 70;
                bool isValid = person.ValidateProp(person.Age, person.FName, person.LName);
                if (isValid)
                {
                    Console.WriteLine(person.ToString());
                }
                
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}