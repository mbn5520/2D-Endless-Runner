using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefab;

    public float fireDelay = 0.25f;
    float cooldownTimer = 0f;

    void Update()
    {
        cooldownTimer -= Time.deltaTime;

        if(Input.GetButton("Fire1") && cooldownTimer <= 0)
        {
            Debug.Log("POW!");
            cooldownTimer =fireDelay;

            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }
    }

}
