using System;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RubiksCubeLib;

namespace RubiksCubeTest
{
    [TestClass]
    public class RubiksCubeTests
    {
        [TestMethod]
        public void CheckInitialCube()
        {
            var cube = new RubiksCube();

            CheckSide(cube, CubeSide.Up, CubeColor.White, 9);
            CheckSide(cube, CubeSide.Front, CubeColor.Green, 9);
            CheckSide(cube, CubeSide.Down, CubeColor.Yellow, 9);
            CheckSide(cube, CubeSide.Back, CubeColor.Blue, 9);
            CheckSide(cube, CubeSide.Right, CubeColor.Red, 9);
            CheckSide(cube, CubeSide.Left, CubeColor.Orange, 9);
        }

        [TestMethod]
        public void TestRotationFront()
        {
            var cube = new RubiksCube();
            cube.Rotate(CubeSlice.Front);

            CheckSide(cube, CubeSide.Up, CubeColor.White, 6, CubeColor.Orange, 3);
            CheckSide(cube, CubeSide.Front, CubeColor.Green, 9);
            CheckSide(cube, CubeSide.Down, CubeColor.Yellow, 6, CubeColor.Red, 3);
            CheckSide(cube, CubeSide.Back, CubeColor.Blue, 9);
            CheckSide(cube, CubeSide.Right, CubeColor.Red, 6, CubeColor.White, 3);
            CheckSide(cube, CubeSide.Left, CubeColor.Orange, 6, CubeColor.Yellow, 3);
        }

        [TestMethod]
        public void TestRotationFrontInverted()
        {
            var cube = new RubiksCube();
            cube.Rotate(CubeSlice.Front, MoveDirection.Inverted);

            CheckSide(cube, CubeSide.Up, CubeColor.White, 6, CubeColor.Red, 3);
            CheckSide(cube, CubeSide.Front, CubeColor.Green, 9);
            CheckSide(cube, CubeSide.Down, CubeColor.Yellow, 6, CubeColor.Orange, 3);
            CheckSide(cube, CubeSide.Back, CubeColor.Blue, 9);
            CheckSide(cube, CubeSide.Right, CubeColor.Red, 6, CubeColor.Yellow, 3);
            CheckSide(cube, CubeSide.Left, CubeColor.Orange, 6, CubeColor.White, 3);
        }

        [TestMethod]
        public void TestRotationFrontDouble()
        {
            var cube = new RubiksCube();
            cube.Rotate(CubeSlice.Front, MoveDirection.Double);

            CheckSide(cube, CubeSide.Up, CubeColor.White, 6, CubeColor.Yellow, 3);
            CheckSide(cube, CubeSide.Front, CubeColor.Green, 9);
            CheckSide(cube, CubeSide.Down, CubeColor.Yellow, 6, CubeColor.White, 3);
            CheckSide(cube, CubeSide.Back, CubeColor.Blue, 9);
            CheckSide(cube, CubeSide.Right, CubeColor.Red, 6, CubeColor.Orange, 3);
            CheckSide(cube, CubeSide.Left, CubeColor.Orange, 6, CubeColor.Red, 3);
        }

        [TestMethod]
        public void TestRotationRight()
        {
            var cube = new RubiksCube();
            cube.Rotate(CubeSlice.Right);

            CheckSide(cube, CubeSide.Up, CubeColor.White, 6, CubeColor.Green, 3);
            CheckSide(cube, CubeSide.Front, CubeColor.Green, 6, CubeColor.Yellow, 3);
            CheckSide(cube, CubeSide.Down, CubeColor.Yellow, 6, CubeColor.Blue, 3);
            CheckSide(cube, CubeSide.Back, CubeColor.Blue, 6, CubeColor.White, 3);
            CheckSide(cube, CubeSide.Right, CubeColor.Red, 9);
            CheckSide(cube, CubeSide.Left, CubeColor.Orange, 9);
        }

