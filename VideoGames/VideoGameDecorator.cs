namespace VideoGames
{
    public abstract class VideoGameDecorator : VideoGame
    {
        private readonly VideoGame _videoGame;

        protected VideoGameDecorator(VideoGame game)
        {
            _videoGame = game;
        }

        public override string Description => _videoGame.Description;

        public override int NumberOfPlayers => _videoGame.NumberOfPlayers;
    }

}
