using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageHandler : MonoBehaviour
{
    int health =1;

    void OnTriggerEnter2D();
    {
        Debug.Log("TRigger!");
        health--;
        
        if(health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
