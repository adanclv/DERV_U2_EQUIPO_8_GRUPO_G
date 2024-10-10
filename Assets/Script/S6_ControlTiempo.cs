using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class S6_ControlTiempo : MonoBehaviour
{
    float count;
    float countS;
    [SerializeField] TextMeshProUGUI txtTiempo;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        countS = 0;
    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;
        if (count > 1.0)
        {
            txtTiempo.text = countS++.ToString();
            count = 0;
        }
    }
}
