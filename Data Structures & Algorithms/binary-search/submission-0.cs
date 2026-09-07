public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0;
        int r = nums.Length - 1;
        int mid = nums.Length / 2;
        while (l <= r)
        {
            int el = nums[mid];
            if (el == target)
            {
                return mid;
            }
            if (el < target)
            {
                l = mid + 1;
            }
            else
            {
                r = mid - 1;
            }
            mid =  (l + r) >>> 1;
        }
        return -1;
    }
}
