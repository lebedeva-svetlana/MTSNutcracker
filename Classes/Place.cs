namespace Nutcracker
{
    public class Place : IProperty
    {
        public Place(string name)
        {
            Name = name;
        }

        public Character[] Characters { get; set; }
        public string Name { get; set; }

        public List<string>? Property { get; set; }
    }
}