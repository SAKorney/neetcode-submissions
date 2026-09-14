public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> indices = new(nums.Length);
        for (int i = 0; i < nums.Length; i++) {
            int diff = target - nums[i];
            if (indices.TryGetValue(diff, out int j)) {
                return new[] { j, i } ;
            }
            indices[nums[i]] = i;
        }

        return new int[0];
    }
}
