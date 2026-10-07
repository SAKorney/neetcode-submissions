public class Solution {
    public int MaxSubArray(int[] nums) {
        int best = nums[0];
        int curr = nums[0];
        for (int i = 1; i < nums.Length; i++) {
            curr = Math.Max(nums[i], nums[i] + curr);
            best = Math.Max(curr, best);
        }
        return best;     
    }
}
