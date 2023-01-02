namespace Nutcracker
{
    public class Speech : ITense, IDisposable
    {
        public Emotion Emotion { get; set; }

        public bool IsDirect { get; set; }

        public ObjectOfSpeech ObjectOfSpeech { get; set; }

        public SpeechType SpeechType { get; set; }

        public Tense Tense { get; set; }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}