namespace Unit8AnimalProject.Entitites.Filters
{
    public class AnimalsFilter
    {
        public static List<Animal> FilterByAge(List<Animal> animals, ushort minAge)
        {
            return animals.Where(a => a.Age > minAge).ToList();
        }
    }
}