        [TestMethod]
        public void TestRotationRightInverted()
        {
            var cube = new RubiksCube();
            cube.Rotate(CubeSlice.Right,MoveDirection.Inverted);

            CheckSide(cube, CubeSide.Up, CubeColor.White, 6, CubeColor.Blue, 3);
            CheckSide(cube, CubeSide.Front, CubeColor.Green, 6, CubeColor.White, 3);
            CheckSide(cube, CubeSide.Down, CubeColor.Yellow, 6, CubeColor.Green, 3);
            CheckSide(cube, CubeSide.Back, CubeColor.Blue, 6, CubeColor.Yellow, 3);
            CheckSide(cube, CubeSide.Right, CubeColor.Red, 9);
            CheckSide(cube, CubeSide.Left, CubeColor.Orange, 9);
        }

        [TestMethod]
        public void TestRotationRightDouble()
        {
            var cube = new RubiksCube();
            cube.Rotate(CubeSlice.Right, MoveDirection.Double);

            CheckSide(cube, CubeSide.Up, CubeColor.White, 6, CubeColor.Yellow, 3);
            CheckSide(cube, CubeSide.Front, CubeColor.Green, 6, CubeColor.Blue, 3);
            CheckSide(cube, CubeSide.Down, CubeColor.Yellow, 6, CubeColor.White, 3);
            CheckSide(cube, CubeSide.Back, CubeColor.Blue, 6, CubeColor.Green, 3);
            CheckSide(cube, CubeSide.Right, CubeColor.Red, 9);
            CheckSide(cube, CubeSide.Left, CubeColor.Orange, 9);
        }

        [TestMethod]
        public void TestRotationLeft()
        {
            var cube = new RubiksCube();
            cube.Rotate(CubeSlice.Left);

            CheckSide(cube, CubeSide.Up, CubeColor.White, 6, CubeColor.Blue, 3);
            CheckSide(cube, CubeSide.Front, CubeColor.Green, 6, CubeColor.White, 3);
            CheckSide(cube, CubeSide.Down, CubeColor.Yellow, 6, CubeColor.Green, 3);
            CheckSide(cube, CubeSide.Back, CubeColor.Blue, 6, CubeColor.Yellow, 3);
            CheckSide(cube, CubeSide.Right, CubeColor.Red, 9);
            CheckSide(cube, CubeSide.Left, CubeColor.Orange, 9);
        }

        [TestMethod]
        public void TestRotationLeftDouble()
        {
            var cube = new RubiksCube();
            cube.Rotate(CubeSlice.Left, MoveDirection.Double);

            CheckSide(cube, CubeSide.Up, CubeColor.White, 6, CubeColor.Yellow, 3);
            CheckSide(cube, CubeSide.Front, CubeColor.Green, 6, CubeColor.Blue, 3);
            CheckSide(cube, CubeSide.Down, CubeColor.Yellow, 6, CubeColor.White, 3);
            CheckSide(cube, CubeSide.Back, CubeColor.Blue, 6, CubeColor.Green, 3);
            CheckSide(cube, CubeSide.Right, CubeColor.Red, 9);
            CheckSide(cube, CubeSide.Left, CubeColor.Orange, 9);

        }

        [TestMethod]
        public void TestRotationLeftInverted()
        {
            var cube = new RubiksCube();
            cube.Rotate(CubeSlice.Left, MoveDirection.Inverted);

            CheckSide(cube, CubeSide.Up, CubeColor.White, 6, CubeColor.Green, 3);
            CheckSide(cube, CubeSide.Front, CubeColor.Green, 6, CubeColor.Yellow, 3);
            CheckSide(cube, CubeSide.Down, CubeColor.Yellow, 6, CubeColor.Blue, 3);
            CheckSide(cube, CubeSide.Back, CubeColor.Blue, 6, CubeColor.White, 3);
            CheckSide(cube, CubeSide.Right, CubeColor.Red, 9);
            CheckSide(cube, CubeSide.Left, CubeColor.Orange, 9);
        }

