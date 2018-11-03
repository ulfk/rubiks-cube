using System.Linq;

namespace RubiksCubeLib
{
    public class MovementRepository
    {
        private const CubeOrientation Up = CubeOrientation.Up;
        private const CubeOrientation Down = CubeOrientation.Down;
        private const CubeOrientation Left = CubeOrientation.Left;
        private const CubeOrientation Right = CubeOrientation.Right;
        private const CubeOrientation Front = CubeOrientation.Front;
        private const CubeOrientation Back = CubeOrientation.Back;

        private const MoveDirection Inverted = MoveDirection.Inverted;
        private const MoveDirection Regular = MoveDirection.Regular;
        private const MoveDirection Double = MoveDirection.Double;

        private static MovementRepository _movementRepository;

        private MovementRepository()
        {
            _movementRepository = this;
        }

        private static MovementRepository Instance => _movementRepository ?? new MovementRepository();

        /// <summary>
        /// Get a movement by side and direction.
        /// </summary>
        /// <param name="side"></param>
        /// <param name="direction"></param>
        /// <returns>Liefert <see cref="Movement"/> oder NULL wenn kein passender Eintrag gefunden wurde.</returns>
        public static Movement Get(CubeOrientation side, MoveDirection direction)
        {
            return Instance._movements.SingleOrDefault(m => m.Side == side && m.Direction == direction);
        }

        /// <summary>
        /// Get a movement by it's identifier (such as "R" oder "U2")
        /// </summary>
        /// <param name="identifier"></param>
        /// <returns>Liefert <see cref="Movement"/> oder NULL wenn kein passender Eintrag gefunden wurde.</returns>
        public static Movement Get(string identifier)
        {
            return Instance._movements.SingleOrDefault(m => m.Identifier == identifier);
        }

