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

            
            
            PersonHandler handler = new PersonHandler();
            var jb = handler.CreatePerson(70, "Joe", "Biden", 1.80, 87.5);
            var aw = handler.CreatePerson(50, "Anna", "Watson", 1.67, 77.5);
            handler.PrintPerson(jb);
            handler.PrintPerson(aw);

            
            
            //Create a list of errors, initialse different kinds of errors and put them in the list. Then print the error messages.
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

            //Print out the properties of each animal and make some noise.
            foreach ( var animal in animals)
            {
                animal.Stats();
                animal.DoSound();
            }

            //Check if there is a wolfman in the list. If yes, wolfman makes some noise if it is IPerson.
            foreach ( var animal in animals)
            {
                if (animal is Wolfman wolfman && wolfman is IPerson)
                {
                    wolfman.Talk();
                }
            }

            
           
            //This is a list of class Dog. If you want to put a horse in the same list with the dogs, you should create a list of animals which they all belong to.
            List<Dog> dogs = new List<Dog>();
            Dog bob = new Dog() { Name = "Bob", Age = 2, Weight = 18.4, HumanFriendly = true};
            Dog wess = new Dog() { Name = "Wess", Age = 6, Weight = 14.4, HumanFriendly = false };
            Dog noar = new Dog() { Name = "Noar", Age = 7, Weight = 7.4, HumanFriendly = true };

            foreach (var dog in dogs)
            {
                dog.Stats();
            }
        }
    }
}