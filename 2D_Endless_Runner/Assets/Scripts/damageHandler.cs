using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageHandler : MonoBehaviour
{
    public int health = 1;

    void OnTriggerEnter2D()
    {
        health--;
    }

     void Update()
    {
        

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
