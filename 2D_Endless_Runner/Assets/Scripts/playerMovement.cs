using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * 
 * This script takes the input from the user by accessing the unity's built in input manager.
 * Since we are only moving the player from left to right annd vice/versa, only the Horizontal axis was implemented from the input manager.
 * Player speed can also be manually added from the unity editor. 
 * This allows us to make any changes to the player speed once he has gained enough XP.
 * 
 */


public class playerMovement : MonoBehaviour
{
    public float moveSpeed = 6f;
    public float shipSpeed;

    private Rigidbody2D playerRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        //This code here allows the player ship to move forwaard. a constant amount velocity is added to the ship on the x axis to make it move forward in space.
        playerRigidBody.velocity = new Vector2(shipSpeed, playerRigidBody.velocity.x);

        // Makes the ship go left and right by accessing the horizontal axis from the input manager.
        Vector3 playerPosition = transform.position;
        playerPosition.x += Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;

        transform.position = playerPosition;
    }
}
