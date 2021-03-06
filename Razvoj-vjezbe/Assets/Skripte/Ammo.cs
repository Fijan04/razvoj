using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    public AudioClip ammo;
    public Transform sound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            AudioSource.PlayClipAtPoint(ammo, sound.position);
            AmmoText.currentAmmo += 4;
            Destroy(gameObject);
        }
    }
}