        [TestMethod]
        public void TestRotationBackInverted()
        {
            var cube = new RubiksCube();
            cube.Rotate(CubeSlice.Back, MoveDirection.Inverted);

            CheckSide(cube, CubeSide.Up, CubeColor.White, 6, CubeColor.Orange, 3);
            CheckSide(cube, CubeSide.Front, CubeColor.Green, 9);
            CheckSide(cube, CubeSide.Down, CubeColor.Yellow, 6, CubeColor.Red, 3);
            CheckSide(cube, CubeSide.Back, CubeColor.Blue, 9);
            CheckSide(cube, CubeSide.Right, CubeColor.Red, 6, CubeColor.White, 3);
            CheckSide(cube, CubeSide.Left, CubeColor.Orange, 6, CubeColor.Yellow, 3);
        }

        [TestMethod]
        public void TestRotationBack()
        {
            var cube = new RubiksCube();
            cube.Rotate(CubeSlice.Back);

            CheckSide(cube, CubeSide.Up, CubeColor.White, 6, CubeColor.Red, 3);
            CheckSide(cube, CubeSide.Front, CubeColor.Green, 9);
            CheckSide(cube, CubeSide.Down, CubeColor.Yellow, 6, CubeColor.Orange, 3);
            CheckSide(cube, CubeSide.Back, CubeColor.Blue, 9);
            CheckSide(cube, CubeSide.Right, CubeColor.Red, 6, CubeColor.Yellow, 3);
            CheckSide(cube, CubeSide.Left, CubeColor.Orange, 6, CubeColor.White, 3);
        }

        [TestMethod]
        public void TestRotationBackDouble()
        {
            var cube = new RubiksCube();
            cube.Rotate(CubeSlice.Back, MoveDirection.Double);

            CheckSide(cube, CubeSide.Up, CubeColor.White, 6, CubeColor.Yellow, 3);
            CheckSide(cube, CubeSide.Front, CubeColor.Green, 9);
            CheckSide(cube, CubeSide.Down, CubeColor.Yellow, 6, CubeColor.White, 3);
            CheckSide(cube, CubeSide.Back, CubeColor.Blue, 9);
            CheckSide(cube, CubeSide.Right, CubeColor.Red, 6, CubeColor.Orange, 3);
            CheckSide(cube, CubeSide.Left, CubeColor.Orange, 6, CubeColor.Red, 3);
        }

        [TestMethod]
        public void TestRotationUp()
        {
            var cube = new RubiksCube();
            cube.Rotate(CubeSlice.Up);

            CheckSide(cube, CubeSide.Up, CubeColor.White, 9);
            CheckSide(cube, CubeSide.Front, CubeColor.Green, 6, CubeColor.Red, 3);
            CheckSide(cube, CubeSide.Down, CubeColor.Yellow, 9);
            CheckSide(cube, CubeSide.Back, CubeColor.Blue, 6, CubeColor.Orange, 3);
            CheckSide(cube, CubeSide.Right, CubeColor.Red, 6, CubeColor.Blue, 3);
            CheckSide(cube, CubeSide.Left, CubeColor.Orange, 6, CubeColor.Green, 3);
        }

        [TestMethod]
        public void TestRotationUpInverted()
        {
            var cube = new RubiksCube();
            cube.Rotate(CubeSlice.Up, MoveDirection.Inverted);

            CheckSide(cube, CubeSide.Up, CubeColor.White, 9);
            CheckSide(cube, CubeSide.Front, CubeColor.Green, 6, CubeColor.Orange, 3);
            CheckSide(cube, CubeSide.Down, CubeColor.Yellow, 9);
            CheckSide(cube, CubeSide.Back, CubeColor.Blue, 6, CubeColor.Red, 3);
            CheckSide(cube, CubeSide.Right, CubeColor.Red, 6, CubeColor.Green, 3);
            CheckSide(cube, CubeSide.Left, CubeColor.Orange, 6, CubeColor.Blue, 3);
        }

