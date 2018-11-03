
namespace RubiksCubeLib
{
    public class Movement
    {
        public CubeOrientation Side { get; set; }

        public MoveDirection Direction { get; set; }

        public string Identifier { get; set; }

        public OrientationChange[] OrientationChanges { get; set; }

        public PositionChange[] PositionChanges { get; set; }
    }
}