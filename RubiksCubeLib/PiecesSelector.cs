using System;
using System.Collections.Generic;
using System.Linq;

namespace RubiksCubeLib
{
    public static class PiecesSelector
    {
        public static List<Piece> PeacesBySlice(List<Piece> pieces, CubeSlice slice)
        {
            switch (slice)
            {
                case CubeSlice.Up:
                    return pieces.Where(p => p.Position.Y == 2).ToList();
                case CubeSlice.Front:
                    return pieces.Where(p => p.Position.Z == 0).ToList();
                case CubeSlice.Down:
                    return pieces.Where(p => p.Position.Y == 0).ToList();
                case CubeSlice.Back:
                    return pieces.Where(p => p.Position.Z == 2).ToList();
                case CubeSlice.Right:
                    return pieces.Where(p => p.Position.X == 2).ToList();
                case CubeSlice.Left:
                    return pieces.Where(p => p.Position.X == 0).ToList();
                case CubeSlice.Middle:
                    return pieces.Where(p => p.Position.X == 1).ToList();
                case CubeSlice.Equator:
                    return pieces.Where(p => p.Position.Y == 1).ToList();
                case CubeSlice.Standing:
                    return pieces.Where(p => p.Position.Z == 1).ToList();
                default:
                    throw new ArgumentOutOfRangeException(nameof(slice), slice, null);
            }
        }

    }
}