  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeHole : MonoBehaviour
{



    /*
    void createHole() {
        Destroy(this.gameObject.GetComponent<MeshCollider>());
        Mesh mesh = transform.GetComponent<MeshFilter>().mesh;
        int[] oldTriangles = mesh.triangles;
        int[] newTriangles = new int[mesh.triangles.Length-3];

        int i, j = 0;
        while (j < mesh.triangles.Length)



    }
    */
    // Start is called before the first frame update

    public Material material;

    void Start()
    {

    Vector3[] vertices = new Vector3[4];
    Vector2[] uv = new Vector2[4]; // num uvs are same as verts b/c each uv associated with vert
    int[] triangles = new int[6]; // a square is 2 triangles, so 2 * 3 edges = 6

    // vertices
    vertices[0] = new Vector3(0, 1);
    vertices[1] = new Vector3(1, 1);
    vertices[2] = new Vector3(0, 0);
    vertices[3] = new Vector3(1, 0);

    // uvs

    uv[0] = new Vector2(0, 1);
    uv[1] = new Vector2(1, 1);
    uv[2] = new Vector2(0, 0);
    uv[3] = new Vector2(1, 0);

    // triangles (maps indices to vertex index of the triangle (multiples of 3)) in clockwise order

    triangles[0] = 0;
    triangles[1] = 1;
    triangles[2] = 2;

    triangles[3] = 2;
    triangles[4] = 1;
    triangles[5] = 3;





    Mesh mesh = new Mesh();

    mesh.vertices = vertices;
    mesh.uv = uv;
    mesh.triangles = triangles;

    GameObject wall = new GameObject("Mesh", typeof(MeshFilter), typeof(MeshRenderer));
    wall.transform.localScale = new Vector3(30, 30, 1);

    wall.GetComponent<MeshFilter>().mesh = mesh;
    wall.GetComponent<MeshRenderer>().material = material;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
