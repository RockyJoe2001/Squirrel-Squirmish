using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class playerMovement : MonoBehaviour
{
    //reference variable so we can use the rigidbody
    //set it to null default, whichs means we do not have the reference yet

    private Rigidbody2D physicsBody = null;
    public float jumpSpeed = 10;
    public float speed = 500;
    public Collider2D GroundSensor = null;
    public LayerMask groundLayer = 0;

    private void Awake()
    {
        physicsBody = GetComponent<Rigidbody2D>();
    }

    

    

    public void MoveLeft()
    {
        //make a variable to hold your velocity and get the 
        //current velocity from the physics component

        Vector2 newVelocity = physicsBody.velocity;
        // set your velocityto move in the negative x left directions 
        newVelocity.x = -speed;
        // update our physics components velocityto be our newly changed value 
        physicsBody.velocity = newVelocity;

    }
    public void MoveRight()
    {
        //make a variable to hold your velocity and get the 
        //current velocity from the physics component

        Vector2 newVelocity = physicsBody.velocity;
        // set your velocityto move in the negative x left directions 
        newVelocity.x = speed;
        // update our physics components velocityto be our newly changed value 
        physicsBody.velocity = newVelocity;

    }

  

    
    public void Jump()
    {//made a variable to hold gravity
     // changes gravity from the velocity component

        if (GroundSensor.IsTouchingLayers(groundLayer))
        { 

            Vector2 newVelocity = physicsBody.velocity;
            // added jump speed to velocity
            newVelocity.y = jumpSpeed;

            physicsBody.velocity = newVelocity;
        }
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
