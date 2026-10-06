public class Solution {
    public int ClimbStairs(int n) {
        int prev = 1, curr = 1;
        for (int i = 0; i < n - 1; i++) {
            int tmp = curr;
            curr = prev + curr;
            prev = tmp;
        } 

        return curr;        
    }
}
