using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI : MonoBehaviour
{
    public Player player;
    public Slider slider;
    public Player coinsNum;
    public TextMeshProUGUI coinsText;
    void Start()
    {
        
    }

    void Update()
    {
        slider.maxValue = player.maxHealth;
        slider.value = player.health;
        coinsText.text = coinsNum.coins.ToString();
    }
}
