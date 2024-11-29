using Sudoku.Shared;

namespace Sudoku.HumanSolve;

public class EmptySolver : ISudokuSolver
    {
        public SudokuGrid Solve(SudokuGrid s)
        {
            return s.CloneSudoku();
        }

    }