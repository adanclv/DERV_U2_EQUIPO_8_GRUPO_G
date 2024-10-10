using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s2_movimientoLocal : MonoBehaviour
{
    [SerializeField] float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //transform.Translate(transform.forward * speed * Time.deltaTime);
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            //transform.Translate(transform.forward * speed * -1 * Time.deltaTime);
            transform.position += transform.forward * speed * -1 * Time.deltaTime;
        }
    }
}
