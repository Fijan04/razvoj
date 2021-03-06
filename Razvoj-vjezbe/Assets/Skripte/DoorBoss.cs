using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBoss : MonoBehaviour
{
    public GameObject[] enemies;
    public Animator anim;
    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Boss");

        if (enemies.Length == 0)
        {
            anim.SetInteger("AnimState", 1);
        }
        Physics2D.IgnoreLayerCollision(0, 10);
    }
}
