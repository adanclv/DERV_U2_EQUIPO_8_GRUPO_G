using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Temporizador : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txtTiempo;
    [SerializeField] CambiarEscena ce;
    GameObject[] obj;
    int tiempo;
    bool start = false;
    void Start()
    {
        tiempo = 10;
        txtTiempo.text = tiempo.ToString();
        
        StartCoroutine("timer");
    }

    // Update is called once per frame
    void Update()
    {
        if (tiempo == 6 & !start)
        {
            start = true;
            obj = GameObject.FindGameObjectsWithTag("sol");
            StartCoroutine(hint(obj));
        }
    }

    IEnumerator timer()
    {
        while (tiempo >= 0)
        {
            txtTiempo.text = tiempo--.ToString();
            
            yield return new WaitForSeconds(1f);
        }

        ce.cambioEscena("Se ha terminado el tiempo de busqueda");
    }

    IEnumerator hint(GameObject[] objs)
    {
        
        for (int i = 0; i < 5; i++)
        {
            foreach (GameObject obj in objs)
            {
                obj.transform.Rotate(0, 3, 0);
            }
            yield return new WaitForSeconds(0.2f);

            foreach (GameObject obj in objs)
            {
                obj.transform.Rotate(0, 0, 0);
                obj.transform.Rotate(0, -3, 0);
            }
            
            yield return new WaitForSeconds(0.2f);
            foreach (GameObject obj in objs)
            {
                obj.transform.Rotate(0, 0, 0);
            }
        }

        // go.transform.position = posicion;
        // go.transform.Rotate(0, 0, 0);
    }
}
