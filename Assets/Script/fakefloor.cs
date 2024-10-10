using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fakefloor : MonoBehaviour
{
    //int count;
    // Start is called before the first frame update
    void Start()
    {
        //count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        GameObject obj = other.gameObject;
        if (obj.CompareTag("fake"))
        {
            Destroy(obj, 0.5f);
            //count++;
            //txtCount.text = contador.ToString();
        }
    }

}
