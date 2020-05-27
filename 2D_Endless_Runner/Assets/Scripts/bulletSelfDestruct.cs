using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * 
 * This code deletes the Game object after a set amount of time
 * it achieves that using the Destroy() function.
 * 
 * **/

public class bulletSelfDestruct : MonoBehaviour
{
    public float timer = 10f;


    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if(timer <=0)
        {
            Destroy(gameObject);
        }
    }
}
