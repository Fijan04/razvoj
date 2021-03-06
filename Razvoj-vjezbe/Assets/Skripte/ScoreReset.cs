using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreReset : MonoBehaviour
{
    public GameObject[] player;
    public void Update()
    {
        player = GameObject.FindGameObjectsWithTag("Enemy");
        if (player.Length == 0)
        {
            StartCoroutine(Timer());
        }
    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(1f);
        PlayerPrefs.DeleteKey("score");
        PlayerPrefs.Save();
        Destroy(gameObject);
    }
}
