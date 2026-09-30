public class Solution {
    public int NumIslands(char[][] grid) {
        int m = grid.Length;
        int n = grid[0].Length;
        int total = 0;
        (int, int)[] dir = [(0, -1), (0, 1), (-1, 0), (1, 0)];
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (grid[i][j] == '0') continue;
                total++;
                Stack<(int, int)> s = new();
                s.Push((i, j));
                grid[i][j] = '0';
                while (s.Count > 0) {
                    var curr = s.Pop();                    
                    foreach(var (x, y) in dir) {
                        int nx = curr.Item1 + x;
                        int ny = curr.Item2 + y;
                        if (nx >= 0 && nx < m &&
                            ny >= 0 && ny < n &&
                            grid[nx][ny] == '1') {
                                s.Push((nx, ny));
                                grid[nx][ny] = '0';
                            }
                    }
                }
            }
        }
        return total;
    }    
}
