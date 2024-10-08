using System;
using System.Collections.Generic;
using System.Timers;
using System.Windows.Forms;

namespace TetrisGame
{
    public class GameController
    {
        public event Action GameUpdated; // Evento para notificar cuando el juego se actualiza

        private GameBoard board;
        private Tetromino currentPiece;
        private System.Timers.Timer gameTimer;
        private bool isGameOver;
        private Random random;

        public Tetromino CurrentPiece => currentPiece;

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
            gameTimer.Start(); // Comienza el temporizador del juego
        }

        private void OnGameTick(object sender, ElapsedEventArgs e)
        {
            if (isGameOver) return;
            MovePieceDown();
        }

        public void SpawnNewPiece()
        {
            currentPiece = TetrominoFactory.CreateRandomTetromino();
            currentPiece.X = board.Columns / 2 - currentPiece.Shape.GetLength(1) / 2;
            currentPiece.Y = 0;

            if (!board.IsPositionValid(currentPiece, 0, 0))
            {
                isGameOver = true;
                gameTimer.Stop();
                MessageBox.Show("Game Over!");
            }

            GameUpdated?.Invoke(); // Notifica que el juego se ha actualizado
        }

        public void MovePieceLeft()
        {
            if (board.IsPositionValid(currentPiece, -1, 0))
            {
                currentPiece.X -= 1;
                GameUpdated?.Invoke();
            }
        }

        public void MovePieceRight()
        {
            if (board.IsPositionValid(currentPiece, 1, 0))
            {
                currentPiece.X += 1;
                GameUpdated?.Invoke();
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
            GameUpdated?.Invoke();
        }

        public void MovePieceDown()
        {
            if (board.IsPositionValid(currentPiece, 0, 1))
            {
                currentPiece.Y += 1;
                GameUpdated?.Invoke();
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
