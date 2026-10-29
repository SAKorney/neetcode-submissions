public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int m = matrix.Length;
        int n = matrix[0].Length;
        int l = 0;
        int r = matrix.Length - 1;
        
        while (l <= r) {
            int mid = l + (r - l) / 2;
            int el = matrix[mid][n-1];
            if (el == target)
            {
                return true;
            }
            if (el < target)
            {
                l = mid + 1;
            }
            else
            {
                r = mid - 1;
            }
        }
        if (l >= m) return false;
        int id = Array.FindIndex(matrix[l], item => item == target);
        return id != -1;
    }
}
