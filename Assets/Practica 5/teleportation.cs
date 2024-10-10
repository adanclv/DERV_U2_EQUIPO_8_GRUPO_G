using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportation : MonoBehaviour
{
    Transform tp1, tp2, replace;

    private void Awake()
    {
        tp1 = GameObject.Find("tp1").transform;
        tp2 = GameObject.Find("tp2").transform;
        replace = GameObject.Find("Spawn").transform;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (gameObject.name == "Portal1")
            {
                collision.gameObject.transform.position = tp2.position;
            }
            else if (gameObject.name == "Portal2")
            {
                collision.gameObject.transform.position = tp1.position;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (gameObject.name == "ReplacePosition")
            {
                other.gameObject.transform.position = replace.position;
            }
        } 
    }
}
