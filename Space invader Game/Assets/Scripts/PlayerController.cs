using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private GameObject projectile;

    [SerializeField]
    private float moveSpeed;

    // Update is called once per frame
    void Update ()
    {
        Move();

        Fire();
	}

    /// <summary>
    /// Moves the player left/right
    /// </summary>
    void Move()
    {
        // am I going left... or right..?
        float horizontal = Input.GetAxis("Horizontal");

        // set the speed
        float speed = horizontal * moveSpeed * Time.deltaTime;

        // add speed to x position
        transform.position = new Vector3(transform.position.x + speed, transform.position.y, 0f);
    }

    /// <summary>
    /// Fires a projectile
    /// </summary>
    void Fire()
    {      
        if(Input.GetButtonDown("Fire1"))
        {  
            // create the projectile
            Instantiate(projectile, transform.position, transform.rotation);
        }
    }
}
