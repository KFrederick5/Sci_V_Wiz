using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager: MonoBehaviour
{

    public string MAIN_GAME;

    public void StartGame()
    {
        SceneManager.LoadScene(MAIN_GAME);
    }
}
