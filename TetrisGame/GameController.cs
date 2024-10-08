using System;
using System.Collections.Generic;
using System.Timers;
using System.Windows.Forms;

namespace TetrisGame
{
    public class GameController
    {
        private GameBoard board;
        private Tetromino currentPiece;
        private System.Timers.Timer gameTimer;
        private bool isGameOver;
        private Random random;

        public GameController(GameBoard board)
        {
            this.board = board;
            random = new Random();
            InitializeTimer();
            SpawnNewPiece();
        }

        private void InitializeTimer()
        {
            gameTimer = new System.Timers.Timer(500); // Intervalo de caída de piezas (500 ms)
            gameTimer.Elapsed += OnGameTick;
            gameTimer.AutoReset = true;
        }

        public void StartGame()
        {
            isGameOver = false;
            gameTimer.Start(); // Comenzar el temporizador del juego
        }

        private void OnGameTick(object sender, ElapsedEventArgs e)
        {
            if (isGameOver) return;
            MovePieceDown();
        }

        public void SpawnNewPiece()
        {
            int[,] shape = GenerateRandomShape();
            currentPiece = new Tetromino(shape);
            currentPiece.X = board.Columns / 2 - currentPiece.Shape.GetLength(1) / 2;
            currentPiece.Y = 0;

            if (!board.IsPositionValid(currentPiece, 0, 0))
            {
                isGameOver = true;
                gameTimer.Stop();
                MessageBox.Show("Game Over!");
            }
        }

        private int[,] GenerateRandomShape()
        {
            List<int[,]> tetrominoShapes = new List<int[,]>
            {
                new int[,] { { 1, 1, 1, 1 } },               // Línea
                new int[,] { { 1, 1, 1 }, { 0, 1, 0 } },    // T
                new int[,] { { 1, 1, 0 }, { 0, 1, 1 } },    // S
                new int[,] { { 0, 1, 1 }, { 1, 1, 0 } },    // Z
                new int[,] { { 1, 1 }, { 1, 1 } }           // Cuadrado
            };

            int shapeIndex = random.Next(tetrominoShapes.Count);
            return tetrominoShapes[shapeIndex];
        }

        public void MovePieceLeft()
        {
            if (board.IsPositionValid(currentPiece, -1, 0))
            {
                currentPiece.X -= 1;
            }
        }

        public void MovePieceRight()
        {
            if (board.IsPositionValid(currentPiece, 1, 0))
            {
                currentPiece.X += 1;
            }
        }

        public void RotatePiece()
        {
            currentPiece.Rotate();
            if (!board.IsPositionValid(currentPiece, 0, 0))
            {
                currentPiece.Rotate();
                currentPiece.Rotate();
                currentPiece.Rotate();
            }
        }

        public void MovePieceDown()
        {
            if (board.IsPositionValid(currentPiece, 0, 1))
            {
                currentPiece.Y += 1;
            }
            else
            {
                board.PlacePiece(currentPiece);
                board.ClearFullRows();
                SpawnNewPiece();
            }
        }
    }
}
