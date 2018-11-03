namespace RubiksCubeLib
{
    public class Position
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }

        public bool Equals(Position position)
        {
            return X == position.X && Y == position.Y && Z == position.Z;
        }
    }
}