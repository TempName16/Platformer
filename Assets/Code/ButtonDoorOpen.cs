using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDoorOpen : MonoBehaviour
{
    public Animator button;
    public Animator door;

    void Start()
    {
        button.enabled = false;
        door.enabled = false;
    }
    void OnTriggerEnter(Collider other)
    {
        button.enabled = true;
        door.enabled = true;
    }

    void Update()
    {
        
    }
}
