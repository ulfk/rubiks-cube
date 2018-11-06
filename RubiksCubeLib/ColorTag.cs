namespace RubiksCubeLib
{
    public class ColorTag : IChangable
    {
        public CubeColor CubeColor { get; set; }

        public CubeSide CubeSide { get; set; }

        public ColorTag(CubeColor cubeColor, CubeSide side)
        {
            CubeColor = cubeColor;
            CubeSide = side;
        }

        private CubeSide _preparedCubeSide;
        private bool _changesPrepared;

        public ColorTag PrepareChange(CubeSide cubeSide)
        {
            _preparedCubeSide = cubeSide;
            _changesPrepared = true;

            return this;
        }

        public void ExecChanges()
        {
            if (_changesPrepared)
            {
                CubeSide = _preparedCubeSide;
                _changesPrepared = false;
            }
        }
    }
}
