namespace Nutcracker
{
    public class Interaction : ITense, IDisposable
    {
        public Interaction(params Character[] characters)
        {
            Characters = characters;
        }

        public Character[] Characters { get; set; }

        public Tense Tense { get; set; }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}