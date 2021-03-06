using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy2 : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth = 2;
    private int life;
    private bool dead;
    public GameObject deathAnim;
    public Transform enemy;
    public static int score;

    public void Start()
    {
        //PlayerPrefs.SetInt("score", 0);
        score = PlayerPrefs.GetInt("score");
        currentHealth = maxHealth;
        life = currentHealth;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            TakeDamage(1);
            score++;
            PlayerPrefs.SetInt("score", score);
            PlayerPrefs.Save();

            if (currentHealth < 1)
            {
                dead = true;
            }
        }
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }
    void Update()
    {
        if (dead == true)
        {
            Destroy(gameObject);
            Instantiate(deathAnim, enemy.position, transform.rotation = Quaternion.identity);
            Physics2D.IgnoreLayerCollision(8, 8);
        }
    }
}
