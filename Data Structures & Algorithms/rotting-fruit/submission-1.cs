public class Solution {
    public int OrangesRotting(int[][] grid) {
        const int Fresh = 1;
        const int Rotten = 2;
        int m = grid.Length;
        int n = grid[0].Length;
        Queue<(int row, int col)> rotten = new();
        int fresh = 0, time = 0;

        for (int row = 0; row < m; row++) {
            for (int col = 0; col < n; col++) {
                if (grid[row][col] == Fresh) fresh++;
                if (grid[row][col] == Rotten) rotten.Enqueue((row, col));
            }
        }

        (int, int)[] moveSet = { (0, -1), (0, 1), (-1, 0), (1, 0) };
        while (fresh > 0 && rotten.Count > 0) {
            int len = rotten.Count;
            for (int i = 0; i < len; i++) {
                var curr = rotten.Dequeue();
                foreach (var (r, c)  in moveSet) {
                    int row = curr.row + r;
                    int col = curr.col + c;
                    if (row >= 0 && row < m &&
                        col >= 0 && col < n &&
                        grid[row][col] == Fresh) {
                            grid[row][col] = Rotten;
                            rotten.Enqueue((row, col));
                            fresh--;
                        }
                }
            }
            time++;
        }
        return fresh == 0 ? time : -1;
    }
}
