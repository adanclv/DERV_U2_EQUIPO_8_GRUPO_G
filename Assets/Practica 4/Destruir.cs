using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Destruir : MonoBehaviour
{
    int vidas;
    public int escondidos;
    [SerializeField] TextMeshProUGUI vida;
    [SerializeField] TextMeshProUGUI escondido;
    [SerializeField] CambiarEscena ce;
    // Start is called before the first frame update
    void Start()
    {
        vidas = 3;
        escondidos = 2;

        vida.text = vidas + "";
        escondido.text = escondidos + "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("sol"))
        {
            Destroy(collision.gameObject);
            escondido.text = --escondidos + "";
            if (escondidos == 0)
            {
                ce.cambioEscena("Ganaste \n Haz encontrado a todos");
            }
        } else if(!collision.gameObject.CompareTag("floor"))
        {
            vida.text = --vidas + "";
            if (vidas == 0)
            {
                ce.cambioEscena("Perdiste");
            }
        }
    }
}
