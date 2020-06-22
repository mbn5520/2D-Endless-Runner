using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shield : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            Pickup(other);
        } 
    }

    void Pickup(Collider2D player)
    {
        // add extra health to player
        //player.

        // remove powerup once pickedup
        //Destroy(gameObject);
    }
}
