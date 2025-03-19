using System.Xml.Linq;

namespace Unit8AnimalProject.Entitites
{
    public class Donkey : Animal
    {
        public string Name { get; set; } = null!;

        public Donkey(ushort age, double weight, string name) : base(age, weight)
        {
            Name = name;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Donkey with name {Name}: age {Age}, weight {Weight}.");
        }


    }
}
