using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitD2 : MonoBehaviour
{
    public string mess1 = "Text";
    public string mess2 = "Text";

    void OnTriggerExit(Collider other)
    {
        print(mess1);
        print(mess2);
    }
}
