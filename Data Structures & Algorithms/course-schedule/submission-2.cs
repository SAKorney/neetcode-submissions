public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        int[] visited = new int[numCourses];
        List<int>[] dependencies = new List<int>[numCourses];        
        for (int i = 0; i < prerequisites.Length; i ++) {
            int id = prerequisites[i][0];
            if (dependencies[id] is null) {
                dependencies[id] = new List<int>();
            }            
            dependencies[id].Add(prerequisites[i][1]);
        }
        for (int i = 0; i < prerequisites.Length; i++)
        {
            int id = prerequisites[i][0];
            if (visited[id] == 2) continue;
            if (!DFS(id, dependencies, visited))
                return false;
        }
        return true;   
    }

    private bool DFS(int curr, List<int>[] dependencies, int[] visited) {
        if (visited[curr] == 1) {
            return false;
        }
        visited[curr] = 1;
        if (dependencies[curr] is not null)
        {
            foreach(var d in dependencies[curr]) {
                if (visited[d] == 2) continue;
                if (!DFS(d, dependencies, visited))
                    return false;
            }
        }
        visited[curr] = 2;             
        return true;
    }
}
