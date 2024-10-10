using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class S8_TiempoJuego : MonoBehaviour
{
    [SerializeField] SceneChange sc;
    [SerializeField] Destroy d;
    [SerializeField] TextMeshProUGUI txtTiempo;
    int count;
    
    void Start()
    {
        count = 10;
        txtTiempo.text = count.ToString();
        StartCoroutine("corrutinaTiempo");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator corrutinaTiempo()
    {
        while (count >= 0)
        {
            txtTiempo.text = count--.ToString();
            yield return new WaitForSeconds(0.25f); // se ejecuta cada cuarto de segundo
        }
        Debug.Log("El juego termino");
        int score = d.contador;
        sc.cambioEscena(2, score);
    }
}