        [TestMethod]
        public void TestRotationDown()
        {
            var cube = new RubiksCube();
            cube.Rotate(CubeSlice.Down);

            CheckSide(cube, CubeSide.Up, Tuple(CubeColor.White, 9));
            CheckSide(cube, CubeSide.Front, Tuple(CubeColor.Green, 6), Tuple(CubeColor.Orange, 3));
            CheckSide(cube, CubeSide.Down, Tuple(CubeColor.Yellow, 9));
            CheckSide(cube, CubeSide.Back, Tuple(CubeColor.Blue, 6), Tuple(CubeColor.Red, 3));
            CheckSide(cube, CubeSide.Right, Tuple(CubeColor.Red, 6), Tuple(CubeColor.Green, 3));
            CheckSide(cube, CubeSide.Left, Tuple(CubeColor.Orange, 6), Tuple(CubeColor.Blue, 3));
        }

        [TestMethod]
        public void TestRotationDownInverted()
        {
            var cube = new RubiksCube();
            cube.Rotate(CubeSlice.Down, MoveDirection.Inverted);

            CheckSide(cube, CubeSide.Up, Tuple(CubeColor.White, 9));
            CheckSide(cube, CubeSide.Front, Tuple(CubeColor.Green, 6), Tuple(CubeColor.Red, 3));
            CheckSide(cube, CubeSide.Down, Tuple(CubeColor.Yellow, 9));
            CheckSide(cube, CubeSide.Back, Tuple(CubeColor.Blue, 6), Tuple(CubeColor.Orange, 3));
            CheckSide(cube, CubeSide.Right, Tuple(CubeColor.Red, 6), Tuple(CubeColor.Blue, 3));
            CheckSide(cube, CubeSide.Left, Tuple(CubeColor.Orange, 6), Tuple(CubeColor.Green, 3));
        }

        [TestMethod]
        public void TestRotationMiddle()
        {
            var cube = new RubiksCube();
            cube.Rotate(CubeSlice.Middle);

            CheckSide(cube, CubeSide.Up, Tuple(CubeColor.White, 6), Tuple(CubeColor.Blue, 3));
            CheckSide(cube, CubeSide.Front, Tuple(CubeColor.Green, 6), Tuple(CubeColor.White, 3));
            CheckSide(cube, CubeSide.Down, Tuple(CubeColor.Yellow, 6), Tuple(CubeColor.Green, 3));
            CheckSide(cube, CubeSide.Back, Tuple(CubeColor.Blue, 6), Tuple(CubeColor.Yellow, 3));
            CheckSide(cube, CubeSide.Right, Tuple(CubeColor.Red, 9));
            CheckSide(cube, CubeSide.Left, Tuple(CubeColor.Orange, 9));
        }

        [TestMethod]
        public void TestRotationMiddleInverted()
        {
            var cube = new RubiksCube();
            cube.Rotate(CubeSlice.Middle, MoveDirection.Inverted);

            CheckSide(cube, CubeSide.Up, Tuple(CubeColor.White, 6), Tuple(CubeColor.Green, 3));
            CheckSide(cube, CubeSide.Front, Tuple(CubeColor.Green, 6), Tuple(CubeColor.Yellow, 3));
            CheckSide(cube, CubeSide.Down, Tuple(CubeColor.Yellow, 6), Tuple(CubeColor.Blue, 3));
            CheckSide(cube, CubeSide.Back, Tuple(CubeColor.Blue, 6), Tuple(CubeColor.White, 3));
            CheckSide(cube, CubeSide.Right, Tuple(CubeColor.Red, 9));
            CheckSide(cube, CubeSide.Left, Tuple(CubeColor.Orange, 9));
        }

