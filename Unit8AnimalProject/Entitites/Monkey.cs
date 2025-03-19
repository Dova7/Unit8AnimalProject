namespace Unit8AnimalProject.Entitites
{
    public class Monkey : Animal
    {
        public string FoodType { get; set; }

        public Monkey(ushort age, double weight, string foodType) : base(age, weight)
        {
            FoodType = foodType;
        }

        public override void EatFood()
        {
            Console.WriteLine($"This monkey loves {FoodType}");
        }
    }
}
