public class Solution {    
    public int MaxAreaOfIsland(int[][] grid) {
        int maxArea = 0;
        for (int i = 0; i < grid.Length; i++) {
            int currArea = 0;
            for (int j = 0; j < grid[0].Length; j++) {
                if (grid[i][j] == 0) continue;
                currArea = CalcArea(i, j, grid);
                maxArea = Math.Max(maxArea, currArea);
            }            
        }      
        return maxArea;  
    }

    private static int CalcArea(int x, int y, int[][] grid) {        
        if (x < 0 || x >= grid.Length ||
            y < 0 || y >= grid[0].Length ||
            grid[x][y] == 0) {
                return 0;
        }

        grid[x][y] = 0;
        return 1 + CalcArea(x, y-1, grid) 
             + CalcArea(x, y+1, grid)
             + CalcArea(x-1, y, grid)
             + CalcArea(x+1, y, grid);
    }    
}