        [TestMethod]
        public void TestRotationEquator()
        {
            var cube = new RubiksCube();
            cube.Rotate(CubeSlice.Equator);

            CheckSide(cube, CubeSide.Up, Tuple(CubeColor.White, 9));
            CheckSide(cube, CubeSide.Front, Tuple(CubeColor.Green, 6), Tuple(CubeColor.Orange, 3));
            CheckSide(cube, CubeSide.Down, Tuple(CubeColor.Yellow, 9));
            CheckSide(cube, CubeSide.Back, Tuple(CubeColor.Blue, 6), Tuple(CubeColor.Red, 3));
            CheckSide(cube, CubeSide.Right, Tuple(CubeColor.Red, 6), Tuple(CubeColor.Green, 3));
            CheckSide(cube, CubeSide.Left, Tuple(CubeColor.Orange, 6), Tuple(CubeColor.Blue, 3));
        }

        [TestMethod]
        public void TestRotationEquatorInverted()
        {
            var cube = new RubiksCube();
            cube.Rotate(CubeSlice.Equator, MoveDirection.Inverted);

            CheckSide(cube, CubeSide.Up, Tuple(CubeColor.White, 9));
            CheckSide(cube, CubeSide.Front, Tuple(CubeColor.Green, 6), Tuple(CubeColor.Red, 3));
            CheckSide(cube, CubeSide.Down, Tuple(CubeColor.Yellow, 9));
            CheckSide(cube, CubeSide.Back, Tuple(CubeColor.Blue, 6), Tuple(CubeColor.Orange, 3));
            CheckSide(cube, CubeSide.Right, Tuple(CubeColor.Red, 6), Tuple(CubeColor.Blue, 3));
            CheckSide(cube, CubeSide.Left, Tuple(CubeColor.Orange, 6), Tuple(CubeColor.Green, 3));
        }

        [TestMethod]
        public void TestRotationEquatorDouble()
        {
            var cube = new RubiksCube();
            cube.Rotate(CubeSlice.Equator, MoveDirection.Double);

            CheckSide(cube, CubeSide.Up, Tuple(CubeColor.White, 9));
            CheckSide(cube, CubeSide.Front, Tuple(CubeColor.Green, 6), Tuple(CubeColor.Blue, 3));
            CheckSide(cube, CubeSide.Down, Tuple(CubeColor.Yellow, 9));
            CheckSide(cube, CubeSide.Back, Tuple(CubeColor.Blue, 6), Tuple(CubeColor.Green, 3));
            CheckSide(cube, CubeSide.Right, Tuple(CubeColor.Red, 6), Tuple(CubeColor.Orange, 3));
            CheckSide(cube, CubeSide.Left, Tuple(CubeColor.Orange, 6), Tuple(CubeColor.Red, 3));
        }

        [TestMethod]
        public void TestRotationMiddleDouble()
        {
            var cube = new RubiksCube();
            cube.Rotate(CubeSlice.Middle, MoveDirection.Double);

            CheckSide(cube, CubeSide.Up, Tuple(CubeColor.White, 6), Tuple(CubeColor.Yellow, 3));
            CheckSide(cube, CubeSide.Front, Tuple(CubeColor.Green, 6), Tuple(CubeColor.Blue, 3));
            CheckSide(cube, CubeSide.Down, Tuple(CubeColor.Yellow, 6), Tuple(CubeColor.White, 3));
            CheckSide(cube, CubeSide.Back, Tuple(CubeColor.Blue, 6), Tuple(CubeColor.Green, 3));
            CheckSide(cube, CubeSide.Right, Tuple(CubeColor.Red, 9));
            CheckSide(cube, CubeSide.Left, Tuple(CubeColor.Orange, 9));
        }

        [TestMethod]
        public void TestReset()
        {
            var cube = new RubiksCube();
            cube.Rotate(CubeSlice.Back);
            cube.Rotate(CubeSlice.Right);
            cube.Rotate(CubeSlice.Down);
            cube.Rotate(CubeSlice.Front);
            cube.Rotate(CubeSlice.Left);
            cube.Rotate(CubeSlice.Up);
            cube.Reset();

            CheckSide(cube, CubeSide.Up, Tuple(CubeColor.White, 9));
            CheckSide(cube, CubeSide.Front, Tuple(CubeColor.Green, 9));
            CheckSide(cube, CubeSide.Down, Tuple(CubeColor.Yellow, 9));
            CheckSide(cube, CubeSide.Back, Tuple(CubeColor.Blue, 9));
            CheckSide(cube, CubeSide.Right, Tuple(CubeColor.Red, 9));
            CheckSide(cube, CubeSide.Left, Tuple(CubeColor.Orange, 9));
        }

