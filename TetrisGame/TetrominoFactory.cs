using System;
using System.Collections.Generic;

namespace TetrisGame
{
    public static class TetrominoFactory
    {
        private static readonly List<int[,]> tetrominoShapes = new List<int[,]>
        {
            // I-Tetromino (línea)
            new int[,]
            {
                { 1, 1, 1, 1 }
            },

            // O-Tetromino (cuadrado)
            new int[,]
            {
                { 1, 1 },
                { 1, 1 }
            },

            // T-Tetromino
            new int[,]
            {
                { 0, 1, 0 },
                { 1, 1, 1 }
            },

            // S-Tetromino
            new int[,]
            {
                { 0, 1, 1 },
                { 1, 1, 0 }
            },

            // Z-Tetromino
            new int[,]
            {
                { 1, 1, 0 },
                { 0, 1, 1 }
            },

            // J-Tetromino
            new int[,]
            {
                { 1, 0, 0 },
                { 1, 1, 1 }
            },

            // L-Tetromino
            new int[,]
            {
                { 0, 0, 1 },
                { 1, 1, 1 }
            }
        };

        private static readonly Random random = new Random();

        public static Tetromino CreateRandomTetromino()
        {
            int shapeIndex = random.Next(tetrominoShapes.Count);
            int[,] shape = tetrominoShapes[shapeIndex];
            return new Tetromino(shape);
        }
    }
}
