﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("丟瓶子");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
