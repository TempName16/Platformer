using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int health = 10;
    public int maxHealth = 10;

    public void TakeDamage(int dmg)
    {
        health -= dmg;
        print("Çהמנמגüו:" + health);
        if(health <= 0)
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
