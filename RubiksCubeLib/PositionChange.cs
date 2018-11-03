namespace RubiksCubeLib
{
    public class PositionChange
    {
        public Position From { get; set; }

        public Position To { get; set; }

        public PositionChange(int fromX, int fromY, int fromZ, int toX, int toY, int toZ)
        {
            From = new Position{ X= fromX, Y = fromY, Z = fromZ };
            To = new Position { X = toX, Y = toY, Z = toZ };
        }
    }
}