using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggersDetect : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Enter - " + other.gameObject.name);
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger Stay - " + other.gameObject.name);
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger Exit - " + other.gameObject.name);
    }
}