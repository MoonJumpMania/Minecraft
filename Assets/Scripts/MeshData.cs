using UnityEngine;

public struct MeshData
{
    public static readonly Vector3[] Vertices = new Vector3[8]
    {
        new Vector3(0f, 0f, 0f), // A
        new Vector3(0f, 0f, 1f), // B
        new Vector3(0f, 1f, 0f), // C
        new Vector3(0f, 1f, 1f), // D
        new Vector3(1f, 0f, 0f), // E
        new Vector3(1f, 0f, 1f), // F
        new Vector3(1f, 1f, 0f), // G
        new Vector3(1f, 1f, 1f), // H
    };

    public static readonly int[,] MeshTriangles = new int[1, 6]
    {
        {1, 3, 5, 3, 5, 7}
    };
}
