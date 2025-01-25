using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTriggger : MonoBehaviour
{
    public float speedFactor = 2.5f;


    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<PlayerMove>().runSpeed *= speedFactor;
    }

    void OnTriggerExit(Collider other)
    {
        other.GetComponent<PlayerMove>().runSpeed /= speedFactor;
    }
}
