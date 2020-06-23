using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerups : MonoBehaviour
{
    public bool doubleXP;
    public bool shield;
    public bool boost;
    public bool gunUpgrade;

    public float powerupDuration;

    private PowerupManager pm;

    // Start is called before the first frame update
    void Start()
    {
        pm = FindObjectOfType<PowerupManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Player")
        {
            pm.ActivatePowerup(doubleXP, shield, boost, gunUpgrade, powerupDuration);
        }
        gameObject.SetActive(false);
    }
}
