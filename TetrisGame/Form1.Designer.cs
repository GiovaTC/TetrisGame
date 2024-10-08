namespace TetrisGame
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método requerido para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            gamePanel = new Panel();
            startButton = new Button();
            resetButton = new Button();
            scoreLabel = new Label();
            leftButton = new Button();
            rightButton = new Button();
            rotateButton = new Button();
            downButton = new Button();
            SuspendLayout();
            // 
            // gamePanel
            // 
            gamePanel.BackColor = Color.Black;
            gamePanel.Location = new Point(227, 28);
            gamePanel.Name = "gamePanel";
            gamePanel.Size = new Size(592, 416);
            gamePanel.TabIndex = 0;
            // 
            // startButton
            // 
            startButton.Location = new Point(929, 51);
            startButton.Name = "startButton";
            startButton.Size = new Size(75, 23);
            startButton.TabIndex = 1;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += StartButton_Click;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(929, 97);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(75, 23);
            resetButton.TabIndex = 2;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += ResetButton_Click;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(929, 137);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(48, 15);
            scoreLabel.TabIndex = 3;
            scoreLabel.Text = "Score: 0";
            // 
            // leftButton
            // 
            leftButton.Location = new Point(929, 169);
            leftButton.Name = "leftButton";
            leftButton.Size = new Size(75, 23);
            leftButton.TabIndex = 4;
            leftButton.Text = "Left";
            leftButton.UseVisualStyleBackColor = true;
            leftButton.Click += LeftButton_Click;
            // 
            // rightButton
            // 
            rightButton.Location = new Point(929, 216);
            rightButton.Name = "rightButton";
            rightButton.Size = new Size(75, 23);
            rightButton.TabIndex = 5;
            rightButton.Text = "Right";
            rightButton.UseVisualStyleBackColor = true;
            rightButton.Click += RightButton_Click;
            // 
            // rotateButton
            // 
            rotateButton.Location = new Point(929, 262);
            rotateButton.Name = "rotateButton";
            rotateButton.Size = new Size(75, 23);
            rotateButton.TabIndex = 6;
            rotateButton.Text = "Rotate";
            rotateButton.UseVisualStyleBackColor = true;
            rotateButton.Click += RotateButton_Click;
            // 
            // downButton
            // 
            downButton.Location = new Point(929, 311);
            downButton.Name = "downButton";
            downButton.Size = new Size(75, 23);
            downButton.TabIndex = 7;
            downButton.Text = "Down";
            downButton.UseVisualStyleBackColor = true;
            downButton.Click += DownButton_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(1460, 542);
            Controls.Add(gamePanel);
            Controls.Add(startButton);
            Controls.Add(resetButton);
            Controls.Add(scoreLabel);
            Controls.Add(leftButton);
            Controls.Add(rightButton);
            Controls.Add(rotateButton);
            Controls.Add(downButton);
            Name = "Form1";
            Text = "Tetris Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button rotateButton;
        private System.Windows.Forms.Button downButton;
    }
}

