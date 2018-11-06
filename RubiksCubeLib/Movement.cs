
namespace RubiksCubeLib
{
    public class Movement
    {
        public CubeSlice Slice { get; set; }

        public MoveDirection Direction { get; set; }

        public string Identifier { get; set; }

        public SideChange[] SideChanges { get; set; }

        public PositionChange[] PositionChanges { get; set; }
    }
}