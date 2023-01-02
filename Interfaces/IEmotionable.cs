namespace Nutcracker
{
    public interface IEmotionable
    {
        public List<Emotion> Emotions { get; set; }

        public Emotion FacialExpression { get; set; }

        public void FeelEmotions();
    }
}