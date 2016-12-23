using VideoGames;

namespace FactoryPattern
{
    public class VideoGameFactory : IVideoGameFactory
    {
        public VideoGame CreateVideoGame(VideoGameCharacteristics characteristics, int numberOfPlayers)
        {
            VideoGame game = new SimpleVideoGame();

            if (characteristics.HasFlag(VideoGameCharacteristics.HiRes)) game = new HiResGameDecorator(game);
            if (characteristics.HasFlag(VideoGameCharacteristics.VirtualReality)) game = new VRGameDecorator(game);

            if (numberOfPlayers > 1) game = new MultiplayerGameDecorator(game, numberOfPlayers);

            return game;
        }
    }
}
