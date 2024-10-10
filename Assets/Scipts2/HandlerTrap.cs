using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlerTrap : MonoBehaviour
{
    float trigger_time;
    float enemigo_time;
    Transform spawn;
    [SerializeField] List<GameObject> enemigos;
    int enemigos_count;
    // Start is called before the first frame update

    void Awake()
    {
        spawn = GameObject.Find("Spawn").transform;
    }

    void Start()
    {
        enemigo_time = 2;
        enemigos_count = 0;
    }
    
    private void OnTriggerStay(Collider other)
    {
        trigger_time += Time.deltaTime;
        if (trigger_time > enemigo_time)
        {
            enemigos[enemigos_count].transform.position = spawn.position;
            enemigos[enemigos_count].GetComponent<Rigidbody>().AddForce(-1 * 10f * transform.up);
            enemigos_count++;
            enemigos_count %= enemigos_count;//enemigos.Count;
            trigger_time = 0;
        }
    }
}

// Hacer en version de corrutina esta cosa
