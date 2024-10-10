using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisio : MonoBehaviour
{
    [SerializeField] GameObject imageToShow;
    [SerializeField] Light lightSource;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            imageToShow.SetActive(true);
            lightSource.enabled = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
        imageToShow?.SetActive(false);
        lightSource.enabled = false;
        }
    }
}
