using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPause = false;
    public static bool GameIsQuit = false;
    public GameObject pauseMenuUI;
    public GameObject quitUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        quitUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
        GameIsQuit = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        quitUI.SetActive(false);
        Time.timeScale = 0f;
        GameIsPause = true;
        GameIsQuit = false;
    }

    public void Restart()
    {
        SceneManager.LoadScene("Environment");
    }

    public void QuitGame()
    {
        quitUI.SetActive(true);
        GameIsQuit = true;
    }

    public void QuitYes()
    {
        SceneManager.LoadScene("WelcomePage");
    }

    public void QuitNo()
    {
        quitUI.SetActive(false);
        GameIsQuit = false;
    }
}
