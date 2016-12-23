using VideoGames;

namespace FactoryPattern
{
    public interface IVideoGameFactory
    {
        VideoGame CreateVideoGame(VideoGameCharacteristics characteristics, int numberOfPlayers);
    }
}