public class DynamicArray {
    private int[] _internalArray;
    private int _capacity;
    private int _length;
    
    public DynamicArray(int capacity) {
        _internalArray = new int[capacity];
        _capacity = capacity;
        _length = 0;
    }

    public int Get(int i) => _internalArray[i];

    public void Set(int i, int n) {
        _internalArray[i] = n;
    }

    public void PushBack(int n) {
        if (_length == _capacity) {
            Resize();
        }
        _internalArray[_length++] = n;
    }

    public int PopBack()  => _internalArray[--_length];

    private void Resize() {
        _capacity *= 2;
        int[] tmp = new int[_capacity];
        Array.Copy(_internalArray, tmp, _length);
        _internalArray = tmp;
    }

    public int GetSize() => _length;

    public int GetCapacity() => _capacity;
}
