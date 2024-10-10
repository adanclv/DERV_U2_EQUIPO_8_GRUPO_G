using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI txtScore;
    // Start is called before the first frame update
    void Start()
    {    }

    // Update is called once per frame
    void Update()
    {
        int escena = SceneManager.GetActiveScene().buildIndex;
        if (escena == 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                cambioEscena(1);
            }
        } else if (escena == 2)
        {
            txtScore.text = PlayerPrefs.GetInt("Score", 0).ToString();
        }
    }

    public void cambioEscena(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void cambioEscena(int index, int score)
    {
        PlayerPrefs.SetInt("Score", score); // almacena info
        cambioEscena(index);
    }
}