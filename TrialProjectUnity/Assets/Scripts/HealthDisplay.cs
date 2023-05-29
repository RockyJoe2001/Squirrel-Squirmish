using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthDisplay : MonoBehaviour
{
    public GameObject[] healthIcons;

    PlayerHealth player;

    void Start()
    {
        player = FindObjectOfType<PlayerHealth>();
    }

    void Update()
    {
        int currentIconHealth = 0;
        foreach(GameObject icon in healthIcons)
        {
            currentIconHealth = currentIconHealth + 1;

            if (player.GetHealth() >= currentIconHealth)
            {
                icon.SetActive(true);
            }

            else
            {
                icon.SetActive(false);
            }
        }
    }
}
