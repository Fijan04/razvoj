using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthBoss : MonoBehaviour
{
    public GameObject[] hearts;
    private int life;
    private bool dead;
    public DeathMenu deathMenu;

    private void Start()
    {
        life = hearts.Length;
    }

    void Update()
    {
        if (dead == true)
        {

            deathMenu.ToggleEndMenu(life);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Boss")
        {
            if (life >= 1)
            {
                int d = 3;
                life -= d;
                Destroy(hearts[life].gameObject);
                if (life < 1)
                {
                    dead = true;
                }
            }
        }
    }
}
