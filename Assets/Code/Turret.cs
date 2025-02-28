using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public Transform target;
    public Transform shootPoint;
    public GameObject fireball;
    public float wait = 5f;
    void Start()
    {
        StartCoroutine(CreateFireballs());
    }
    void Update()
    {
        transform.LookAt(target.position);
    }
    private IEnumerator CreateFireballs()
    {
        while (true)
        {
            yield return new WaitForSeconds(wait);
            Instantiate(fireball, shootPoint.position, shootPoint.rotation);
        }
    }
}
