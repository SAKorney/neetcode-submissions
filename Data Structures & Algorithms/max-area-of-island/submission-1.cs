public class Solution {
    private static (int, int)[] s_dir = [ (0, -1), (0, 1), (-1, 0), (1, 0) ];

    public int MaxAreaOfIsland(int[][] grid) {
        int maxArea = 0;
        for (int i = 0; i < grid.Length; i++) {
            int currArea = 0;
            for (int j = 0; j < grid[0].Length; j++) {
                if (grid[i][j] == 0) continue;
                grid[i][j] = 0;
                currArea = CalcArea(i, j, grid);
                maxArea = Math.Max(maxArea, currArea);
            }            
        }      
        return maxArea;  
    }

    private static int CalcArea(int x, int y, int[][] grid) {        
        int area = 1;
        foreach(var(dx, dy) in s_dir) {
            int nx = x + dx;
            int ny = y + dy;
            if (nx >= 0 && nx < grid.Length &&
                ny >= 0 && ny < grid[0].Length &&
                grid[nx][ny] == 1)
                {
                    grid[nx][ny] = 0;
                    area += CalcArea(nx, ny, grid);
                }
        }

        return area;
    }
}
