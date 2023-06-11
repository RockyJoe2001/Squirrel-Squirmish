using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
   

    public GameObject projectilePrefab;
    public Vector2 projectileVelocity;

    public float timer;
    public float waitingTime;

    // KEYBOARD / GAMEPAD ONLY!
    // CONDITION: When the player presses a key / button...

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > waitingTime)
        {
            //Action
            FireProjectile();
            timer = 0;
        }
    }




    // ACTION: Fire a projectile
    public void FireProjectile()
    {

        // Clone the pojectile
        // Declare a variable to hold the cloned object
        GameObject clonedProjectile;
        // Use Instantiate to clone the projectile and keep the result in our variable
        clonedProjectile = Instantiate(projectilePrefab);


        // Position the projectile on the player
        clonedProjectile.transform.position = transform.position; // OPTIONAL: Add an offset (use a public variable)


        // Fire it in a direction
        // Declare a vairable to hold the cloned object's rigidbody
        Rigidbody2D projectileRigidbody;
        // Get the rigidbody from our cloned projectile and store it
        projectileRigidbody = clonedProjectile.GetComponent<Rigidbody2D>();
        // Set the velocity on the rigidbody to the editor setting
        projectileRigidbody.velocity = projectileVelocity;


        
    }
}
