namespace Unit8AnimalProject.Entitites
{
    public class Animal
    {
        public ushort Age { get; set; }
        public double Weight { get; set; }

        public Animal(ushort age, double weight)
        {
            Age = age;
            Weight = weight;
        }

        public virtual void EatFood()
        {
            Console.WriteLine("The animal is eating food.");
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"my age is: {Age}, my weight is: {Weight}");
        }
    }
}
