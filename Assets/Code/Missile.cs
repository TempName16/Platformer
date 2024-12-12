using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed = 1.5f;

    public void FireBallMove()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
    public void FireBallBoom()
    {
        destoy()
    }
}
