using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinterTeleport : MonoBehaviour
{
    public int indexScene = 0;
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(indexScene);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
