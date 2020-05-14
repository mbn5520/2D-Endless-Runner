using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageHandler : MonoBehaviour
{
    public int health = 1;

    public float playerInvul = 0f; 

    void OnTriggerEnter2D()
    {
        if(playerInvul <= 0)
        health--;
        playerInvul = 2f;
    }

     void Update()
    {
        playerInvul -= Time.deltaTime;

        if(health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy (gameObject);
    }
}
