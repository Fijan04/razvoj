using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float destroyTime = 1f;
    public float speed = 1f;
    public Vector2 moveDirection;
    private float angle;
    public Rigidbody2D rb;
    public SpriteRenderer sr;

    void Start()
    {
        angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
        Invoke("Destroy", destroyTime);
        sr.transform.Rotate(0, 0, angle);
    }
    void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;
        rb.velocity = new Vector2(moveDirection.x * speed, moveDirection.y * speed);

    }
    void Destroy()
    {
        Destroy(gameObject, destroyTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Boss")
        {
            Destroy(gameObject);
        }
    }
}
