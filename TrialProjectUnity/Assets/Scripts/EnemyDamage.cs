using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int pistolDamage; //public integer for pistol damage
    
    void OnCollisionEnter2D(Collision2D collisionData)
    {
        Collider2D collider = collisionData.collider;

        PlayerHealth player = collider.GetComponent<PlayerHealth>(); // gets collider from Playerheath script

        if (player != null)
        {
            // damages the player and deletes the bullet after impact
            player.ChangeHealth(-pistolDamage);
            Destroy(gameObject);



        }
    }
}
