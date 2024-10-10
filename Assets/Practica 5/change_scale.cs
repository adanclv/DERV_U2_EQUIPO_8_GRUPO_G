using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_scale : MonoBehaviour
{
    int max;
    
    void Start()
    {
        max = 5;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (max > 0)
            {
                StartCoroutine(escala(other.gameObject));
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        StopAllCoroutines();
    }

    IEnumerator escala(GameObject obj)
    {
        while (max > 0)
        {
            obj.gameObject.transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);
            max--;
            yield return new WaitForSeconds(1);
        }
    }
}
