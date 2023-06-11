using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int pistolDamage;
    
    void OnCollisionEnter2D(Collision2D collisionData)
    {
        Collider2D collider = collisionData.collider;

        PlayerHealth player = collider.GetComponent<PlayerHealth>();

        if (player != null)
        {
            player.ChangeHealth(-pistolDamage);
            Destroy(gameObject);



        }
    }
}
