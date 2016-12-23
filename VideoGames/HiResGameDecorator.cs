namespace VideoGames
{
    public class HiResGameDecorator : VideoGameDecorator
    {
        public HiResGameDecorator(VideoGame game) : base(game)
        {
        }

        public override string Description => base.Description + " Avec graphiques en haute résolution!";
    }

}
