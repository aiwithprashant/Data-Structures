namespace Graphs
{
    /// <summary>
    ///   The Graph class for creating an un-dected graph and performing its operations
    /// </summary>
    public static class Graph
    {
        /// <summary>
        /// Creates the graph.
        /// </summary>
        /// <param name="v">Number of vertices.</param>
        /// <returns></returns>
        public static List<List<int>> CreateGraph(int v)
        {
            List<List<int>> adj = new List<List<int>>(v);
            for(int i=0;i<v;i++)
                adj.Add(new List<int>());
            return adj;
        }
        /// <summary>
        /// Adds the edge.
        /// </summary>
        /// <param name="adj">The adjacency list representation of a Graph.</param>
        /// <param name="u">From vertex.</param>
        /// <param name="v">To vertex.</param>
        public static void AddEdge(List<List<int>> adj, int u, int v)
        {
            adj[u].Add(v);
            adj[v].Add(u);
        }
        /// <summary>
        /// Prints the graph.
        /// </summary>
        /// <param name="adj">The adjacency list representation of a Graph.</param>
        public static void PrintGraph(List<List<int>> adj)
        {
            for (int i = 0; i < adj.Count; i++)
            {
                for (int j = 0; j < adj[i].Count; j++)
                    Console.Write(adj[i][j]+" ");
                Console.WriteLine();
            }
        }
        /// <summary>
        /// BFSs the specified adj.
        /// </summary>
        /// <param name="adj">The adjacency list representation of a Graph.</param>
        /// <param name="v">Number of vertices.</param>
        /// <param name="s">Source vertex.</param>
        public static void BFS(List<List<int>> adj, int v, int s)
        {
            bool[] visited = new bool[v];
            Queue<int> q = new Queue<int>();
            visited[s] = true;
            q.Enqueue(s);
            while (q.Count > 0)
            {
                int u = q.Dequeue();
                Console.Write(u + " ");
                foreach (int v2 in adj[u])
                {
                    if (!visited[v2])
                    {
                        visited[v2] = true;
                        q.Enqueue((int)v2);
                    }
                }
            }
        }
    }
}