using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public void restartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
