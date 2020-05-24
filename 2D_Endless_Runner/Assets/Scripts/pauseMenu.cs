using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * 
 * This script will display the pause menu when the player presses the pause button.
 * 
 */

public class pauseMenu : MonoBehaviour
{
    //We set a boolean value to check if the game has been paused. This boolean value can later be used to change the music to the pause menu music etc..
    public static bool GameIsPaused = false;


    //Here we instantiate the User interface the game object for the pause menu.
    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        //We check if the player has pressed the escape key. If the player has pressed the escape key, the game will switch to the pause menu and the game will freeze.
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    //To resume the game we set the scale of the flow of time to 1 using the Time.timeScale function
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }


    // To pause the game, We freeze the time in the game using the function Time.timeScale. when set to 0, the flow of time in the game is 0.
    // using the Time.timeScale function we can also do slow motion footage og the game wherever required. 
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    //To restart the game again, all we do is load the scene agian.
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Resume();
    }
}
