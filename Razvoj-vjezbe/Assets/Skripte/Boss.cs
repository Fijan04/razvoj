using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth = 5;
    public BossHealth healthBar;
    private int life;
    private bool dead;
    public GameObject explosion;
    public Transform enemy;

    public void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        life = currentHealth;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            TakeDamage(1);

            if (currentHealth < 1)
            {
                dead = true;
            }
        }
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
    void Update()
    {
        if (dead == true)
        {
            Destroy(gameObject);
            Instantiate(explosion, enemy.position, transform.rotation = Quaternion.identity);

            GameObject[] foundObjects = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject go in foundObjects)
            {
                Destroy(go);
            }
        }
    }
}
