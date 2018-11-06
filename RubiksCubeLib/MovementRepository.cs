using System.Linq;

namespace RubiksCubeLib
{
    public class MovementRepository
    {
        private const CubeSide Up = CubeSide.Up;
        private const CubeSide Down = CubeSide.Down;
        private const CubeSide Left = CubeSide.Left;
        private const CubeSide Right = CubeSide.Right;
        private const CubeSide Front = CubeSide.Front;
        private const CubeSide Back = CubeSide.Back;

        private static MovementRepository _movementRepository;

        private MovementRepository()
        {
            _movementRepository = this;
        }

        /// <summary>
        /// Singleton
        /// </summary>
        private static MovementRepository Instance => _movementRepository ?? new MovementRepository();

        /// <summary>
        /// Get a movement by side and direction.
        /// </summary>
        /// <param name="side"></param>
        /// <param name="direction"></param>
        /// <returns>Liefert <see cref="Movement"/> oder NULL wenn kein passender Eintrag gefunden wurde.</returns>
        public static Movement Get(CubeSlice slice, MoveDirection direction)
        {
            return Instance._movements.SingleOrDefault(m => m.Slice == slice && m.Direction == direction);
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

        /// <summary>
        /// List of possible movements and how to execute them
        /// </summary>
        private readonly Movement[] _movements =
        {
            new Movement
            {
                Identifier = "F",
                Slice = CubeSlice.Front,
                Direction = MoveDirection.Single,
                SideChanges = new[]
                {
                    new SideChange(Up, Right),
                    new SideChange(Right, Down),
                    new SideChange(Down, Left),
                    new SideChange(Left, Up)
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
                Slice = CubeSlice.Front,
                Direction = MoveDirection.Inverted,
                SideChanges = new[]
                {
                    new SideChange(Up, Left),
                    new SideChange(Right, Up),
                    new SideChange(Down, Right),
                    new SideChange(Left, Down)
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
                Slice = CubeSlice.Front,
                Direction = MoveDirection.Double,
                SideChanges = new[]
                {
                    new SideChange(Up, Down),
                    new SideChange(Down, Up),
                    new SideChange(Right, Left),
                    new SideChange(Left, Right)
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
                Slice = CubeSlice.Right,
                Direction = MoveDirection.Single,
                SideChanges = new[]
                {
                    new SideChange(Up, Back),
                    new SideChange(Back, Down),
                    new SideChange(Down, Front),
                    new SideChange(Front, Up)
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
                Slice = CubeSlice.Right,
                Direction = MoveDirection.Inverted,
                SideChanges = new[]
                {
                    new SideChange(Up, Front),
                    new SideChange(Back, Up),
                    new SideChange(Down, Back),
                    new SideChange(Front, Down)
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
                Slice = CubeSlice.Right,
                Direction = MoveDirection.Double,
                SideChanges = new[]
                {
                    new SideChange(Up, Down),
                    new SideChange(Back, Front),
                    new SideChange(Down, Up),
                    new SideChange(Front, Back)
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
                Slice = CubeSlice.Left,
                Direction = MoveDirection.Single,
                SideChanges = new[]
                {
                    new SideChange(Up, Front),
                    new SideChange(Back, Up),
                    new SideChange(Down, Back),
                    new SideChange(Front, Down)
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
                Slice = CubeSlice.Left,
                Direction = MoveDirection.Inverted,
                SideChanges = new[]
                {
                    new SideChange(Up, Back),
                    new SideChange(Back, Down),
                    new SideChange(Down, Front),
                    new SideChange(Front, Up)
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
                Slice = CubeSlice.Left,
                Direction = MoveDirection.Double,
                SideChanges = new[]
                {
                    new SideChange(Up, Down),
                    new SideChange(Back, Front),
                    new SideChange(Down, Up),
                    new SideChange(Front, Back)
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
                Slice = CubeSlice.Back,
                Direction = MoveDirection.Single,
                SideChanges = new[]
                {
                    new SideChange(Up, Left),
                    new SideChange(Right, Up),
                    new SideChange(Down, Right),
                    new SideChange(Left, Down)
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
                Slice = CubeSlice.Back,
                Direction = MoveDirection.Inverted,
                SideChanges = new[]
                {
                    new SideChange(Up, Right),
                    new SideChange(Right, Down),
                    new SideChange(Down, Left),
                    new SideChange(Left, Up)
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
                Slice = CubeSlice.Back,
                Direction = MoveDirection.Double,
                SideChanges = new[]
                {
                    new SideChange(Up, Down),
                    new SideChange(Right, Left),
                    new SideChange(Down, Up),
                    new SideChange(Left, Right)
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
                Slice = CubeSlice.Up,
                Direction = MoveDirection.Single,
                SideChanges = new[]
                {
                    new SideChange(Left, Back),
                    new SideChange(Back, Right),
                    new SideChange(Right, Front),
                    new SideChange(Front, Left)
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
                Slice = CubeSlice.Up,
                Direction = MoveDirection.Inverted,
                SideChanges = new[]
                {
                    new SideChange(Left, Front),
                    new SideChange(Back, Left),
                    new SideChange(Right, Back),
                    new SideChange(Front, Right)
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
                Slice = CubeSlice.Up,
                Direction = MoveDirection.Double,
                SideChanges = new[]
                {
                    new SideChange(Left, Right),
                    new SideChange(Back, Front),
                    new SideChange(Right, Left),
                    new SideChange(Front, Back)
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
                Slice = CubeSlice.Down,
                Direction = MoveDirection.Single,
                SideChanges = new[]
                {
                    new SideChange(Left, Front),
                    new SideChange(Back, Left),
                    new SideChange(Right, Back),
                    new SideChange(Front, Right)
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
                Slice = CubeSlice.Down,
                Direction = MoveDirection.Inverted,
                SideChanges = new[]
                {
                    new SideChange(Left, Back),
                    new SideChange(Back, Right),
                    new SideChange(Right, Front),
                    new SideChange(Front, Left)
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
                Slice = CubeSlice.Down,
                Direction = MoveDirection.Double,
                SideChanges = new[]
                {
                    new SideChange(Left, Right),
                    new SideChange(Back, Front),
                    new SideChange(Right, Left),
                    new SideChange(Front, Back)
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
            },
            new Movement
            {
                Identifier = "M",
                Slice = CubeSlice.Middle,
                Direction = MoveDirection.Single,
                SideChanges = new[]
                {
                    new SideChange(Up, Front),
                    new SideChange(Front, Down),
                    new SideChange(Down, Back),
                    new SideChange(Back, Up)
                },
                PositionChanges = new[]
                {
                    new PositionChange(1, 2, 1, 1, 1, 0),
                    new PositionChange(1, 2, 0, 1, 0, 0),
                    new PositionChange(1, 1, 0, 1, 0, 1),
                    new PositionChange(1, 0, 0, 1, 0, 2),
                    new PositionChange(1, 0, 1, 1, 1, 2),
                    new PositionChange(1, 0, 2, 1, 2, 2),
                    new PositionChange(1, 1, 2, 1, 2, 1),
                    new PositionChange(1, 2, 2, 1, 2, 0)
                }
            },
            new Movement
            {
                Identifier = "M'",
                Slice = CubeSlice.Middle,
                Direction = MoveDirection.Inverted,
                SideChanges = new[]
                {
                    new SideChange(Up, Back),
                    new SideChange(Front, Up),
                    new SideChange(Down, Front),
                    new SideChange(Back, Down)
                },
                PositionChanges = new[]
                {
                    new PositionChange(1, 2, 1, 1, 1, 2),
                    new PositionChange(1, 2, 0, 1, 2, 2),
                    new PositionChange(1, 1, 0, 1, 2, 1),
                    new PositionChange(1, 0, 0, 1, 2, 0),
                    new PositionChange(1, 0, 1, 1, 1, 0),
                    new PositionChange(1, 0, 2, 1, 0, 0),
                    new PositionChange(1, 1, 2, 1, 0, 1),
                    new PositionChange(1, 2, 2, 1, 0, 2)
                }
            },
            new Movement
            {
                Identifier = "M2",
                Slice = CubeSlice.Middle,
                Direction = MoveDirection.Double,
                SideChanges = new[]
                {
                    new SideChange(Up, Down),
                    new SideChange(Front, Back),
                    new SideChange(Down, Up),
                    new SideChange(Back, Front)
                },
                PositionChanges = new[]
                {
                    new PositionChange(1, 2, 1, 1, 0, 1),
                    new PositionChange(1, 2, 0, 1, 0, 2),
                    new PositionChange(1, 1, 0, 1, 1, 2),
                    new PositionChange(1, 0, 0, 1, 2, 2),
                    new PositionChange(1, 0, 1, 1, 2, 1),
                    new PositionChange(1, 0, 2, 1, 2, 0),
                    new PositionChange(1, 1, 2, 1, 1, 0),
                    new PositionChange(1, 2, 2, 1, 0, 0)
                }
            },
            new Movement
            {
                Identifier = "E",
                Slice = CubeSlice.Equator,
                Direction = MoveDirection.Single,
                SideChanges = new[]
                {
                    new SideChange(Front, Right),
                    new SideChange(Right, Back),
                    new SideChange(Back, Left),
                    new SideChange(Left, Front)
                },
                PositionChanges = new[]
                {
                    new PositionChange(1, 1, 0, 2, 1, 1),
                    new PositionChange(2, 1, 0, 2, 1, 2),
                    new PositionChange(2, 1, 1, 1, 1, 2),
                    new PositionChange(2, 1, 2, 0, 1, 2),
                    new PositionChange(1, 1, 2, 0, 1, 1),
                    new PositionChange(0, 1, 2, 0, 1, 0),
                    new PositionChange(0, 1, 1, 1, 1, 0),
                    new PositionChange(0, 1, 0, 2, 1, 0)
                }
            },
            new Movement
            {
                Identifier = "E'",
                Slice = CubeSlice.Equator,
                Direction = MoveDirection.Inverted,
                SideChanges = new[]
                {
                    new SideChange(Front, Left),
                    new SideChange(Right, Front),
                    new SideChange(Back, Right),
                    new SideChange(Left, Back)
                },
                PositionChanges = new[]
                {
                    new PositionChange(1, 1, 0, 0, 1, 1),
                    new PositionChange(2, 1, 0, 0, 1, 0),
                    new PositionChange(2, 1, 1, 1, 1, 0),
                    new PositionChange(2, 1, 2, 2, 1, 0),
                    new PositionChange(1, 1, 2, 2, 1, 1),
                    new PositionChange(0, 1, 2, 2, 1, 2),
                    new PositionChange(0, 1, 1, 1, 1, 2),
                    new PositionChange(0, 1, 0, 0, 1, 2)
                }
            },
            new Movement
            {
                Identifier = "E2",
                Slice = CubeSlice.Equator,
                Direction = MoveDirection.Double,
                SideChanges = new[]
                {
                    new SideChange(Front, Back),
                    new SideChange(Right, Left),
                    new SideChange(Back, Front),
                    new SideChange(Left, Right)
                },
                PositionChanges = new[]
                {
                    new PositionChange(1, 1, 0, 1, 1, 2),
                    new PositionChange(2, 1, 0, 0, 1, 2),
                    new PositionChange(2, 1, 1, 0, 1, 1),
                    new PositionChange(2, 1, 2, 0, 1, 0),
                    new PositionChange(1, 1, 2, 1, 1, 0),
                    new PositionChange(0, 1, 2, 2, 1, 0),
                    new PositionChange(0, 1, 1, 2, 1, 1),
                    new PositionChange(0, 1, 0, 2, 1, 2)
                }
            },
            new Movement
            {
                Identifier = "S",
                Slice = CubeSlice.Standing,
                Direction = MoveDirection.Single,
                SideChanges = new[]
                {
                    new SideChange(Up, Right),
                    new SideChange(Right, Down),
                    new SideChange(Down, Left),
                    new SideChange(Left, Up)
                },
                PositionChanges = new[]
                {
                    new PositionChange(1, 2, 1, 2, 1, 1),
                    new PositionChange(2, 2, 1, 2, 0, 1),
                    new PositionChange(2, 1, 1, 1, 0, 1),
                    new PositionChange(2, 0, 1, 0, 0, 1),
                    new PositionChange(1, 0, 1, 0, 1, 1),
                    new PositionChange(0, 0, 1, 0, 2, 1),
                    new PositionChange(0, 1, 1, 1, 2, 1),
                    new PositionChange(0, 2, 1, 2, 2, 1)
                }
            },
            new Movement
            {
                Identifier = "S'",
                Slice = CubeSlice.Standing,
                Direction = MoveDirection.Inverted,
                SideChanges = new[]
                {
                    new SideChange(Up, Left),
                    new SideChange(Right, Up),
                    new SideChange(Down, Right),
                    new SideChange(Left, Down)
                },
                PositionChanges = new[]
                {
                    new PositionChange(1, 2, 1, 0, 1, 1),
                    new PositionChange(2, 2, 1, 0, 2, 1),
                    new PositionChange(2, 1, 1, 1, 2, 1),
                    new PositionChange(2, 0, 1, 2, 2, 1),
                    new PositionChange(1, 0, 1, 2, 1, 1),
                    new PositionChange(0, 0, 1, 2, 0, 1),
                    new PositionChange(0, 1, 1, 1, 0, 1),
                    new PositionChange(0, 2, 1, 0, 0, 1)
                }
            },
            new Movement
            {
                Identifier = "S2",
                Slice = CubeSlice.Standing,
                Direction = MoveDirection.Double,
                SideChanges = new[]
                {
                    new SideChange(Up, Down),
                    new SideChange(Right, Left),
                    new SideChange(Down, Up),
                    new SideChange(Left, Right)
                },
                PositionChanges = new[]
                {
                    new PositionChange(1, 2, 1, 1, 0, 1),
                    new PositionChange(2, 2, 1, 0, 0, 1),
                    new PositionChange(2, 1, 1, 0, 1, 1),
                    new PositionChange(2, 0, 1, 0, 2, 1),
                    new PositionChange(1, 0, 1, 1, 2, 1),
                    new PositionChange(0, 0, 1, 2, 2, 1),
                    new PositionChange(0, 1, 1, 2, 1, 1),
                    new PositionChange(0, 2, 1, 2, 0, 1)
                }
            }
        };
    }
}
