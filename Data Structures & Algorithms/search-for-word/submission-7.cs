public class Solution {
    public bool Exist(char[][] board, string word) {
        int m = board.Length;
        int n = board[0].Length;
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (board[i][j] != word[0]) { continue; }
                if (Search(i, j, 0, word, board)) {
                    return true;
                }
            }
        }
        return false;
    }

    private static bool Search(int r, int c, int cl, string w, char[][] b) {
        if (r < 0 || c < 0 || r >= b.Length || c >= b[0].Length || b[r][c] == '#') {
            return false;
        }
        
        if (b[r][c] != w[cl]) {
            return false;
        }  

        if (cl == w.Length - 1) {
            return true;
        }            

        var tmp = b[r][c];
        b[r][c] = '#';

        var ans =  Search(r+1, c, cl+1, w, b)
            || Search(r-1, c, cl+1, w, b) 
            || Search(r, c+1, cl+1, w, b)
            || Search(r, c-1, cl+1, w, b);
        
        b[r][c] = tmp;
        return ans;
    }
}
