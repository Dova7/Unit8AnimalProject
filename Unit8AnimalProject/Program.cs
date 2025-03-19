using System.Text.Json;
using Unit8AnimalProject.Entitites;
using Unit8AnimalProject.Entitites.Filters;

namespace Unit8AnimalProject
{
    internal class Program
    {
        //abstraction example
        public interface ISavable
        {
            void Save();
        }
        public class Person : ISavable
        {
            public void Save()
            {
                Console.WriteLine("Person saved");
            }
        }

        public class Parent
        {
            //encapsulation old way
            private string name { get; set; } = null!;
            public string Name
            {
                get => name;
                set => name = value;
            }

        }
        public class Child : Parent
        {

        }

        public class Calculator
        {
            // Overloaded methods with different parameter types
            public int Add(int a, int b)
            {
                return a + b;
            }

            public double Add(double a, double b)
            {
                return a + b;
            }
        }

        static void Main()
        {
            //lambda + linq
            var numbers = new List<string> { "1", "2", "3", "4", "5" };
            var intNumbers = numbers.Select(n => int.Parse(n)).ToList();
            double average = intNumbers.Average();

            var oddNumbers = intNumbers.Where(n => n % 2 != 0).ToList();
            var evenNumbers = intNumbers.Where(n => n % 2 == 0).ToList();
            var moreThanAverage = intNumbers.Where(n => n > average).ToList();

            //files
            var stringPath = @"Resources\";
            var filePath = Path.Combine(stringPath, "file.txt");
            var fileContent = File.ReadAllText(filePath);
            var textTowrite = "Hello world!";
            File.WriteAllText(filePath, textTowrite);

            //serialization to json
            var person = new Person();
            var json = JsonSerializer.Serialize(person);

            //deserialization from json
            var person2 = JsonSerializer.Deserialize<Person>(json);



            string someString = "Hello";
            someString.Insert(2, "world");


            var parent = new Parent();
            Child child = new Child();
            Parent parent2 = child;

            try
            {
                throw new DivideByZeroException("Divide by zero exception");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("This will always be executed.");
            }


            if (parent2 is Child)
            {
                Console.WriteLine("parent2 is Child");
            }

            var animals = new List<Animal>();

            animals.AddRange(CreateAnimals());

            var zoo = new Zoo("New York", animals);

            //zoo.PrintAnimals();
            //zoo.FeedAnimals();

            var filteredAnimals = AnimalsFilter.FilterByAge(animals, 10);
            var filteredZoo = new Zoo("City of grown-up animals", filteredAnimals);
            filteredZoo.PrintAnimals();


            var zooList = new List<Zoo>
            {
                zoo,
                filteredZoo
            };

            Console.WriteLine("Practice with lambda");

            zooList.Where(z => z.GetCity().Contains("grown-up")).ToList().ForEach(z => z.PrintAnimals());

            int number = 1;
            switch (number)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }


        }
        static List<Animal> CreateAnimals()
        {
            return new List<Animal>
            {
                new Animal(25, 70),
                new Animal(3, 4.55),
                new Monkey(7, 39.5, "banana"),
                new Monkey(18, 75, "bamboo"),
                new Donkey(12, 69, "Donny"),
                new Donkey(2, 32.2, "Little")
            };
        }
    }
}

