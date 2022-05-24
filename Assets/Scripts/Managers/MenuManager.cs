using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public static bool gameIsPaused;

    public GameObject pauseMenu;
    public GameObject settingsMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !gameIsPaused)
        {
            gameIsPaused = true;
            PauseGame();
        }
    }
    void PauseGame ()
    {
        if(gameIsPaused)
        {
            Time.timeScale = 0f;
            AudioListener.pause = true;
            pauseMenu.SetActive(true);
        }
        else 
        {
            Time.timeScale = 1;
            AudioListener.pause = false;
        }
    }

    public void ResumeGame()
    {
        gameIsPaused = false;
        pauseMenu.SetActive(false);
        settingsMenu.SetActive(false);
        PauseGame();
    }
}
