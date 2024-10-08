﻿using System;
using System.Collections.Generic;

namespace TetrisGame
{
    public class Tetromino
    {
        public int[,] Shape { get; private set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Tetromino(int[,] shape)
        {
            Shape = shape;
            X = 0;
            Y = 0;
        }

        public void Rotate()
        {
            int size = Shape.GetLength(0);
            int[,] newShape = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    newShape[col, size - row - 1] = Shape[row, col];
                }
            }

            Shape = newShape;
        }

        public IEnumerable<Tuple<int, int>> GetFilledCells()
        {
            for (int row = 0; row < Shape.GetLength(0); row++)
            {
                for (int col = 0; col < Shape.GetLength(1); col++)
                {
                    if (Shape[row, col] != 0)
                    {
                        yield return Tuple.Create(col, row);
                    }
                }
            }
        }
    }
}
