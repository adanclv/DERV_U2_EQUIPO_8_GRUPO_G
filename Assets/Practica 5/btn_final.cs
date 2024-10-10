using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class btn_final : MonoBehaviour
{
    Button btn;
    private void Start()
    {
        btn = GameObject.Find("btn").GetComponent<Button>();
        btn.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        SceneManager.LoadScene(1);
    }
}
