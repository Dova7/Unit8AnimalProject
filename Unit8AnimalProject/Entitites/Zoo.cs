namespace Unit8AnimalProject.Entitites
{
    public class Zoo
    {
        public string City { get; set; } =  null!;
        public List<Animal> Animals { get; set; } = new List<Animal>();

        public Zoo(string city, List<Animal> animals)
        {
            City = city;
            Animals = animals;
        }

        public void PrintAnimals()
        {
            Console.WriteLine($"In {City} zoo there are the following animals:");
            foreach (var animal in Animals)
            {
                animal.PrintInfo();
            }
        }

        public void FeedAnimals()
        {
            Console.WriteLine($"Feeding animals in {City} zoo:");
            foreach (var animal in Animals)
            {
                animal.EatFood();
            }
        }

        public string GetCity()
        {
            return City;
        }
    }
}