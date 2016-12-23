namespace VideoGames
{
    public class VRGameDecorator : VideoGameDecorator
    {
        public VRGameDecorator(VideoGame game) : base(game)
        {
        }

        public override string Description => "Mode VR disponible !!! " + base.Description;
    }
}