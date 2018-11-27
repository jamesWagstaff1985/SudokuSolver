using System;
using System.Linq;
using System.IO;

namespace SudokuSolver.Workers
{
    class SudokuFileReader
    {
        public int[,] ReadFile(string filename)
        {
            int[,] sudokuBoard = new int[9, 9];
            try
            {
                var sudokuBoardLines = File.ReadAllLines(filename);

                int row = 0;
                foreach(var line in sudokuBoardLines)
                {
                    string[] elements = line.Split('|').Skip(1).Take(9).ToArray();

                    int col = 0; 

                    foreach(var element in elements)
                    {
                        sudokuBoard[row, col] = element.Equals(" ") ? 0 : Convert.ToInt16(element);
                        col++;
                    }
                    row++;
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Something went wrong while reading the file: {e.Message}");
            }
            return sudokuBoard;
        }
    }
}
