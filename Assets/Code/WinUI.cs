using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinUI : MonoBehaviour
{
    public GameObject text;
    public GameObject text2;
    public GameObject button;
    public void onWin() 
    {
        text.SetActive(true);
        text2.SetActive(true);
        button.SetActive(true);
    }
    public void OnClick()
    {
        int index = 0;
        SceneManager.LoadScene(index);
    }
    void Start()
    {

    }
    void Update()
    {
        
    }
}
