using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public int hazardDamage; //public integer for hazard damage
    
        void OnCollisionEnter2D(Collision2D collision)
        {
            
            Collider2D collider = collision.collider;

            EnemyHealth enemy = collider.GetComponent<EnemyHealth>(); // gets collider from enemyheath script



            if (enemy != null)
            {
                // damages the enemy and deletes the bullet after impact
                enemy.ChangeHealth(-hazardDamage);
                Destroy(gameObject);



            }
        }



}
      