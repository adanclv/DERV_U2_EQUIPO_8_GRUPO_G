using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public int contador;
    [SerializeField] TextMeshProUGUI txtCount;
    // Start is called before the first frame update
    void Start()
    {
        contador = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        GameObject obj = other.gameObject;
        if (obj.CompareTag("sol"))
        {
            Destroy(obj);
            contador++;
            txtCount.text = contador.ToString();
        }
    }
}
