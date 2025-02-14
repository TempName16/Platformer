using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public Animator door;
    public Animator door2;
    void Start()
    {
        door.enabled = false;
        door2.enabled = false;
    }
    void OnTriggerEnter(Collider other)
    {
        door.enabled = true;
        door2.enabled = true;
        Destroy(gameObject);
    }
}
