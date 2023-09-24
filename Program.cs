using OOPExercise.Animals;
using OOPExercise.Errors;
using OOPExercise.Animals.Birds;

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

            //Create a list of errors and then print the error messagein the list.
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


            //Create a list of animals, add 3 different kinds of animal in the list. 
            List<Animal> animals = new List<Animal>()
            {
                new Dog { Name = "Bobby", Age = 3, Weight = 18.1, HumanFriendly = true },
                new Worm { Name = "Wommy", Age= 1, Weight = 0.01, CanDig = true},
                new Swan {Name = "Anne", Age = 2, Weight = 1.4, CanFly = true, CanSwim = true},
                new Wolfman {Name = "Woffy", Age = 24, Weight = 66.4, IsDangerous = true }
            };

            //Print out the properties of the animal and make some noise.
            foreach ( var animal in animals)
            {
                animal.Stats();
                animal.DoSound();
            }

            //Check there is a wolfman in the list. If yes, wolfman makes some noise.
            foreach ( var animal in animals)
            {
                if (animal is Wolfman wolfman)
                {
                    wolfman.Talk();
                }
            }


        }
    }
}