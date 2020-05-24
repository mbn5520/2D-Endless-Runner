using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class playerDamageHandler : MonoBehaviour
{
    public healthBar healthBar;

    public int maxHealth = 4;
    public float playerInvul = 0f;
    public int currentHealth;

   void Start()
   {
        currentHealth = maxHealth;
        healthBar.setMaxHealth(maxHealth);
   }

    void OnTriggerEnter2D()
    {
        if (playerInvul <= 0)
        {
            currentHealth--;
            healthBar.setHealth(currentHealth);
        }
        playerInvul = 2f;
    }

    void Update()
    {
        playerInvul -= Time.deltaTime;

        if (currentHealth <= 0)
        {
            playerDie();
        }
    }

    void playerDie()
    {
        Destroy(gameObject);
    }
}
