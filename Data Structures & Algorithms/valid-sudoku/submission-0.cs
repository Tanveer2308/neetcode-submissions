public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<string> seen = new HashSet<string>();
       

        for(int r = 0; r<9; r++)
        {
            for(int c = 0; c<9; c++)
            {
                if(board[r][c] == '.')
                    continue;
                int box = (r/3)*3 + (c/3);
                if(!seen.Add($"{board[r][c]} in row {r}") ||
                    !seen.Add($"{board[r][c]} in col {c}") ||
                    !seen.Add($"{board[r][c]} in square {box}"))
                
                     return false;
                
                
            }
        }
        return true;

    }
}
