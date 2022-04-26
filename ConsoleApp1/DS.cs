// See https://aka.ms/new-console-template for more information
using Graphs;

Console.WriteLine("Hello, World!");
List<List<int>> graph = Graph.CreateGraph(7);
//Graph.AddEdge(graph, 0, 1);
//Graph.AddEdge(graph, 0, 2);
//Graph.AddEdge(graph, 1, 2);
//Graph.AddEdge(graph, 1, 3);
//Graph.AddEdge(graph, 4, 1);
//Graph.PrintGraph(graph);

//Graph.BFS(graph, 5, 0);

Graph.AddEdge(graph, 0, 1);
Graph.AddEdge(graph, 0, 2);
Graph.AddEdge(graph, 1, 3);
Graph.AddEdge(graph, 2, 3);
Graph.AddEdge(graph, 4, 5);
Graph.AddEdge(graph, 4, 6);
Graph.AddEdge(graph, 6, 5);

Graph.BFSDisjoint(graph, 7);
Console.WriteLine();
Graph.DFSDisjoint(graph, 7);
