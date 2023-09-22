namespace OOPExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person person = new Person();
                person.Age = 45;
                person.FName = "Ghost";
                person.LName = "Long";
                person.Height = 170;
                person.Weight = 70;
                bool isValid = person.Validate();
                if (isValid)
                {
                    Console.WriteLine(person.ToString());
                }
                //Console.WriteLine(person.ToString());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Person person = new Person(0, "Sammy", "Wong", 170, 68);
        }
    }
}