        //TODO: Middle-Moves
        private readonly Movement[] _movements =
        {
            new Movement
            {
                Identifier = "F",
                Side = Front,
                Direction = Regular,
                OrientationChanges = new[]
                {
                    new OrientationChange(Up, Right),
                    new OrientationChange(Right, Down),
                    new OrientationChange(Down, Left),
                    new OrientationChange(Left, Up)
                },
                PositionChanges = new[]
                {
                    new PositionChange(0, 2, 0, 2, 2, 0),
                    new PositionChange(1, 2, 0, 2, 1, 0),
                    new PositionChange(2, 2, 0, 2, 0, 0),
                    new PositionChange(0, 1, 0, 1, 2, 0),
                    new PositionChange(2, 1, 0, 1, 0, 0),
                    new PositionChange(0, 0, 0, 0, 2, 0),
                    new PositionChange(1, 0, 0, 0, 1, 0),
                    new PositionChange(2, 0, 0, 0, 0, 0)
                }
            },
            new Movement
            {
                Identifier = "F'",
                Side = Front,
                Direction = Inverted,
                OrientationChanges = new[]
                {
                    new OrientationChange(Up, Left),
                    new OrientationChange(Right, Up),
                    new OrientationChange(Down, Right),
                    new OrientationChange(Left, Down)
                },
                PositionChanges = new[]
                {
                    new PositionChange(0, 2, 0, 0, 0, 0),
                    new PositionChange(1, 2, 0, 0, 1, 0),
                    new PositionChange(2, 2, 0, 0, 2, 0),
                    new PositionChange(0, 1, 0, 1, 0, 0),
                    new PositionChange(2, 1, 0, 1, 2, 0),
                    new PositionChange(0, 0, 0, 2, 0, 0),
                    new PositionChange(1, 0, 0, 2, 1, 0),
                    new PositionChange(2, 0, 0, 2, 2, 0)
                }
            },
            new Movement
            {
                Identifier = "F2",
                Side = Front,
                Direction = Double,
                OrientationChanges = new[]
                {
                    new OrientationChange(Up, Down),
                    new OrientationChange(Down, Up),
                    new OrientationChange(Right, Left),
                    new OrientationChange(Left, Right)
                },
                PositionChanges = new[]
                {
                    new PositionChange(0, 2, 0, 2, 0, 0),
                    new PositionChange(1, 2, 0, 1, 0, 0),
                    new PositionChange(2, 2, 0, 0, 0, 0),
                    new PositionChange(0, 1, 0, 2, 1, 0),
                    new PositionChange(2, 1, 0, 0, 1, 0),
                    new PositionChange(0, 0, 0, 2, 2, 0),
                    new PositionChange(1, 0, 0, 1, 2, 0),
                    new PositionChange(2, 0, 0, 0, 2, 0)
                }
            },
            new Movement
            {
                Identifier = "R",
                Side = Right,
                Direction = Regular,
                OrientationChanges = new[]
                {
                    new OrientationChange(Up, Back),
                    new OrientationChange(Back, Down),
                    new OrientationChange(Down, Front),
                    new OrientationChange(Front, Up)
                },
                PositionChanges = new[]
                {
                    new PositionChange(2, 2, 0, 2, 2, 2),
                    new PositionChange(2, 2, 1, 2, 1, 2),
                    new PositionChange(2, 2, 2, 2, 0, 2),
                    new PositionChange(2, 1, 2, 2, 0, 1),
                    new PositionChange(2, 0, 2, 2, 0, 0),
                    new PositionChange(2, 0, 1, 2, 1, 0),
                    new PositionChange(2, 0, 0, 2, 2, 0),
                    new PositionChange(2, 1, 0, 2, 2, 1)
                }
            },
            new Movement
            {
                Identifier = "R'",
                Side = Right,
                Direction = Inverted,
                OrientationChanges = new[]
                {
                    new OrientationChange(Up, Front),
                    new OrientationChange(Back, Up),
                    new OrientationChange(Down, Back),
                    new OrientationChange(Front, Down)
                },
                PositionChanges = new[]
                {
                    new PositionChange(2, 2, 0, 2, 0, 0),
                    new PositionChange(2, 2, 1, 2, 1, 0),
                    new PositionChange(2, 2, 2, 2, 2, 0),
                    new PositionChange(2, 1, 2, 2, 2, 1),
                    new PositionChange(2, 0, 2, 2, 2, 2),
                    new PositionChange(2, 0, 1, 2, 1, 2),
                    new PositionChange(2, 0, 0, 2, 0, 2),
                    new PositionChange(2, 1, 0, 2, 0, 1)
                }
            },
            new Movement
            {
                Identifier = "R2",
                Side = Right,
                Direction = Double,
                OrientationChanges = new[]
                {
                    new OrientationChange(Up, Down),
                    new OrientationChange(Back, Front),
                    new OrientationChange(Down, Up),
                    new OrientationChange(Front, Back)
                },
                PositionChanges = new[]
                {
                    new PositionChange(2, 2, 0, 2, 0, 2),
                    new PositionChange(2, 2, 1, 2, 0, 1),
                    new PositionChange(2, 2, 2, 2, 0, 0),
                    new PositionChange(2, 1, 2, 2, 1, 0),
                    new PositionChange(2, 0, 2, 2, 2, 0),
                    new PositionChange(2, 0, 1, 2, 2, 1),
                    new PositionChange(2, 0, 0, 2, 2, 2),
                    new PositionChange(2, 1, 0, 2, 1, 2)
                }
            },
            new Movement
            {
                Identifier = "L",
                Side = Left,
                Direction = Regular,
                OrientationChanges = new[]
                {
                    new OrientationChange(Up, Front),
                    new OrientationChange(Back, Up),
                    new OrientationChange(Down, Back),
                    new OrientationChange(Front, Down)
                },
                PositionChanges = new[]
                {
                    new PositionChange(0, 2, 0, 0, 0, 0),
                    new PositionChange(0, 2, 1, 0, 1, 0),
                    new PositionChange(0, 2, 2, 0, 2, 0),
                    new PositionChange(0, 1, 2, 0, 2, 1),
                    new PositionChange(0, 0, 2, 0, 2, 2),
                    new PositionChange(0, 0, 1, 0, 1, 2),
                    new PositionChange(0, 0, 0, 0, 0, 2),
                    new PositionChange(0, 1, 0, 0, 0, 1)
                }
            },
            new Movement
            {
                Identifier = "L'",
                Side = Left,
                Direction = Inverted,
                OrientationChanges = new[]
                {
                    new OrientationChange(Up, Back),
                    new OrientationChange(Back, Down),
                    new OrientationChange(Down, Front),
                    new OrientationChange(Front, Up)
                },
                PositionChanges = new[]
                {
                    new PositionChange(0, 2, 0, 0, 2, 2),
                    new PositionChange(0, 2, 1, 0, 1, 2),
                    new PositionChange(0, 2, 2, 0, 0, 2),
                    new PositionChange(0, 1, 2, 0, 0, 1),
                    new PositionChange(0, 0, 2, 0, 0, 0),
                    new PositionChange(0, 0, 1, 0, 1, 0),
                    new PositionChange(0, 0, 0, 0, 2, 0),
                    new PositionChange(0, 1, 0, 0, 2, 1)
                }
            },
            new Movement
            {
                Identifier = "L2",
                Side = Left,
                Direction = Double,
                OrientationChanges = new[]
                {
                    new OrientationChange(Up, Down),
                    new OrientationChange(Back, Front),
                    new OrientationChange(Down, Up),
                    new OrientationChange(Front, Back)
                },
                PositionChanges = new[]
                {
                    new PositionChange(0, 2, 0, 0, 0, 2),
                    new PositionChange(0, 2, 1, 0, 0, 1),
                    new PositionChange(0, 2, 2, 0, 0, 0),
                    new PositionChange(0, 1, 2, 0, 1, 0),
                    new PositionChange(0, 0, 2, 0, 2, 0),
                    new PositionChange(0, 0, 1, 0, 2, 1),
                    new PositionChange(0, 0, 0, 0, 2, 2),
                    new PositionChange(0, 1, 0, 0, 1, 2)
                }
            },
            new Movement
            {
                Identifier = "B",
                Side = Back,
                Direction = Regular,
                OrientationChanges = new[]
                {
                    new OrientationChange(Up, Left),
                    new OrientationChange(Right, Up),
                    new OrientationChange(Down, Right),
                    new OrientationChange(Left, Down)
                },
                PositionChanges = new[]
                {
                    new PositionChange(0, 2, 2, 0, 0, 2),
                    new PositionChange(1, 2, 2, 0, 1, 2),
                    new PositionChange(2, 2, 2, 0, 2, 2),
                    new PositionChange(0, 1, 2, 1, 0, 2),
                    new PositionChange(2, 1, 2, 1, 2, 2),
                    new PositionChange(0, 0, 2, 2, 0, 2),
                    new PositionChange(1, 0, 2, 2, 1, 2),
                    new PositionChange(2, 0, 2, 2, 2, 2)
                }
            },
            new Movement
            {
                Identifier = "B'",
                Side = Back,
                Direction = Inverted,
                OrientationChanges = new[]
                {
                    new OrientationChange(Up, Right),
                    new OrientationChange(Right, Down),
                    new OrientationChange(Down, Left),
                    new OrientationChange(Left, Up)
                },
                PositionChanges = new[]
                {
                    new PositionChange(0, 2, 2, 2, 2, 2),
                    new PositionChange(1, 2, 2, 2, 1, 2),
                    new PositionChange(2, 2, 2, 2, 0, 2),
                    new PositionChange(0, 1, 2, 1, 2, 2),
                    new PositionChange(2, 1, 2, 1, 0, 2),
                    new PositionChange(0, 0, 2, 0, 2, 2),
                    new PositionChange(1, 0, 2, 0, 1, 2),
                    new PositionChange(2, 0, 2, 0, 0, 2)
                }
            },
            new Movement
            {
                Identifier = "B2",
                Side = Back,
                Direction = Double,
                OrientationChanges = new[]
                {
                    new OrientationChange(Up, Down),
                    new OrientationChange(Right, Left),
                    new OrientationChange(Down, Up),
                    new OrientationChange(Left, Right)
                },
                PositionChanges = new[]
                {
                    new PositionChange(0, 2, 2, 2, 0, 2),
                    new PositionChange(1, 2, 2, 1, 0, 2),
                    new PositionChange(2, 2, 2, 0, 0, 2),
                    new PositionChange(0, 1, 2, 2, 1, 2),
                    new PositionChange(2, 1, 2, 0, 1, 2),
                    new PositionChange(0, 0, 2, 2, 2, 2),
                    new PositionChange(1, 0, 2, 1, 2, 2),
                    new PositionChange(2, 0, 2, 0, 2, 2)
                }
            },
            new Movement
            {
                Identifier = "U",
                Side = Up,
                Direction = Regular,
                OrientationChanges = new[]
                {
                    new OrientationChange(Left, Back),
                    new OrientationChange(Back, Right),
                    new OrientationChange(Right, Front),
                    new OrientationChange(Front, Left)
                },
                PositionChanges = new[]
                {
                    new PositionChange(0, 2, 0, 0, 2, 2),
                    new PositionChange(1, 2, 0, 0, 2, 1),
                    new PositionChange(2, 2, 0, 0, 2, 0),
                    new PositionChange(2, 2, 1, 1, 2, 0),
                    new PositionChange(2, 2, 2, 2, 2, 0),
                    new PositionChange(1, 2, 2, 2, 2, 1),
                    new PositionChange(0, 2, 2, 2, 2, 2),
                    new PositionChange(0, 2, 1, 1, 2, 2)
                }
            },
            new Movement
            {
                Identifier = "U'",
                Side = Up,
                Direction = Inverted,
                OrientationChanges = new[]
                {
                    new OrientationChange(Left, Front),
                    new OrientationChange(Back, Left),
                    new OrientationChange(Right, Back),
                    new OrientationChange(Front, Right)
                },
                PositionChanges = new[]
                {
                    new PositionChange(0, 2, 0, 2, 2, 0),
                    new PositionChange(1, 2, 0, 2, 2, 1),
                    new PositionChange(2, 2, 0, 2, 2, 2),
                    new PositionChange(2, 2, 1, 1, 2, 2),
                    new PositionChange(2, 2, 2, 0, 2, 2),
                    new PositionChange(1, 2, 2, 0, 2, 1),
                    new PositionChange(0, 2, 2, 0, 2, 0),
                    new PositionChange(0, 2, 1, 1, 2, 0)
                }
            },
            new Movement
            {
                Identifier = "U2",
                Side = Up,
                Direction = Double,
                OrientationChanges = new[]
                {
                    new OrientationChange(Left, Right),
                    new OrientationChange(Back, Front),
                    new OrientationChange(Right, Left),
                    new OrientationChange(Front, Back)
                },
                PositionChanges = new[]
                {
                    new PositionChange(0, 2, 0, 2, 2, 2),
                    new PositionChange(1, 2, 0, 1, 2, 2),
                    new PositionChange(2, 2, 0, 0, 2, 2),
                    new PositionChange(2, 2, 1, 0, 2, 1),
                    new PositionChange(2, 2, 2, 0, 2, 0),
                    new PositionChange(1, 2, 2, 1, 2, 0),
                    new PositionChange(0, 2, 2, 2, 2, 0),
                    new PositionChange(0, 2, 1, 2, 2, 1)
                }
            },
            new Movement
            {
                Identifier = "D",
                Side = Down,
                Direction = Regular,
                OrientationChanges = new[]
                {
                    new OrientationChange(Left, Front),
                    new OrientationChange(Back, Left),
                    new OrientationChange(Right, Back),
                    new OrientationChange(Front, Right)
                },
                PositionChanges = new[]
                {
                    new PositionChange(0, 0, 0, 2, 0, 0),
                    new PositionChange(1, 0, 0, 2, 0, 1),
                    new PositionChange(2, 0, 0, 2, 0, 2),
                    new PositionChange(2, 0, 1, 1, 0, 2),
                    new PositionChange(2, 0, 2, 0, 0, 2),
                    new PositionChange(1, 0, 2, 0, 0, 1),
                    new PositionChange(0, 0, 2, 0, 0, 0),
                    new PositionChange(0, 0, 1, 1, 0, 0)
                }
            },
            new Movement
            {
                Identifier = "D'",
                Side = Down,
                Direction = Inverted,
                OrientationChanges = new[]
                {
                    new OrientationChange(Left, Back),
                    new OrientationChange(Back, Right),
                    new OrientationChange(Right, Front),
                    new OrientationChange(Front, Left)
                },
                PositionChanges = new[]
                {
                    new PositionChange(0, 0, 0, 0, 0, 2),
                    new PositionChange(1, 0, 0, 0, 0, 1),
                    new PositionChange(2, 0, 0, 0, 0, 0),
                    new PositionChange(2, 0, 1, 1, 0, 0),
                    new PositionChange(2, 0, 2, 2, 0, 0),
                    new PositionChange(1, 0, 2, 2, 0, 1),
                    new PositionChange(0, 0, 2, 2, 0, 2),
                    new PositionChange(0, 0, 1, 1, 0, 2)
                }
            },
            new Movement
            {
                Identifier = "D2",
                Side = Down,
                Direction = Double,
                OrientationChanges = new[]
                {
                    new OrientationChange(Left, Right),
                    new OrientationChange(Back, Front),
                    new OrientationChange(Right, Left),
                    new OrientationChange(Front, Back)
                },
                PositionChanges = new[]
                {
                    new PositionChange(0, 0, 0, 2, 0, 2),
                    new PositionChange(1, 0, 0, 1, 0, 2),
                    new PositionChange(2, 0, 0, 0, 0, 2),
                    new PositionChange(2, 0, 1, 0, 0, 1),
                    new PositionChange(2, 0, 2, 0, 0, 0),
                    new PositionChange(1, 0, 2, 1, 0, 0),
                    new PositionChange(0, 0, 2, 2, 0, 0),
                    new PositionChange(0, 0, 1, 2, 0, 1)
                }
            }
        };
    }
}
