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
            startButton.BackColor = SystemColors.Highlight;
            startButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startButton.ForeColor = SystemColors.ButtonHighlight;
            startButton.Location = new Point(929, 51);
            startButton.Name = "startButton";
            startButton.Size = new Size(121, 40);
            startButton.TabIndex = 1;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += StartButton_Click;
            // 
            // resetButton
            // 
            resetButton.BackColor = SystemColors.Highlight;
            resetButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resetButton.ForeColor = SystemColors.ButtonHighlight;
            resetButton.Location = new Point(929, 111);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(121, 41);
            resetButton.TabIndex = 2;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = false;
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
            leftButton.BackColor = SystemColors.Highlight;
            leftButton.ForeColor = SystemColors.ControlLightLight;
            leftButton.Location = new Point(929, 169);
            leftButton.Name = "leftButton";
            leftButton.Size = new Size(121, 41);
            leftButton.TabIndex = 4;
            leftButton.Text = "Left";
            leftButton.UseVisualStyleBackColor = false;
            leftButton.Click += LeftButton_Click;
            // 
            // rightButton
            // 
            rightButton.BackColor = SystemColors.MenuHighlight;
            rightButton.ForeColor = SystemColors.ButtonHighlight;
            rightButton.Location = new Point(929, 227);
            rightButton.Name = "rightButton";
            rightButton.Size = new Size(121, 43);
            rightButton.TabIndex = 5;
            rightButton.Text = "Right";
            rightButton.UseVisualStyleBackColor = false;
            rightButton.Click += RightButton_Click;
            // 
            // rotateButton
            // 
            rotateButton.BackColor = SystemColors.Highlight;
            rotateButton.ForeColor = SystemColors.ButtonHighlight;
            rotateButton.Location = new Point(929, 292);
            rotateButton.Name = "rotateButton";
            rotateButton.Size = new Size(121, 38);
            rotateButton.TabIndex = 6;
            rotateButton.Text = "Rotate";
            rotateButton.UseVisualStyleBackColor = false;
            rotateButton.Click += RotateButton_Click;
            // 
            // downButton
            // 
            downButton.BackColor = SystemColors.Highlight;
            downButton.ForeColor = SystemColors.ButtonHighlight;
            downButton.Location = new Point(929, 357);
            downButton.Name = "downButton";
            downButton.Size = new Size(121, 41);
            downButton.TabIndex = 7;
            downButton.Text = "Down";
            downButton.UseVisualStyleBackColor = false;
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

