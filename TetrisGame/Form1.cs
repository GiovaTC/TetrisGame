using System;
using System.Windows.Forms;

namespace TetrisGame
{
    public partial class Form1 : Form
    {
        private GameController gameController;
        private GameBoard gameBoard;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            gameBoard = new GameBoard(20, 10); // Tamaño del tablero estándar de Tetris
            gameController = new GameController(gameBoard);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            InitializeGame();
            gameController.StartGame(); // Asegurarse de que el juego realmente comience
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            gameController.MovePieceLeft();
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            gameController.MovePieceRight();
        }

        private void RotateButton_Click(object sender, EventArgs e)
        {
            gameController.RotatePiece();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            gameController.MovePieceDown();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cualquier lógica de inicialización adicional si es necesaria
        }
    }
}
