public class Solution {
    public bool Exist(char[][] board, string word) {
        int m = board.Length;
        int n = board[0].Length;
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (board[i][j] != word[0]) { continue; }
                HashSet<(int, int)> visited = new();
                if (Search(i, j, 0, word, 1, visited, board)) {
                    return true;
                }
            }
        }
        return false;
    }

    private static bool Search(int r, int c, int cl, string w, int l, HashSet<(int, int)> v, char[][] b) {
        if (r < 0 || c < 0 || r >= b.Length || c >= b[0].Length || v.Contains((r, c))) {
            return false;
        }        

        if (b[r][c] != w[cl]) {
            return false;
        }

        if (l == w.Length) {
            return b[r][c] == w[cl];
        }

        v.Add((r, c));

        var ans =  Search(r+1, c, cl+1, w, l + 1, v, b)
            || Search(r-1, c, cl+1, w, l + 1, v, b) 
            || Search(r, c+1, cl+1, w, l + 1, v, b)
            || Search(r, c-1, cl+1, w, l + 1, v, b);
        
        v.Remove((r,c));
        return ans;
    }
}
