using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speed = 1f;
    public Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "PlatformStop")
        {
            direction *= -1;
        }
    }
}
