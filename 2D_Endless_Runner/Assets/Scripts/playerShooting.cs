using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * 
 * This script generates a bullet prefab every time the player presses the fire button.
 * The shooting is controlled by setting a cooldown timer after each bullet has been fired. 
 * This cooldown timer can be adjusted manually in the unity editor
 * This fire delay will be useful in the later builds where the player, qafter getting an upgrade will be able to shoot faster.
 * 
 */

public class playerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;

    public float fireDelay = 0.25f;
    float cooldownTimer = 0f;

    void Update()
    {
        cooldownTimer -= Time.deltaTime;

        if(Input.GetButton("Fire1") && cooldownTimer <= 0)
        {
            //After the cooldown timer has returned to zero, the code creates the bullet by instantiating the bullet prefab.
            //for future sprints where the player can upgrade shots, more prefabs can be added to the unity editor.
            
            cooldownTimer =fireDelay;

            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }
    }

}
