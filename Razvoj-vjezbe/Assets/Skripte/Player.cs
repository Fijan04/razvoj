using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.IO;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5f;
    public Animator anim;
    private Vector2 moveDirection;
    private Vector2 lastMoveDirection;
    public GameObject bullet;

    private void Start()
    {
    }
    void Update()
    {
        ProcessInputs();
        Animate();
    }
    private void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        if ((moveX == 0 && moveY == 0) && (moveDirection.x != 0 || moveDirection.y != 0))
        {
            lastMoveDirection = moveDirection;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AmmoText.currentAmmo -= 1; 
            var obj = Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity) as GameObject;
            if ((moveX == 0 && moveY == 0))
            {
                obj.GetComponent<Bullet>().moveDirection = lastMoveDirection;
            }
            else
            {
                obj.GetComponent<Bullet>().moveDirection = moveDirection;
            }
        }
        moveDirection = new Vector2(moveX, moveY);
    }
    private void Animate()
    {
        anim.SetFloat("AnimMoveX", moveDirection.x);
        anim.SetFloat("AnimMoveY", moveDirection.y);
        anim.SetFloat("AnimMoveM", moveDirection.magnitude);
        anim.SetFloat("AnimLastMoveX", lastMoveDirection.x);
        anim.SetFloat("AnimLastMoveY", lastMoveDirection.y);
    }
    private void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * speed, moveDirection.y * speed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "next")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
