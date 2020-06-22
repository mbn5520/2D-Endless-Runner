using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Damage handler for asteroids and enemies.
 * 
 * Utilises the unity provided box colliders to check if the box collider has triggered, if it has triggered, the health will drop to 0 and the object will be deleted.
 */

public class damageHandler : MonoBehaviour
{
    public int enemyHealth = 3;

    void OnTriggerEnter2D()
    {
        enemyHealth--;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Asteroid")
        {
            Debug.Log("Asteroid...");
        }
    }

    void Update()
    {
        

        if(enemyHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy (gameObject);
    }
}
