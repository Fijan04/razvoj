using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1f;
        gameObject.SetActive(false);
    }
    public void ToggleEndMenu(float life)
    {
        Time.timeScale = 0f;
        gameObject.SetActive(true);
    }

    public void Checkpoint()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Nivo1");
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}
