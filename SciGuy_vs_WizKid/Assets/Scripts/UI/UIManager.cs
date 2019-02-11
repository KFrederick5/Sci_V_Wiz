using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager: MonoBehaviour
{

    public string MAIN_GAME;
    public string START_SCREEN;
    GameObject[] pauseObjects;

    void Start()
    {
        Time.timeScale = 1;
        pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause"); 
        hidePause();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            if (Time.timeScale == 1)
                pause();
            else if (Time.timeScale == 0)
                unpause();
        }
    }
    private void showPause()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(true);
        }
    }

    private void hidePause()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(false);
        }
    }

    public void pause() //the external commands
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            showPause();
        } else
        {
            Debug.Log("Game is already paused!");
        }
    }


    public void unpause()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            hidePause();
        } else
        {
            Debug.Log("Game is already unpaused!");
        }
    }



    public void StartGame()
    {
        SceneManager.LoadScene(MAIN_GAME);
    }

    public void ToMainMenu()
    {
        SceneManager.LoadScene(START_SCREEN);
    }
}
