using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToEnd : MonoBehaviour
{
    // Три объекта, которые нужно уничтожить перед включением целевого объекта
    public GameObject object1;
    public GameObject object2;
    public GameObject object3;

    // Целевой объект, который будет включен после уничтожения всех объектов
    public GameObject targetObject;

    private int destroyedCount = 0;

    void Start()
    {
        object1.SetActive(true); // Убедитесь, что объекты активированы изначально
        object2.SetActive(true);
        object3.SetActive(true);

        targetObject.SetActive(false); // Изначально целевой объект выключен
    }

    void Update()
    {
        if (destroyedCount == 3)
        {
            targetObject.SetActive(true);
        }
    }

    public void OnObjectDestroyed(GameObject destroyedObject)
    {
        if (destroyedObject == object1 || destroyedObject == object2 || destroyedObject == object3)
        {
            destroyedCount++;
        }
    }
}

