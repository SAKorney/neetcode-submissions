public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> values = new(nums.Length);
        for (int i = 0; i < nums.Length; i++) {
            values[nums[i]] = i;
        }
        
        int[] ans = new int[2];
        for (int i = 0; i < nums.Length; i++) {
            int diff = target - nums[i];
            if (values.TryGetValue(diff, out int j) && j != i) {
                ans[0] = i;
                ans[1] = j;
                return ans;
            }
        }
        return ans;        
    }
}
