public class Solution {
    public bool IsValid(string s) {
        Stack<char> state = new(s.Length/2);
        foreach (var ch in s)
        {
            switch (ch)
            {
                case '[':
                    state.Push(']');
                    break;
                case '{':
                    state.Push('}');
                    break;
                case '(':
                    state.Push(')');
                    break;
                default:
                    if (state.Count == 0 || ch != state.Pop()) return false;                    
                    break;
            }
        }

        return state.Count == 0;
    }
}
