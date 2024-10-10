using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c_mesh : MonoBehaviour
{
    MeshFilter oldMesh;
    Mesh auxMesh;
    Vector3 oldBox;
    Vector3 auxBox;


    private void Start()
    {
        oldMesh = GameObject.Find("ChangeMesh").GetComponent<MeshFilter>();
        oldBox = new Vector3(1.0f, 1.0f, 1.0f);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            auxMesh = other.gameObject.GetComponent<MeshFilter>().mesh;
            other.gameObject.GetComponent<MeshFilter>().mesh = oldMesh.mesh;
            oldMesh.mesh = auxMesh;

            auxBox = other.gameObject.GetComponent<BoxCollider>().size;
            other.gameObject.GetComponent<BoxCollider>().size = oldBox;
            oldBox = auxBox;
        }
    }
}

