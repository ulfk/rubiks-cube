using System.Collections.Generic;
using System.Linq;

namespace RubiksCubeLib
{
    public class Piece : IChangable
    {
        public IList<ColorTag> ColorTags { get; set; }

        public Position Position { get; set; }

        private Position _preparedPosition;
        private bool _changesPrepared = false;

        public Piece PrepareChanges(Position position, OrientationChange[] orientationChanges)
        {
            _preparedPosition = position;
            foreach (var orientationChange in orientationChanges)
            {
                ColorTags.FirstOrDefault(c => c.CubeOrientation == orientationChange.From)?.PrepareChange(orientationChange.To);
            }

            _changesPrepared = true;
            return this;
        }

        public void ExecChanges()
        {
            if (_changesPrepared)
            {
                Position = _preparedPosition;
                foreach (var colorTag in ColorTags)
                {
                    colorTag.ExecChanges();
                }

                _changesPrepared = false;
            }
        }
    }
}