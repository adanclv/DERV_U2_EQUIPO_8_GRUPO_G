using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s1_movimiento : MonoBehaviour
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
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        } else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.forward * speed * -1 * Time.deltaTime);
        }
        
    }
}
