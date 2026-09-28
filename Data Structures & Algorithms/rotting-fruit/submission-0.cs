public class Solution {
    public int OrangesRotting(int[][] grid) {
        const int Fresh = 1;
        const int Rotten = 2;
        Queue<(int row, int col)> rotten = new();
        int fresh = 0, time = 0;
        for (int row = 0; row < grid.Length; row++) {
            for (int col = 0; col < grid[0].Length; col++) {
                if (grid[row][col] == Fresh) fresh++;
                if (grid[row][col] == Rotten) rotten.Enqueue((row, col));
            }
        }

        (int row, int col)[] dir = { (0, -1), (0, 1), (-1, 0), (1, 0) };
        while (fresh > 0 && rotten.Count > 0) {
            int len = rotten.Count;
            for (int i = 0; i < len; i++) {
                var curr = rotten.Dequeue();
                foreach (var d in dir) {
                    int row = curr.row + d.row;
                    int col = curr.col + d.col;
                    if (row >= 0 && row < grid.Length &&
                        col >= 0 && col < grid[0].Length &&
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
