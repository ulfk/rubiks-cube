namespace RubiksCubeLib
{
    public class ColorTag : IChangable
    {
        public CubeColor CubeColor { get; set; }

        public CubeOrientation CubeOrientation { get; set; }

        public ColorTag(CubeColor cubeColor, CubeOrientation oreintation)
        {
            CubeColor = cubeColor;
            CubeOrientation = oreintation;
        }

        private CubeOrientation _preparedCubeOrientation;
        private bool _changesPrepared;

        public ColorTag PrepareChange(CubeOrientation cubeOrientation)
        {
            _preparedCubeOrientation = cubeOrientation;
            _changesPrepared = true;

            return this;
        }

        public void ExecChanges()
        {
            if (_changesPrepared)
            {
                CubeOrientation = _preparedCubeOrientation;
                _changesPrepared = false;
            }
        }
    }
}