using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public GameObject explosion2;
    public Animator anim;
    public Transform enemy;
    private void Start()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            Instantiate(explosion2, enemy.position, transform.rotation = Quaternion.identity);
        }
    }
}
