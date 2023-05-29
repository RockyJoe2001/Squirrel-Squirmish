using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth;

    public string targetScene = "";

    private int currentHealth;

    void Awake()
    {
        currentHealth = startingHealth;
    }

    public void ChangeHealth(int changeAmount)
    {
        currentHealth = currentHealth + changeAmount;

        currentHealth = Mathf.Clamp(currentHealth, 0, startingHealth);

        if (currentHealth == 0)
        {
            ChangeScene();
        }

    }
   
    public void ChangeScene()
    {
        SceneManager.LoadScene(targetScene);
    }

    public int GetHealth()
    {
        return currentHealth;
    }

    public int GetMaxHealth()
    {
        return startingHealth;
    }
}
