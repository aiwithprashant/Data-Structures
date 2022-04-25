// See https://aka.ms/new-console-template for more information
using Graphs;

Console.WriteLine("Hello, World!");
List<List<int>> graph = Graph.CreateGraph(5);
Graph.AddEdge(graph, 0, 1);
Graph.AddEdge(graph, 0, 2);
Graph.AddEdge(graph, 1, 2);
Graph.AddEdge(graph, 1, 3);
Graph.AddEdge(graph, 4, 1);
Graph.PrintGraph(graph);
