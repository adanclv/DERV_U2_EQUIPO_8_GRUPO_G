using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_color : MonoBehaviour
{
    Color newColor = Color.magenta;
    Color colorsito;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            colorsito = other.GetComponent<Renderer>().material.color;
            other.GetComponent<Renderer>().material.color = newColor;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<Renderer>().material.color = colorsito;
    }
}
