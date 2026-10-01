public class KthLargest {
    private PriorityQueue<int, int> _heap;
    private int _k;

    public KthLargest(int k, int[] nums) {
        _heap = new(nums.Length);
        _k = k;
        for (int i = 0; i < nums.Length; i++) {
            var val = nums[i];
            Insert(val);
        }
    }
    
    public int Add(int val) {
        Insert(val);
        return _heap.Peek();
    }

    private void Insert(int value) {
        _heap.Enqueue(value, value);
        if (_heap.Count > _k) { _heap.Dequeue(); }
    }
}
