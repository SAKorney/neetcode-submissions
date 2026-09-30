public class Solution {
    public bool Exist(char[][] board, string word) {
        int m = board.Length;
        int n = board[0].Length;
        bool[,] visited = new bool[m, n];
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (board[i][j] != word[0]) { continue; }
                if (Search(i, j, 0, word, 1, visited, board)) {
                    return true;
                }
            }
        }
        return false;
    }

    private static bool Search(int r, int c, int cl, string w, int l, bool[,] v, char[][] b) {
        if (r < 0 || c < 0 || r >= b.Length || c >= b[0].Length || v[r, c] == true) {
            return false;
        }        

        if (b[r][c] != w[cl]) {
            return false;
        }

        if (l == w.Length) {
            return b[r][c] == w[cl];
        }

        v[r, c] = true;

        var ans =  Search(r+1, c, cl+1, w, l + 1, v, b)
            || Search(r-1, c, cl+1, w, l + 1, v, b) 
            || Search(r, c+1, cl+1, w, l + 1, v, b)
            || Search(r, c-1, cl+1, w, l + 1, v, b);
        
        v[r, c] = false;
        return ans;
    }
}
