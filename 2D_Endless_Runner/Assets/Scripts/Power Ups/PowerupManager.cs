using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PowerupManager : MonoBehaviour
{
    // adds a 2x multiplier onthe XP
    private bool doubleXP;
    // adds extra health to player
    private bool shield;
    // doubles side to side movemetn speed
    private bool boost;
    // change colour of bullet
    private bool gunUpgrade;

    private string powerup;

    private bool powerupActive;
    private float powerupDurationCounter;

    private distanceTravelled dt;
    private playerDamageHandler dh;
    private playerMovement pm;
    private Shooting shooting;

    private int points;
    private float movement;

    // Start is called before the first frame update
    void Start()
    {
        powerupDurationCounter = 10f;

        dt = FindObjectOfType<distanceTravelled>();
        dh = FindObjectOfType<playerDamageHandler>();
        pm = FindObjectOfType<playerMovement>();
        shooting = FindObjectOfType<Shooting>();
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
            if(gunUpgrade)
            {
                //shooting.currentPrefab = shooting.upgradedPrefab;
            }

            if (powerupDurationCounter <= 0)
            {
                dt.score = points;
                pm.moveSpeed = movement;

                powerupActive = false;
            }
        }
    }

    public void ActivatePowerup(bool xp, bool s, bool speed, bool bullet, float time)
    {
        doubleXP = xp;
        shield = s;
        boost = speed;
        gunUpgrade = bullet;

        powerupDurationCounter = time;

        points = dt.score;
        movement = pm.moveSpeed;

        powerupActive = true;
    }
}
