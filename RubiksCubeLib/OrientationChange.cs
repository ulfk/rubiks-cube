namespace RubiksCubeLib
{
    public class OrientationChange
    {
        public CubeOrientation From { get; set; }

        public CubeOrientation To { get; set; }

        public OrientationChange(CubeOrientation from, CubeOrientation to)
        {
            From = from;
            To = to;
        }
    }
}