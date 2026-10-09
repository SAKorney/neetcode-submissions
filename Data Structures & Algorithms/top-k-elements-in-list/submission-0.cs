public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freq = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int n = nums[i];
            if (freq.ContainsKey(n)) freq[n]++;
            else freq[n] = 1;
        }

        var pq = new PriorityQueue<int, int>();
        foreach (var info in freq) {
            pq.Enqueue(info.Key, info.Value);
            if (pq.Count > k) {
                pq.Dequeue();
            }
        }

        var ans = new int[k];
        for (int i = 0; i < k; i++) {
            ans[i] = pq.Dequeue();
        }

        return ans;
    }
}
