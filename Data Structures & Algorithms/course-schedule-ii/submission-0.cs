public class Solution {


    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        byte[] state = new byte[numCourses];
        const byte Visited = 2;
        const byte InProc = 1;
        List<int> coursesOrder = new(numCourses);
        Dictionary<int, List<int>> dep = new();
        for (int i = 0; i < prerequisites.Length; i++) {
            int id = prerequisites[i][0];
            if (!dep.ContainsKey(id)) { dep[id] = new List<int>(); }
            dep[id].Add(prerequisites[i][1]);
        }

        for (int i = 0; i < numCourses; i++) {
            if (DFS(i)) { return Array.Empty<int>(); }
        }

        bool DFS(int curr) {            
            if (state[curr] == InProc) { return true; }
            if (state[curr] == Visited) { return false; }            
            
            state[curr] = InProc;

            if (dep.ContainsKey(curr)) {
                foreach (var d in dep[curr]) {
                    if (DFS(d)) {
                        return true;
                    }                
                }
            }

            state[curr] = Visited;
            coursesOrder.Add(curr);
            return false;
        }

        return coursesOrder.ToArray();    
    }
}
