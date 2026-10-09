public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freq = new Dictionary<int, int>();
        foreach (var n in nums) {
            freq.TryGetValue(n, out int f);            
            freq[n] = f + 1;
        }

        var bucket = new List<int>[nums.Length+1];
        foreach (var (v, f) in freq) {
            if (bucket[f] is null) { bucket[f] = new List<int>(); }
            bucket[f].Add(v);
        }

        var ans = new int[k];
        int j = 0;
        for (int i  = bucket.Length - 1; i > 0 && j < k; i--) {
            if (bucket[i] is null) { continue; }
            foreach (var item in bucket[i]) {
                ans[j++] = item;
                if (j == k) { return ans; }
            }
        }
        return ans;
    }
}
