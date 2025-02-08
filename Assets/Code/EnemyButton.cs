using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyButton : MonoBehaviour
{
    public Animator button;
    public Animator robot;
    public Animator door;
    public Enemy enemy;
    public GameObject light;
    void Start()
    {
        button.enabled = false;
        door.enabled = false;
        enemy.enabled = false;
        robot.enabled = false;
        light.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        button.enabled = true;
        door.enabled = true;
        enemy.enabled = true;
        robot.enabled = true;
        light.SetActive(true);
    }
}
