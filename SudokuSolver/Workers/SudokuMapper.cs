using SudokuSolver.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver.Workers
{
    class SudokuMapper
    {
        public SudokuMap Find(int givenRow, int givenCol)
        {
            SudokuMap sudokuMap = new SudokuMap
            {
                StartRow = givenRow - (givenRow % 3),
                StartCol = givenCol - (givenCol % 3)
            };

            return sudokuMap;
        }
    }
}
