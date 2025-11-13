namespace Valid_Sudoku;


public class Solution {
    private int GetSubBoardIndex(int row, int col) {
        int subRow = row / 3;
        int subCol = col / 3;
        return subRow * 3 + subCol;
    }
    public bool IsValidSudoku(char[][] board) {
        HashSet<char>[] subBoards = new HashSet<char>[9];
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] cols = new HashSet<char>[9];
        for (int i = 0; i < 9; i++) {
            subBoards[i] = [];
            rows[i] = [];
            cols[i] = [];
        }

        for (int row = 0; row < 9; row++) {
            for (int col = 0; col < 9; col++) {
                char digit = board[row][col];
                if (digit != '.') {
                    if (!rows[row].Add(digit)) return false;
                    if (!cols[col].Add(digit)) return false;
                    int subBoardIndex = GetSubBoardIndex(row, col);
                    if (!subBoards[subBoardIndex].Add(digit)) return false;
                }
            }
        }

        return true;
    }
}
