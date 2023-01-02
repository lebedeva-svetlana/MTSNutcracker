using System.Drawing;

namespace Nutcracker
{
    public class Character : IEmotionable, IProperty
    {
        public readonly int Hands = 2;

        public Character(string name)
        {
            Name = name;
        }

        public List<Emotion> Emotions { get; set; } = new();

        public Emotion FacialExpression { get; set; } = new("neutral");

        public string Name { get; set; }

        public Point Position { get; set; }

        public List<string>? Property { get; set; }

        public void FeelEmotions()
        {
        }
    }
}