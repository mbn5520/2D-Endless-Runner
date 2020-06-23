using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupManager : MonoBehaviour
{
    private bool doubleXP;
    private bool shield;
    private bool boost;

    private bool powerupActive;

    private float powerupDurationCounter;

    private distanceTravelled dt;
    private playerDamageHandler dh;
    private playerMovement pm;

    private int points;
    private int health;
    private float movement;

    // Start is called before the first frame update
    void Start()
    {
        powerupDurationCounter = 10f;

        dt = FindObjectOfType<distanceTravelled>();
        dh = FindObjectOfType<playerDamageHandler>();
        pm = FindObjectOfType<playerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if(powerupActive)
        {
            powerupDurationCounter -= Time.deltaTime;

            if(doubleXP)
            {
                dt.score = points * 2;
            }
            if(shield)
            {
                dh.currentHealth = dh.maxHealth * 2;
            }
            if(boost)
            {
                pm.moveSpeed = movement * 2;
            }

            if(powerupDurationCounter <= 0)
            {
                dt.score = points;
                dh.currentHealth = health;
                pm.moveSpeed = movement;

                powerupActive = false;
            }
        }
    }

    public void ActivatePowerup(bool xp, bool s, bool speed, float time)
    {
        doubleXP = xp;
        shield = s;
        boost = speed;

        powerupDurationCounter = time;

        points = dt.score;
        health = dh.maxHealth;
        movement = pm.moveSpeed;

        powerupActive = true;
    }
}
