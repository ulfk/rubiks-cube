namespace RubiksCubeLib
{
    public class SideChange
    {
        public CubeSide From { get; set; }

        public CubeSide To { get; set; }

        public SideChange(CubeSide from, CubeSide to)
        {
            From = from;
            To = to;
        }
    }
}