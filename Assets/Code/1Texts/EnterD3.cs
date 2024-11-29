using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterD3 : MonoBehaviour
{
    public string mess1 = "Text";
    public string mess2 = "Text";
    public string mess3 = "Text";

    void OnTriggerEnter(Collider other)
    {
        print(mess1);
        print(mess2);
        print(mess3);
       
    }

   
}
