using System;
using FactoryPattern.Properties;
using VideoGames;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            bool hiRes = Settings.Default.HiRes;

            VideoGame game = new SimpleVideoGame();
            if (hiRes) game = new HiResGameDecorator(game);
            game = new MultiplayerGameDecorator(game, 2);
            Console.WriteLine(game.Description);

            game = new VRGameDecorator(game);
            Console.WriteLine(game.Description);
            Console.ReadKey();




            var factory = new VideoGameFactory();

            var test = factory.CreateVideoGame(VideoGameCharacteristics.HiRes, 1);

            var test2 = factory.CreateVideoGame(VideoGameCharacteristics.HiRes | VideoGameCharacteristics.VirtualReality, 2);

            Console.WriteLine(test2.Description);
            Console.ReadKey();
        }
    }
}
