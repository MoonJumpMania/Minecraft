using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class ChunkBehavior : MonoBehaviour
{
    
    [SerializeField] private int chunkHeight = 16; 
    [SerializeField] private int chunkWidth = 16; 
        
    private Mesh _mesh;
    private List<Vector3> _vertices;
    private List<int> _triangles;
    private List<Vector2> _uvs;
    

    // Start is called before the first frame update
    private void Start()
    {
        _vertices = new List<Vector3>();
        _triangles = new List<int>();
        _uvs = new List<Vector2>();
        _mesh = new Mesh(); // This will be the mesh of the cubes
        
        GenerateChunk();
        GenerateMesh();
    }

    private void GenerateChunk()
    {
        for (var i = chunkHeight; i > 0; i--)
        {
            for (var j = 0; j < chunkWidth; j++)
            {
                for (var k = 0; k < chunkWidth; k++)
                {
                    GenerateCube(new Vector3(j, i, k));
                }
            }
        }
    }

    private void GenerateCube(Vector3 pos)
    {
        var currentVertex = 0;
        for (var i = 0; i < CubeData.NumFaces; i++)
        {
            var j = 0;
            foreach (var currentTriangle in CubeData.Triangles[i])
            {
                _vertices.Add(CubeData.Vertices[currentTriangle] + pos);
                _triangles.Add(currentVertex++);
                _uvs.Add(CubeData.CubeUV[j++]);
            }
        }
    }

    private void GenerateMesh() // Renders the object
    {
        GetComponent<MeshFilter>().mesh = _mesh;
        _mesh.vertices = _vertices.ToArray();
        _mesh.triangles = _triangles.ToArray();
        _mesh.uv = _uvs.ToArray();
        _mesh.RecalculateNormals();
    }
}
