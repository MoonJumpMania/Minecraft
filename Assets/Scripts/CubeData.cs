using System.Collections.Generic;
using UnityEngine;

public struct CubeData
{
    public const int NumFaces = 6;

    private static readonly Vector3[] Vertices = 
    {
        // Left
        new (0f, 0f, 0f), // A:0
        new (0f, 0f, 1f), // B:1
        new (0f, 1f, 0f), // C:2
        new (0f, 1f, 1f), // D:3
        
        // Right
        new (1f, 0f, 0f), // E:4
        new (1f, 0f, 1f), // F:5
        new (1f, 1f, 0f), // G:6
        new (1f, 1f, 1f), // H:7
    };

    private static readonly int[][] Triangles = 
    {
        new[] {0, 1, 2, 3}, // Left
        new[] {5, 4, 7, 6}, // Right
        new[] {0, 2, 4, 6}, // Front
        new[] {3, 1, 7, 5}, // Back
        new[] {1, 0, 5, 4}, // Bottom
        new[] {2, 3, 6, 7}, // Top
    };

    public static IEnumerable<Vector3> GetVertices(int faceIndex)
    {
        var vertices = new Vector3[4];

        for (var i = 0; i < vertices.Length; i++)
        {
            var vertexIndex = Triangles[faceIndex][i];
            vertices[i] = Vertices[vertexIndex];
        }

        return vertices;
    }
}
