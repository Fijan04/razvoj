using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndScreen : MonoBehaviour
{
    public GameObject endScreen;
    public GameObject[] boss;
     void Start()
    {
        Time.timeScale = 1f;
        endScreen.SetActive(false);
    }
     void Update()
    {
        boss = GameObject.FindGameObjectsWithTag("Boss");

        if (boss.Length == 0)
        {
            StartCoroutine(Timer());
        }
    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(1f);
        endScreen.SetActive(true);
        Time.timeScale = 0f;
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
    public void Exit()
    {
        Application.Quit();
    }
}
