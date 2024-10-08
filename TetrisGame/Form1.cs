using System;
using System.Drawing;
using System.Windows.Forms;


namespace TetrisGame
{
    public partial class Form1 : Form
    {
        private GameController gameController;
        private GameBoard gameBoard;
        private const int CellSize = 25; // Tamaño de cada celda en el panel del juego

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
            gamePanel.Paint += GamePanel_Paint; // Vinculamos el evento de dibujo del panel
        }

        private void InitializeGame()
        {
            gameBoard = new GameBoard(20, 10); // Tamaño del tablero estándar de Tetris
            gameController = new GameController(gameBoard);
            gameController.GameUpdated += OnGameUpdated; // Vinculamos el evento de actualización del juego
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            InitializeGame();
            gameController.StartGame(); // Inicia el juego
            gamePanel.Invalidate(); // Redibuja el panel
        }

        private void OnGameUpdated()
        {
            gamePanel.Invalidate(); // Redibuja el panel cuando se actualiza el juego
        }

        private void GamePanel_Paint(object sender, PaintEventArgs e)
        {
            DrawGameBoard(e.Graphics);
        }

        private void DrawGameBoard(Graphics graphics)
        {
            for (int row = 0; row < gameBoard.Rows; row++)
            {
                for (int col = 0; col < gameBoard.Columns; col++)
                {
                    if (gameBoard.GetCell(row, col) != 0)
                    {
                        DrawCell(graphics, col, row, Color.Blue); // Dibujar las celdas ocupadas
                    }
                }
            }

            // Dibujar la pieza actual
            if (gameController.CurrentPiece != null)
            {
                foreach (Tuple<int, int> cell in gameController.CurrentPiece.GetFilledCells())
                {
                    int x = cell.Item1;
                    int y = cell.Item2;
                    DrawCell(graphics, x + gameController.CurrentPiece.X, y + gameController.CurrentPiece.Y, Color.Red);
                }
            }
        }


        private void DrawCell(Graphics graphics, int x, int y, Color color)
        {
            graphics.FillRectangle(new SolidBrush(color), x * CellSize, y * CellSize, CellSize, CellSize);
            graphics.DrawRectangle(Pens.Black, x * CellSize, y * CellSize, CellSize, CellSize);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            InitializeGame();
            gamePanel.Invalidate();
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            gameController.MovePieceLeft();
            gamePanel.Invalidate();
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            gameController.MovePieceRight();
            gamePanel.Invalidate();
        }

        private void RotateButton_Click(object sender, EventArgs e)
        {
            gameController.RotatePiece();
            gamePanel.Invalidate();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            gameController.MovePieceDown();
            gamePanel.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cualquier lógica adicional de inicialización si es necesaria
        }

        private void scoreLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
