using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * 
 * This script sets the max health for the player. the player health can be edited from the unity editor
 * This allows us to add more functionality where the player can recieve power ups for health
 * This script also integrates the data required for the health bar displkayed on the screen
 * We give the player 2 seconds of inmvulnerability everytime the player is shot just so the player can regain the control over the game and can play longer
 * 
 */

public class playerDamageHandler : MonoBehaviour
{
    //this piece of code integrates the health bar script that will display the player health bar on the screen
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

        //if the player invulnerability drops below 0, then the player can get hit and lose health
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

        //Thi9s piece of code will constantly check if the player has been dropped to 0. if it has, the player will die and the game object will be deleted from that instance of the game.
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    void playerDie()
    {
        Destroy(gameObject);
    }
}
