public class Solution {
    public int ClimbStairs(int n) {
        return Dfs(0, n, new Dictionary<int, int>());
    }


    private int Dfs(int i, int n, Dictionary<int, int> cache) {
        if (i == n) { return 1; }
        if (i > n)  { return 0; }
        if (!cache.ContainsKey(i)) { 
            cache[i] = Dfs(i+1, n, cache) + Dfs(i+2, n, cache);
        }
        return cache[i];
    }
}
