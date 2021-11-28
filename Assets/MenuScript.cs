using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused == false)
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f; //game back to normal
        GameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f; //freeze game
        GameIsPaused = true;
    }

    public void OptionsPause()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 0f; //freeze game
        GameIsPaused = true;
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        GameIsPaused = false;
        Resume();
    }


    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit(); //Quits game function
    }

}
