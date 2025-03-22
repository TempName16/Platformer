using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalActivate : MonoBehaviour
{

    public GameObject objectToEnable; // Объект, который нужно включить
    public GameObject object1; // Первый объект для проверки
    public GameObject object2; // Второй объект для проверки
    public GameObject object3; // Третий объект для проверки

    void Update()
    {
        if (!object1.activeSelf && !object2.activeSelf && !object3.activeSelf)
        {
            objectToEnable.SetActive(true);
        }
    }
}
