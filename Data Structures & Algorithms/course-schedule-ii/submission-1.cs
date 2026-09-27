public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        List<int> order = new(numCourses);
        int[] indeg = new int[numCourses];
        Dictionary<int, List<int>> dep = new();
        
        foreach (var pre in prerequisites) {
            if (!dep.ContainsKey(pre[1])) { dep[pre[1]] = new List<int>(); }
            dep[pre[1]].Add(pre[0]);
            indeg[pre[0]]++;
        }
        
        Queue<int> q = new();
        for (int i = 0; i < numCourses; i++) {
            if (indeg[i] == 0) {
                q.Enqueue(i);
            }
        }

        while (q.Count > 0) {
            int curr = q.Dequeue();
            order.Add(curr);
            if (!dep.ContainsKey(curr)) { continue; }
            foreach(var pre in dep[curr]) {
                indeg[pre]--;
                if (indeg[pre] == 0) {
                    q.Enqueue(pre);
                }
            }
        }

        if (order.Count != numCourses) {
            return Array.Empty<int>();
        }

        return order.ToArray();
    }
}
