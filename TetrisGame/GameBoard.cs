using System;

namespace TetrisGame
{
    public class GameBoard
    {
        private int[,] board;
        public int Rows { get; }
        public int Columns { get; }

        public GameBoard(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            board = new int[rows, columns];
        }

        // Método para verificar si una celda está ocupada
        public int GetCell(int row, int column)
        {
            if (row < 0 || row >= Rows || column < 0 || column >= Columns)
            {
                throw new ArgumentOutOfRangeException("La posición está fuera de los límites del tablero.");
            }
            return board[row, column];
        }

        public bool IsPositionValid(Tetromino piece, int offsetX, int offsetY)
        {
            for (int row = 0; row < piece.Shape.GetLength(0); row++)
            {
                for (int col = 0; col < piece.Shape.GetLength(1); col++)
                {
                    if (piece.Shape[row, col] != 0)
                    {
                        int boardX = piece.X + col + offsetX;
                        int boardY = piece.Y + row + offsetY;

                        if (boardX < 0 || boardX >= Columns || boardY < 0 || boardY >= Rows || board[boardY, boardX] != 0)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        public void PlacePiece(Tetromino piece)
        {
            for (int row = 0; row < piece.Shape.GetLength(0); row++)
            {
                for (int col = 0; col < piece.Shape.GetLength(1); col++)
                {
                    if (piece.Shape[row, col] != 0)
                    {
                        board[piece.Y + row, piece.X + col] = 1;
                    }
                }
            }
        }

        public void ClearFullRows()
        {
            for (int row = 0; row < Rows; row++)
            {
                bool isFull = true;
                for (int col = 0; col < Columns; col++)
                {
                    if (board[row, col] == 0)
                    {
                        isFull = false;
                        break;
                    }
                }

                if (isFull)
                {
                    for (int moveRow = row; moveRow > 0; moveRow--)
                    {
                        for (int col = 0; col < Columns; col++)
                        {
                            board[moveRow, col] = board[moveRow - 1, col];
                        }
                    }

                    for (int col = 0; col < Columns; col++)
                    {
                        board[0, col] = 0;
                    }
                }
            }
        }
    }
}
