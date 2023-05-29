using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hazard : MonoBehaviour
{
    public int hazardDamage;
    public string targetScene = "";
    void OnCollisionEnter2D(Collision2D collisionData)
    {
        Collider2D collider = collisionData.collider;

        PlayerHealth player = collider.GetComponent<PlayerHealth>();

        if (player != null)
        {
            player.ChangeHealth(-hazardDamage);

        }
        
    }
    
}
