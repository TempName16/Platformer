using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillar : MonoBehaviour
{
    public int health = 10;
    public GameObject effect;
    public GameObject spawner;
    private void Start()
    {
        effect.SetActive(false);
    }
    public void TakeDamage(int dmg)
    {
        health = health - dmg;
        if (health <= 0)
        {
            spawner.SetActive(false);
            effect.SetActive(true);
            Destroy(effect, 3f);
            gameObject.SetActive(false);
        }
    }
}
