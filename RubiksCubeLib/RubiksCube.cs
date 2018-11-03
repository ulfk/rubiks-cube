
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace RubiksCubeLib
{
    public class RubiksCube
    {
        private readonly List<Piece> _pieces = new List<Piece>();
        private readonly Regex _regex;

        private const string AlgorithmPattern = @"([UDRLFB][2']{0,1})";
        private const string AlgorithmCheckPattern = @"^(([UDRLFB][2']{0,1})*)$";
        private const string AlgorithmTrimPattern = @"\s+|\(|\)";

        private const CubeOrientation Up = CubeOrientation.Up;
        private const CubeOrientation Down = CubeOrientation.Down;
        private const CubeOrientation Left = CubeOrientation.Left;
        private const CubeOrientation Right = CubeOrientation.Right;
        private const CubeOrientation Front = CubeOrientation.Front;
        private const CubeOrientation Back = CubeOrientation.Back;

        private const CubeColor White = CubeColor.White;
        private const CubeColor Yellow = CubeColor.Yellow;
        private const CubeColor Blue = CubeColor.Blue;
        private const CubeColor Green = CubeColor.Green;
        private const CubeColor Red = CubeColor.Red;
        private const CubeColor Orange = CubeColor.Orange;

        public RubiksCube()
        {
            _regex = new Regex(AlgorithmPattern, RegexOptions.None);
            Init();
        }

        private void Init()
        {
            _pieces.Clear();
            CreatePiece(0, 2, 0, CreateTag(White, Up), CreateTag(Green, Front), CreateTag(Orange, Left));
            CreatePiece(1, 2, 0, CreateTag(White, Up), CreateTag(Green, Front));
            CreatePiece(2, 2, 0, CreateTag(White, Up), CreateTag(Green, Front), CreateTag(Red, Right));

            CreatePiece(0, 2, 1, CreateTag(White, Up), CreateTag(Orange, Left));
            CreatePiece(1, 2, 1, CreateTag(White, Up));
            CreatePiece(2, 2, 1, CreateTag(White, Up), CreateTag(Red, Right));

            CreatePiece(0, 2, 2, CreateTag(White, Up), CreateTag(Blue, Back), CreateTag(Orange, Left));
            CreatePiece(1, 2, 2, CreateTag(White, Up), CreateTag(Blue, Back));
            CreatePiece(2, 2, 2, CreateTag(White, Up), CreateTag(Blue, Back), CreateTag(Red, Right));

            CreatePiece(0, 1, 0, CreateTag(Green, Front), CreateTag(Orange, Left));
            CreatePiece(1, 1, 0, CreateTag(Green, Front));
            CreatePiece(2, 1, 0, CreateTag(Green, Front), CreateTag(Red, Right));

            CreatePiece(0, 1, 1, CreateTag(Orange, Left));
            CreatePiece(2, 1, 1, CreateTag(Red, Right));

            CreatePiece(0, 1, 2, CreateTag(Blue, Back), CreateTag(Orange, Left));
            CreatePiece(1, 1, 2, CreateTag(Blue, Back));
            CreatePiece(2, 1, 2, CreateTag(Blue, Back), CreateTag(Red, Right));

            CreatePiece(0, 0, 0, CreateTag(Green, Front), CreateTag(Orange, Left), CreateTag(Yellow, Down));
            CreatePiece(1, 0, 0, CreateTag(Green, Front), CreateTag(Yellow, Down));
            CreatePiece(2, 0, 0, CreateTag(Green, Front), CreateTag(Red, Right), CreateTag(Yellow, Down));

            CreatePiece(0, 0, 1, CreateTag(Orange, Left), CreateTag(Yellow, Down));
            CreatePiece(1, 0, 1, CreateTag(Yellow, Down));
            CreatePiece(2, 0, 1, CreateTag(Red, Right), CreateTag(Yellow, Down));

            CreatePiece(0, 0, 2, CreateTag(Blue, Back), CreateTag(Orange, Left), CreateTag(Yellow, Down));
            CreatePiece(1, 0, 2, CreateTag(Blue, Back), CreateTag(Yellow, Down));
            CreatePiece(2, 0, 2, CreateTag(Blue, Back), CreateTag(Red, Right), CreateTag(Yellow, Down));
        }

        private ColorTag CreateTag(CubeColor cubeColor, CubeOrientation cubeOrientation)
        {
            return new ColorTag(cubeColor, cubeOrientation);
        }

        private void CreatePiece(int x, int y, int z, params ColorTag[] colorTags)
        {
            _pieces.Add(
                new Piece
                {
                    Position = new Position { X = x, Y = y, Z = z },
                    ColorTags = colorTags.ToList()
                });
        }

        public void Reset()
        {
            Init();
        }

        public List<ColorTag> GetTags(CubeOrientation cubeOrientation)
        {
            return _pieces.SelectMany(p => p.ColorTags.Where(t => t.CubeOrientation == cubeOrientation)).ToList();
        }

        private List<Piece> GetPieces(CubeOrientation cubeOrientation)
        {
            return _pieces.Where(p => p.ColorTags.Any(t => t.CubeOrientation == cubeOrientation)).ToList();
        }

        public List<Piece> GetPieces()
        {
            return _pieces;
        }

        public void Rotate(CubeOrientation side, MoveDirection direction = MoveDirection.Regular)
        {
            var movement = MovementRepository.Get(side, direction) ?? throw new Exception($"Unknown rotation: {side} {direction}");
            DoRotation(movement);
        }

        private void Rotate(string identifier)
        {
            var movement = MovementRepository.Get(identifier) ?? throw new Exception($"Unknown rotation: {identifier}");
            DoRotation(movement);
        }

        private void DoRotation(Movement movement)
        {
            if (movement == null) throw new ArgumentNullException(nameof(movement));

            PrepareRotation(movement).ForEach(p => p.ExecChanges());
        }

        public void ExecAlgorithm(string algorithm)
        {
            if(!IsAlgorithmValid(algorithm))
                throw new Exception($"Invalid characters in algorithm: {algorithm}");
            DecomposeAlgorithm(algorithm).ForEach(Rotate);
        }

        private List<string> DecomposeAlgorithm(string algorithm)
        {
            var matchCollection = _regex.Matches(TrimAlgorithm(algorithm));
            return matchCollection.Cast<Match>().Select(m => m.Value).ToList();
        }

        private static string TrimAlgorithm(string algorithm)
        {
            return Regex.Replace(algorithm, AlgorithmTrimPattern, string.Empty);
        }

        public bool IsAlgorithmValid(string algorithm)
        {
            return Regex.IsMatch(TrimAlgorithm(algorithm), AlgorithmCheckPattern);
        }

        private List<Piece> PrepareRotation(Movement movement)
        {
            var pieces = GetPieces(movement.Side);
            foreach (var positionsChange in movement.PositionChanges)
            {
                pieces.Single(p => p.Position.Equals(positionsChange.From))
                    .PrepareChanges(positionsChange.To, movement.OrientationChanges);
            }

            return pieces;
        }
    }
}
