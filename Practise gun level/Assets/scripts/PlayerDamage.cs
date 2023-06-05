using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    // CONDITION: When the projectile hits a certain object type... (enemy)
    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        // Check if the object we collided with has the tag we are looking for (Enemy)
        if (otherCollider.CompareTag("Enemy") == true)
        {
            // Perform our action
            KillEnemy(otherCollider.gameObject);
        }
    }


    // ACTION: Destroy an object (enemy)
    public void KillEnemy(GameObject enemy)
    {
        Destroy(enemy);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
