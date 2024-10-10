using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_change : MonoBehaviour
{
    int scene;
    
    void Update()
    {
        scene = SceneManager.GetActiveScene().buildIndex;
        if (scene == 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                changeScene(1);
            }
        }
    }

    void changeScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
