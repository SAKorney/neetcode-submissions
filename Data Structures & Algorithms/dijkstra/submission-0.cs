public class Solution {
    public Dictionary<int, int> ShortestPath(int n, List<List<int>> edges, int src) {
        var adj = new List<(int, int)>[n];
        for (int i = 0; i < n ; i++) {
            adj[i] = new List<(int, int)>();
        }
        foreach (var e in edges) {
            adj[e[0]].Add((e[1], e[2]));
        }

        Dictionary<int, int> shortest = new(n);

        PriorityQueue<(int, int), int> nodes = new();
        nodes.Enqueue((0, src), 0);
        while (nodes.Count > 0) {
            var curr = nodes.Dequeue();
            if (shortest.ContainsKey(curr.Item2)) { continue; }
            
            shortest[curr.Item2] = curr.Item1;
            foreach (var (e, w) in adj[curr.Item2]) {
                if (shortest.ContainsKey(e)) { continue; }
                var newW = w + curr.Item1;
                nodes.Enqueue((newW, e), newW);
            }
        }

        for (int i = 0; i < n; i++) {
            if (shortest.ContainsKey(i)) { continue; }
            shortest[i] = -1;
        }
        return shortest;
    }  
}