        [TestMethod]
        public void TestGetPieces()
        {
            var cube = new RubiksCube();
            var pieces = cube.GetPieces();
            pieces.Count.Should().Be(26);
            for (int x = 0; x <= 2; x++)
            {
                for (int y = 0; y <= 2; y++)
                {
                    for (int z = 0; z <= 2; z++)
                    {
                        if (!(x == 1 && y == 1 && z == 1))
                        {
                            pieces.Count(p => p.Position.Equals(new Position {X = x, Y = y, Z = z})).Should().Be(1);
                        }
                    }
                }
            }
        }

        [TestMethod]
        public void TestAlgorithm()
        {
            var cube = new RubiksCube();
            cube.ExecAlgorithm("(R R')(D' D)(U U')(F' F)(B B')(L L')");

            CheckSide(cube, CubeSide.Up, CubeColor.White, 9);
            CheckSide(cube, CubeSide.Front, CubeColor.Green, 9);
            CheckSide(cube, CubeSide.Down, CubeColor.Yellow, 9);
            CheckSide(cube, CubeSide.Back, CubeColor.Blue, 9);
            CheckSide(cube, CubeSide.Right, CubeColor.Red, 9);
            CheckSide(cube, CubeSide.Left, CubeColor.Orange, 9);
        }

        [TestMethod]
        public void TestAlgorithm2()
        {
            var cube = new RubiksCube();
            cube.ExecAlgorithm("FRUR'U'F'");

            CheckSide(cube, CubeSide.Up, Tuple(CubeColor.White, 5), Tuple(CubeColor.Blue, 1), Tuple(CubeColor.Green, 1), Tuple(CubeColor.Orange, 2));
            CheckSide(cube, CubeSide.Front, Tuple(CubeColor.Green, 7), Tuple(CubeColor.Red, 1), Tuple(CubeColor.White, 1));
            CheckSide(cube, CubeSide.Down, CubeColor.Yellow, 9);
            CheckSide(cube, CubeSide.Back, Tuple(CubeColor.Blue, 7), Tuple(CubeColor.Red, 2));
            CheckSide(cube, CubeSide.Right, Tuple(CubeColor.Red, 6), Tuple(CubeColor.White, 3));
            CheckSide(cube, CubeSide.Left, Tuple(CubeColor.Orange, 7), Tuple(CubeColor.Blue, 1), Tuple(CubeColor.Green, 1));
        }

        [TestMethod]
        public void TestInvalidAlgorithm()
        {
            var cube = new RubiksCube();
            Action action = () =>
            {
                cube.ExecAlgorithm("RFX");
            };
            action.Should().Throw<Exception>();
        }

        private static Tuple<CubeColor, int> Tuple(CubeColor color, int count) => new Tuple<CubeColor, int>(color,count);

        private void CheckSide(RubiksCube cube, CubeSide side, CubeColor firstCubeColor, int firstCount, CubeColor? secondCubeColor = null, int? secondCount = null)
        {
            if (secondCubeColor.HasValue && secondCount.HasValue)
            {
                CheckSide(cube,side,Tuple(firstCubeColor,firstCount),Tuple(secondCubeColor.Value, secondCount.Value));
            }
            else
            {
                CheckSide(cube, side, Tuple(firstCubeColor, firstCount));
            }
        }

        private void CheckSide(RubiksCube cube, CubeSide side, params Tuple<CubeColor,int>[] colorCounters)
        {
            var tags = cube.GetTags(side);
            tags.Count.Should().Be(9);
            foreach (var colorCounter in colorCounters)
            {
                tags.Count(t => t.CubeColor == colorCounter.Item1).Should().Be(colorCounter.Item2);
            }
        }
    }
}
