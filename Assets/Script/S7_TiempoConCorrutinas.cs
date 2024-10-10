using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class S7_TiempoConCorrutinas : MonoBehaviour
{
    int count;
    [SerializeField] TextMeshProUGUI txtTiempo;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        StartCoroutine("corrutinaTiempo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator corrutinaTiempo()
    {
        while (true)
        {
            txtTiempo.text = count++.ToString();
            yield return new WaitForSeconds(0.25f); // se ejecuta cada cuerto de segundo
        }
    }
}
