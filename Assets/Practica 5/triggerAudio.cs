using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class triggerAudio : MonoBehaviour
{
    [SerializeField] AudioSource emisor; //quien emite
    [SerializeField] AudioClip archivo_sonido; //el archivo de sonido que se reproduce

    void Start()
    {
        emisor.clip = archivo_sonido; //asigna el clip de sonido para que sepa que sonido reproducir
        emisor.loop = true;
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            emisor.Play();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            emisor.Stop();
        }
    }
}
