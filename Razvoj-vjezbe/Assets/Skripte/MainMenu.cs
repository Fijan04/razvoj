using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Nivo1");
    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
    }
    public void Levels()
    {
        SceneManager.LoadScene("Levels");

    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
