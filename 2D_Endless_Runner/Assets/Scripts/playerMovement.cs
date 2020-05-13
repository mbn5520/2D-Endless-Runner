using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
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
        playerRigidBody.velocity = new Vector2(shipSpeed, playerRigidBody.velocity.x);

        // Makes the ship go left and right
        Vector3 playerPosition = transform.position;
        playerPosition.x += Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;

        transform.position = playerPosition;
    }
}
