using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public int hazardDamage;
    
        void OnCollisionEnter2D(Collision2D collision)
        {
            
            Collider2D collider = collision.collider;

            EnemyHealth enemy = collider.GetComponent<EnemyHealth>();



            if (enemy != null)
            {
                enemy.ChangeHealth(-hazardDamage);
                Destroy(gameObject);



            }
        }



}
      