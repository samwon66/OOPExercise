using OOPExercise.Errors;

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

            //PersonHandler handler = new PersonHandler();
            //Person jb = handler.CreatePerson(70, "Joe", "Biden", 1.80, 87.5);
            //Person aw = handler.CreatePerson(50, "Anna", "Watson", 1.67, 77.5);
            //handler.PrintPerson(jb);
            //handler.PrintPerson(aw);

            List<UserError> errors = new List<UserError>();

            var numericError = new NumericInputError();
            var textError = new TextInputError();
            var minError = new MinError();
            var maxError = new MaxError();
            var validError = new ValidError();

            errors.Add(numericError);
            errors.Add(textError);
            errors.Add(minError);
            errors.Add(maxError);
            errors.Add(validError);

            foreach ( var error in errors ) 
            {
                Console.WriteLine(error.UEMessage());
            }

        }
    }
}