using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthDisplay : MonoBehaviour
{
    //Public array for the health icons
    public GameObject[] healthIcons;
    // variable for PlayerHealth called player
    PlayerHealth player;

    // Updates once at the start one time when play is pressed
    void Start()
    {
        // searches the entire unity project for PlayerHealth and stores it in player
        player = FindObjectOfType<PlayerHealth>();
    }

    // Updates throughout the playtime updating once every frame
    void Update()
    {
        //creates an object to keep track of what item we are on currently
        int currentIconHealth = 0;
        // Loop through every game object in the list
        // for every step in the loop, store the item in the icon
        foreach(GameObject icon in healthIcons)
        {
            //Get the current icon health value and add to it
            //each icon is worth +1 than the last
            currentIconHealth = currentIconHealth + 1;

            //if the players current health is equal or greater
            //than the health value for this icon
            if (player.GetHealth() >= currentIconHealth)
            {
                // turn the icon on
                icon.SetActive(true);
            }

            else
            {
                //turn the icon off
                icon.SetActive(false);
            }
        }
    }
}
