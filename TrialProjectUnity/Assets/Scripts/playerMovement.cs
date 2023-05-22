using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    //refrence variable so we can use the ridgid body
    //set it to null by defalt
    private Rigidbody2D physicsbody = null;

    private void Awake()
    {
        physicsbody = GetComponent<Rigidbody2D>();
    }

    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerMovement : MonoBehaviour
    {

    }

    public void MoveLeft()
    {
        //make a variable to hold velocity
        //currnt velocity from phisics component
        Vector2 newVelosity = physicsbody.velocity;
        //updte our phisics components velocity
        newVelosity.x = -1;
        //update our phisiscs velosity to ne velocity
    }

    public void MoveRight()
    {
        //make a variable to hold velocity
        //currnt velocity from phisics component
        Vector2 newVelosity = physicsbody.velocity;
        //updte our phisics components velocity
        newVelosity.x = 1;
        //update our phisiscs velosity to ne velocity
    }

    public void MoveUp()
    {
        //make a variable to hold velocity
        //currnt velocity from phisics component
        Vector2 newVelosity = physicsbody.velocity;
        //updte our phisics components velocity
        newVelosity.y = 1;
        //update our phisiscs velosity to ne velocity
    }
}
