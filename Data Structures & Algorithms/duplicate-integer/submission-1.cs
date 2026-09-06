public class Solution {
    public bool hasDuplicate(int[] nums) {
        if (nums.Length <= 0) return false;
        HashSet<int> v = new(nums.Length);
        for (int i = 0; i < nums.Length; i++)
        {
            if (!v.Add(nums[i])) return true;
        }
        return false;
    }
}