using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HG_escena1 : MonoBehaviour
{
    MeshFilter oldMesh;
    Mesh auxMesh;

    public Mesh getOldMesh()
    {
        auxMesh = oldMesh.mesh;
        Debug.Log(oldMesh.mesh);
        return auxMesh;
    }

    public void setOldMesh(Mesh mesh)
    {
        //Debug.Log(mesh);
        oldMesh.mesh = mesh;
        
    }

    private void Awake()
    {
        oldMesh = GameObject.Find("ChangeMesh").GetComponent<MeshFilter>();
    }

    private void Start()
    {
        auxMesh = new Mesh();
    }
}
