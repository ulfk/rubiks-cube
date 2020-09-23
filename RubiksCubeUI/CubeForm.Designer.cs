namespace RubiksCubeUI
{
    partial class CubeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CubeForm));
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonRightInverted = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonLeftInverted = new System.Windows.Forms.Button();
            this.buttonFront = new System.Windows.Forms.Button();
            this.buttonFrontInverted = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonBackInverted = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonUpInverted = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonDownInverted = new System.Windows.Forms.Button();
            this.textBoxAlgorithm = new System.Windows.Forms.TextBox();
            this.labelAlgorithm = new System.Windows.Forms.Label();
            this.labelAlgorithmState = new System.Windows.Forms.Label();
            this.buttonAlgorithExecute = new System.Windows.Forms.Button();
            this.buttonRightDouble = new System.Windows.Forms.Button();
            this.buttonLeftDouble = new System.Windows.Forms.Button();
            this.buttonFrontDouble = new System.Windows.Forms.Button();
            this.buttonBackDouble = new System.Windows.Forms.Button();
            this.buttonUpDouble = new System.Windows.Forms.Button();
            this.buttonDownDouble = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(29, 339);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(31, 29);
            this.buttonRight.TabIndex = 0;
            this.buttonRight.Text = "R";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonRightInverted
            // 
            this.buttonRightInverted.Location = new System.Drawing.Point(29, 374);
            this.buttonRightInverted.Name = "buttonRightInverted";
            this.buttonRightInverted.Size = new System.Drawing.Size(31, 29);
            this.buttonRightInverted.TabIndex = 1;
            this.buttonRightInverted.Text = "R\'";
            this.buttonRightInverted.UseVisualStyleBackColor = true;
            this.buttonRightInverted.Click += new System.EventHandler(this.buttonRightInverted_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(66, 339);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(31, 29);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.Text = "L";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonLeftInverted
            // 
            this.buttonLeftInverted.Location = new System.Drawing.Point(66, 374);
            this.buttonLeftInverted.Name = "buttonLeftInverted";
            this.buttonLeftInverted.Size = new System.Drawing.Size(31, 29);
            this.buttonLeftInverted.TabIndex = 3;
            this.buttonLeftInverted.Text = "L\'";
            this.buttonLeftInverted.UseVisualStyleBackColor = true;
            this.buttonLeftInverted.Click += new System.EventHandler(this.buttonLeftInverted_Click);
            // 
            // buttonFront
            // 
            this.buttonFront.Location = new System.Drawing.Point(103, 339);
            this.buttonFront.Name = "buttonFront";
            this.buttonFront.Size = new System.Drawing.Size(31, 29);
            this.buttonFront.TabIndex = 4;
            this.buttonFront.Text = "F";
            this.buttonFront.UseVisualStyleBackColor = true;
            this.buttonFront.Click += new System.EventHandler(this.buttonFront_Click);
            // 
            // buttonFrontInverted
            // 
            this.buttonFrontInverted.Location = new System.Drawing.Point(103, 374);
            this.buttonFrontInverted.Name = "buttonFrontInverted";
            this.buttonFrontInverted.Size = new System.Drawing.Size(31, 29);
            this.buttonFrontInverted.TabIndex = 5;
            this.buttonFrontInverted.Text = "F\'";
            this.buttonFrontInverted.UseVisualStyleBackColor = true;
            this.buttonFrontInverted.Click += new System.EventHandler(this.buttonFrontInverted_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(394, 311);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(82, 29);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "Reset Cube";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(140, 339);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(31, 29);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "B";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonBackInverted
            // 
            this.buttonBackInverted.Location = new System.Drawing.Point(140, 374);
            this.buttonBackInverted.Name = "buttonBackInverted";
            this.buttonBackInverted.Size = new System.Drawing.Size(31, 29);
            this.buttonBackInverted.TabIndex = 8;
            this.buttonBackInverted.Text = "B\'";
            this.buttonBackInverted.UseVisualStyleBackColor = true;
            this.buttonBackInverted.Click += new System.EventHandler(this.buttonBackInverted_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(177, 339);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(31, 29);
            this.buttonUp.TabIndex = 9;
            this.buttonUp.Text = "U";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonUpInverted
            // 
            this.buttonUpInverted.Location = new System.Drawing.Point(177, 374);
            this.buttonUpInverted.Name = "buttonUpInverted";
            this.buttonUpInverted.Size = new System.Drawing.Size(31, 29);
            this.buttonUpInverted.TabIndex = 10;
            this.buttonUpInverted.Text = "U\'";
            this.buttonUpInverted.UseVisualStyleBackColor = true;
            this.buttonUpInverted.Click += new System.EventHandler(this.buttonUpInverted_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(214, 339);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(31, 29);
            this.buttonDown.TabIndex = 11;
            this.buttonDown.Text = "D";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonDownInverted
            // 
            this.buttonDownInverted.Location = new System.Drawing.Point(214, 374);
            this.buttonDownInverted.Name = "buttonDownInverted";
            this.buttonDownInverted.Size = new System.Drawing.Size(31, 29);
            this.buttonDownInverted.TabIndex = 12;
            this.buttonDownInverted.Text = "D\'";
            this.buttonDownInverted.UseVisualStyleBackColor = true;
            this.buttonDownInverted.Click += new System.EventHandler(this.buttonDownInverted_Click);
            // 
            // textBoxAlgorithm
            // 
            this.textBoxAlgorithm.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAlgorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAlgorithm.Location = new System.Drawing.Point(295, 403);
            this.textBoxAlgorithm.Name = "textBoxAlgorithm";
            this.textBoxAlgorithm.Size = new System.Drawing.Size(174, 22);
            this.textBoxAlgorithm.TabIndex = 13;
            this.textBoxAlgorithm.TextChanged += new System.EventHandler(this.textBoxAlgorithm_TextChanged);
            // 
            // labelAlgorithm
            // 
            this.labelAlgorithm.AutoSize = true;
            this.labelAlgorithm.Location = new System.Drawing.Point(292, 387);
            this.labelAlgorithm.Name = "labelAlgorithm";
            this.labelAlgorithm.Size = new System.Drawing.Size(53, 13);
            this.labelAlgorithm.TabIndex = 14;
            this.labelAlgorithm.Text = "Algorithm:";
            // 
            // labelAlgorithmState
            // 
            this.labelAlgorithmState.AutoSize = true;
            this.labelAlgorithmState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlgorithmState.ForeColor = System.Drawing.Color.Green;
            this.labelAlgorithmState.Location = new System.Drawing.Point(295, 433);
            this.labelAlgorithmState.Name = "labelAlgorithmState";
            this.labelAlgorithmState.Size = new System.Drawing.Size(30, 18);
            this.labelAlgorithmState.TabIndex = 15;
            this.labelAlgorithmState.Text = "Ok";
            // 
            // buttonAlgorithExecute
            // 
            this.buttonAlgorithExecute.Enabled = false;
            this.buttonAlgorithExecute.Location = new System.Drawing.Point(394, 432);
            this.buttonAlgorithExecute.Name = "buttonAlgorithExecute";
            this.buttonAlgorithExecute.Size = new System.Drawing.Size(75, 23);
            this.buttonAlgorithExecute.TabIndex = 16;
            this.buttonAlgorithExecute.Text = "Execute";
            this.buttonAlgorithExecute.UseVisualStyleBackColor = true;
            this.buttonAlgorithExecute.Click += new System.EventHandler(this.buttonAlgorithExecute_Click);
            // 
            // buttonRightDouble
            // 
            this.buttonRightDouble.Location = new System.Drawing.Point(29, 409);
            this.buttonRightDouble.Name = "buttonRightDouble";
            this.buttonRightDouble.Size = new System.Drawing.Size(31, 29);
            this.buttonRightDouble.TabIndex = 17;
            this.buttonRightDouble.Text = "R2";
            this.buttonRightDouble.UseVisualStyleBackColor = true;
            this.buttonRightDouble.Click += new System.EventHandler(this.buttonRightDouble_Click);
            // 
            // buttonLeftDouble
            // 
            this.buttonLeftDouble.Location = new System.Drawing.Point(66, 409);
            this.buttonLeftDouble.Name = "buttonLeftDouble";
            this.buttonLeftDouble.Size = new System.Drawing.Size(31, 29);
            this.buttonLeftDouble.TabIndex = 18;
            this.buttonLeftDouble.Text = "L2";
            this.buttonLeftDouble.UseVisualStyleBackColor = true;
            this.buttonLeftDouble.Click += new System.EventHandler(this.buttonLeftDouble_Click);
            // 
            // buttonFrontDouble
            // 
            this.buttonFrontDouble.Location = new System.Drawing.Point(103, 409);
            this.buttonFrontDouble.Name = "buttonFrontDouble";
            this.buttonFrontDouble.Size = new System.Drawing.Size(31, 29);
            this.buttonFrontDouble.TabIndex = 19;
            this.buttonFrontDouble.Text = "F2";
            this.buttonFrontDouble.UseVisualStyleBackColor = true;
            this.buttonFrontDouble.Click += new System.EventHandler(this.buttonFrontDouble_Click);
            // 
            // buttonBackDouble
            // 
            this.buttonBackDouble.Location = new System.Drawing.Point(140, 409);
            this.buttonBackDouble.Name = "buttonBackDouble";
            this.buttonBackDouble.Size = new System.Drawing.Size(31, 29);
            this.buttonBackDouble.TabIndex = 20;
            this.buttonBackDouble.Text = "B2";
            this.buttonBackDouble.UseVisualStyleBackColor = true;
            this.buttonBackDouble.Click += new System.EventHandler(this.buttonBackDouble_Click);
            // 
            // buttonUpDouble
            // 
            this.buttonUpDouble.Location = new System.Drawing.Point(177, 409);
            this.buttonUpDouble.Name = "buttonUpDouble";
            this.buttonUpDouble.Size = new System.Drawing.Size(31, 29);
            this.buttonUpDouble.TabIndex = 21;
            this.buttonUpDouble.Text = "U2";
            this.buttonUpDouble.UseVisualStyleBackColor = true;
            this.buttonUpDouble.Click += new System.EventHandler(this.buttonUpDouble_Click);
            // 
            // buttonDownDouble
            // 
            this.buttonDownDouble.Location = new System.Drawing.Point(214, 409);
            this.buttonDownDouble.Name = "buttonDownDouble";
            this.buttonDownDouble.Size = new System.Drawing.Size(31, 29);
            this.buttonDownDouble.TabIndex = 22;
            this.buttonDownDouble.Text = "D2";
            this.buttonDownDouble.UseVisualStyleBackColor = true;
            this.buttonDownDouble.Click += new System.EventHandler(this.buttonDownDouble_Click);
            // 
            // CubeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 505);
            this.Controls.Add(this.buttonDownDouble);
            this.Controls.Add(this.buttonUpDouble);
            this.Controls.Add(this.buttonBackDouble);
            this.Controls.Add(this.buttonFrontDouble);
            this.Controls.Add(this.buttonLeftDouble);
            this.Controls.Add(this.buttonRightDouble);
            this.Controls.Add(this.buttonAlgorithExecute);
            this.Controls.Add(this.labelAlgorithmState);
            this.Controls.Add(this.labelAlgorithm);
            this.Controls.Add(this.textBoxAlgorithm);
            this.Controls.Add(this.buttonDownInverted);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUpInverted);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonBackInverted);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonFrontInverted);
            this.Controls.Add(this.buttonFront);
            this.Controls.Add(this.buttonLeftInverted);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonRightInverted);
            this.Controls.Add(this.buttonRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CubeForm";
            this.Text = "Rubik\'s Cube UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonRightInverted;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonLeftInverted;
        private System.Windows.Forms.Button buttonFront;
        private System.Windows.Forms.Button buttonFrontInverted;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonBackInverted;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonUpInverted;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonDownInverted;
        private System.Windows.Forms.TextBox textBoxAlgorithm;
        private System.Windows.Forms.Label labelAlgorithm;
        private System.Windows.Forms.Label labelAlgorithmState;
        private System.Windows.Forms.Button buttonAlgorithExecute;
        private System.Windows.Forms.Button buttonRightDouble;
        private System.Windows.Forms.Button buttonLeftDouble;
        private System.Windows.Forms.Button buttonFrontDouble;
        private System.Windows.Forms.Button buttonBackDouble;
        private System.Windows.Forms.Button buttonUpDouble;
        private System.Windows.Forms.Button buttonDownDouble;
    }
}

