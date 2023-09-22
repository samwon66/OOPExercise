namespace OOPExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person person = new Person(57, "Sammy", "Wong", 170, 68);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            //Person person = new Person(0, "Sammy", "Wong", 170, 68);
        }
    }
}