using System.Collections.Generic;
using UnityEngine;

public struct CubeData
{
    public const int NumFaces = 6;

    public static readonly Vector3[] Vertices =  // Points in a cube
    {
        new (0f, 0f, 0f), // A:0
        new (0f, 0f, 1f), // B:1
        new (0f, 1f, 0f), // C:2
        new (0f, 1f, 1f), // D:3
        new (1f, 0f, 0f), // E:4
        new (1f, 0f, 1f), // F:5
        new (1f, 1f, 0f), // G:6
        new (1f, 1f, 1f), // H:7
    };

    public static readonly int[][] Triangles = 
    {
        new[] {0, 1, 2, 2, 1, 3},
        new[] {0, 4, 1, 1, 4, 5},
        new[] {0, 2, 4, 4, 2, 6},
        new[] {1, 5, 3, 3, 5, 7},
        new[] {4, 6, 5, 5, 6, 7},
        new[] {2, 3, 6, 6, 3, 7},
    };

    public static readonly Vector2[] CubeUV =
    {
        new Vector2(0, 0),
        new Vector2(0, 1),
        new Vector2(1, 0),
        new Vector2(1, 0),
        new Vector2(0, 1),
        new Vector2(1, 1),
    };
}
