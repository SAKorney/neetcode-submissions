public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        int[] indeg = new int[numCourses];
        Queue<int> q = new();
        List<int>[] dep = new List<int>[numCourses];
        
        foreach (var pair in prerequisites) {
            var course = pair[0];
            var prereq = pair[1];
            indeg[prereq]++;
            if (dep[course] is null) {
                dep[course] = new();
            }
            dep[course].Add(prereq);
        }

        for (int i = 0; i < numCourses; i++) {
            if (indeg[i] != 0) {
                continue;
            }
            q.Enqueue(i);
        }

        int total = 0;
        while (q.Count > 0) {
            var curr = q.Dequeue();
            total++;
            if (dep[curr] is null) { continue; }
            foreach (var prereq in dep[curr]) {
                indeg[prereq]--;
                if (indeg[prereq] == 0) {
                    q.Enqueue(prereq);
                }
            }
        }

        return total == numCourses;
    }
}
