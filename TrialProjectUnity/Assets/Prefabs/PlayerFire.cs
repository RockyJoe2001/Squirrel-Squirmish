using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerFire : MonoBehaviour
 
{
  
    

    // Start is called before the first frame update
    void Start()
    {
    public GameObject projectilePrefab;

    public void FireProjectile()
    {
        //clone the projectile
        // fire it in a direction

        GameObject clonedProjectile;
        clonedProjectile = instantiate(projectilePrefab);
        clonedProjectile.transform.position = transform.position;

        Rigidbody2D projectileRigidbody;
        projectileRigidbody = clonedProjectile.GetComponent<Rigidbody2D>();

        public Vector2 projectileVelocity;

        projectileRigidbody.velocity = projectileVelocity;

    }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
