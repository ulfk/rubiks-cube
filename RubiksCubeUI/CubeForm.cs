using System;
using System.Drawing;
using System.Windows.Forms;
using RubiksCubeLib;

namespace RubiksCubeUI
{
    public partial class CubeForm : Form
    {
        private readonly RubiksCube _cube;
        private readonly Label[,,,] _labels;

        public CubeForm()
        {
            _cube = new RubiksCube();
            _labels = new Label[3, 3, 3, 6];
            InitializeComponent();
            InitCubeView();
        }

        private void InitCubeView()
        {
            this.SuspendLayout();

            foreach (var piece in _cube.GetPieces())
            {
                foreach (var colorTag in piece.ColorTags)
                {
                    var panel = CreatePanel(
                        colorTag.CubeOrientation, 
                        colorTag.CubeColor, 
                        piece.Position.X,
                        piece.Position.Y, 
                        piece.Position.Z);

                    this.Controls.Add(panel);
                }
            }

            this.ResumeLayout(false);
        }

        private Label CreatePanel(CubeOrientation orientation, CubeColor color, int X, int Y, int Z)
        {
            const int mainMarginX = 20;
            const int mainMarginY = 20;
            const int basicSize = 30;
            const int margin = 2;
            const int dimension = basicSize + margin;
            var size = new Size(basicSize, basicSize);
            var offset = new Point();
            var calcX = 0;
            var calcY = 0;
            if (orientation == CubeOrientation.Up)
            {
                offset = new Point(mainMarginX + dimension * 3, mainMarginY);
                calcX = X;
                calcY = 2 - Z;
            }
            else if (orientation == CubeOrientation.Front)
            {
                offset = new Point(mainMarginX + dimension * 3, mainMarginY + dimension * 3);
                calcX = X;
                calcY = 2 - Y;
            }
            else if (orientation == CubeOrientation.Down)
            {
                offset = new Point(mainMarginX + dimension * 3, mainMarginY + dimension * 6);
                calcX = X;
                calcY = Z;
            }
            else if (orientation == CubeOrientation.Back)
            {
                offset = new Point(mainMarginX + dimension * 9, mainMarginY + dimension * 3);
                calcX = 2 - X;
                calcY = 2 - Y;
            }
            else if (orientation == CubeOrientation.Right)
            {
                offset = new Point(mainMarginX + dimension * 6, mainMarginY + dimension * 3);
                calcX = Z;
                calcY = 2 - Y;
            }
            else if (orientation == CubeOrientation.Left)
            {
                offset = new Point(mainMarginX, mainMarginY + dimension * 3);
                calcX = 2 - Z;
                calcY = 2 - Y;
            }

            var label = new Label
            {
                BackColor = MapCubeColor(color),
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(offset.X + dimension * calcX, offset.Y + dimension * calcY),
                Name = $"label{X}{Y}{Z}",
                Size = size,
                Text = calcX == 1 && calcY == 1 ? orientation.ToString().Substring(0, 1) : "",
                TabIndex = 0,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0)
            };

            _labels[X, Y, Z,(int)orientation] = label;

            return label;
        }

        private Color MapCubeColor(CubeColor color)
        {
            switch (color)
            {
                case CubeColor.Blue: return Color.Blue;
                case CubeColor.Green: return Color.Green;
                case CubeColor.Orange: return Color.Orange;
                case CubeColor.Red: return Color.Red;
                case CubeColor.White: return Color.White;
                case CubeColor.Yellow: return Color.Yellow;
                default: return Color.Gray;
            }
        }

        private void UpdateCubeView()
        {
            SuspendLayout();

            foreach (var piece in _cube.GetPieces())
            {
                foreach (var colorTag in piece.ColorTags)
                {
                    _labels[piece.Position.X, piece.Position.Y, piece.Position.Z, (int) colorTag.CubeOrientation].BackColor =
                        MapCubeColor(colorTag.CubeColor);
                }
            }

            ResumeLayout(false);
        }

        private void DoRotation(CubeOrientation side, MoveDirection moveDirection)
        {
            _cube.Rotate(side, moveDirection);
            UpdateCubeView();
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            DoRotation(CubeOrientation.Right, MoveDirection.Regular);
        }

        private void buttonRightInverted_Click(object sender, EventArgs e)
        {
            DoRotation(CubeOrientation.Right, MoveDirection.Inverted);
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            DoRotation(CubeOrientation.Left, MoveDirection.Regular);
        }

        private void buttonLeftInverted_Click(object sender, EventArgs e)
        {
            DoRotation(CubeOrientation.Left, MoveDirection.Inverted);
        }

        private void buttonFront_Click(object sender, EventArgs e)
        {
            DoRotation(CubeOrientation.Front, MoveDirection.Regular);
        }

        private void buttonFrontInverted_Click(object sender, EventArgs e)
        {
            DoRotation(CubeOrientation.Front, MoveDirection.Inverted);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            _cube.Reset();
            UpdateCubeView();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DoRotation(CubeOrientation.Back, MoveDirection.Regular);
        }

        private void buttonBackInverted_Click(object sender, EventArgs e)
        {
            DoRotation(CubeOrientation.Back, MoveDirection.Inverted);
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            DoRotation(CubeOrientation.Up, MoveDirection.Regular);
        }

        private void buttonUpInverted_Click(object sender, EventArgs e)
        {
            DoRotation(CubeOrientation.Up, MoveDirection.Inverted);
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            DoRotation(CubeOrientation.Down, MoveDirection.Regular);
        }

        private void buttonDownInverted_Click(object sender, EventArgs e)
        {
            DoRotation(CubeOrientation.Down, MoveDirection.Inverted);
        }

        private void textBoxAlgorithm_TextChanged(object sender, EventArgs e)
        {
            var isValid = _cube.IsAlgorithmValid(textBoxAlgorithm.Text);
            if (isValid)
            {
                labelAlgorithmState.ForeColor = Color.Green;
                labelAlgorithmState.Text = "Ok";
                buttonAlgorithExecute.Enabled = true;
            }
            else
            {
                labelAlgorithmState.ForeColor = Color.Red;
                labelAlgorithmState.Text = "Invalid!";
                buttonAlgorithExecute.Enabled = false;
            }
        }

        private void buttonAlgorithExecute_Click(object sender, EventArgs e)
        {
            _cube.ExecAlgorithm(textBoxAlgorithm.Text);
            UpdateCubeView();
        }

        private void buttonRightDouble_Click(object sender, EventArgs e)
        {
            DoRotation(CubeOrientation.Right, MoveDirection.Double);
        }

        private void buttonLeftDouble_Click(object sender, EventArgs e)
        {
            DoRotation(CubeOrientation.Left, MoveDirection.Double);
        }

        private void buttonFrontDouble_Click(object sender, EventArgs e)
        {
            DoRotation(CubeOrientation.Front, MoveDirection.Double);
        }

        private void buttonBackDouble_Click(object sender, EventArgs e)
        {
            DoRotation(CubeOrientation.Back, MoveDirection.Double);
        }

        private void buttonUpDouble_Click(object sender, EventArgs e)
        {
            DoRotation(CubeOrientation.Up, MoveDirection.Double);
        }

        private void buttonDownDouble_Click(object sender, EventArgs e)
        {
            DoRotation(CubeOrientation.Down, MoveDirection.Double);
        }
    }
}
