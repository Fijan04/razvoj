using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform gun;
    public Rigidbody2D bullet;
    public float bulletSpeed = 500f;
    Rigidbody2D rb;
    void Update()
    {
        Fire();
    }
    void Fire ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var firedBullet = Instantiate(bullet, gun.position, gun.rotation);
            firedBullet.AddForce(gun.up * bulletSpeed);
        }
    }
}
