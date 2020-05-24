using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * 
 * This script set's the speed of the fired shots.
 * This speed can be controlled manually from the unity editor.
 * This will allow us to upgrade the speed of the shots in future iterations when player power ups are added to the game.
 * 
 * 
 */

public class firedShots : MonoBehaviour
{
    public float moveSpeed = 20f;

    // Update is called once per frame
    void Update()
    {

        /// The code translates the speed of the shot to the screen by adding the move speed value to the current position of the bullet in respect to the screen and updating the position of the bullet
        Vector3 shotPosition = transform.position;
        shotPosition.y +=  moveSpeed * Time.deltaTime;

        transform.position = shotPosition;
    }
}
