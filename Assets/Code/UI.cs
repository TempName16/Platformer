using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Player player;
    public Slider slider;
    void Start()
    {
        
    }

    void Update()
    {
        slider.maxValue = player.maxHealth;
        slider.value = player.health;
    }
}
