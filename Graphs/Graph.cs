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
    }
}