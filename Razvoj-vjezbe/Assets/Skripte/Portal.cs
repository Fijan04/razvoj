using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Portal : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject portal;

    private void Start()
    {
        portal.SetActive(false);
    }

    private void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        if (enemies.Length == 0)
        {
            portal.SetActive(true);
        }
    }
}
