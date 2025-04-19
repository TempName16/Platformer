using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EToEnter : MonoBehaviour
{
    public Transform teleportPoint;
    public GameObject text;
    void Start()
    {
        text.SetActive(false);
    }
     
    void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            { 
                text.SetActive(true);               
            }
        }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey("e")) 
        { 
            other.transform.position = teleportPoint.position;
            text.SetActive(false);
        }
    }
    void OnTriggerExit(Collider other)
        {
            text.SetActive(false);
        }
}
