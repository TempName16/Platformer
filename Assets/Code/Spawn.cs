using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Spawn : MonoBehaviour
{
    public GameObject enemy;
    public float wait = 3f;
    public Transform spawnPoint;
    void Start()
    {
        StartCoroutine(CreateEnemies());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator CreateEnemies()
    {
        while (true)
        {
            yield return new WaitForSeconds(wait);
            Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
