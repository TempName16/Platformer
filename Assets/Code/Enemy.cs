using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 1.3f;
    public Transform target;
    public int damage = 2;

    void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        player.TakeDamage(damage);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        transform.LookAt(target.position);
    }
}
