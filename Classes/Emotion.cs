namespace Nutcracker
{
    public class Emotion
    {
        public Emotion(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public int Power { get; set; } = 1;
    }
}