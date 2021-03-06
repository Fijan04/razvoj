using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoText : MonoBehaviour
{
    Text text;
    public  int maxAmmo = 12;
    public static int currentAmmo;
    void Start()
    {
        currentAmmo = maxAmmo;
        text = GetComponent<Text>();
    }

    void Update()
    {
        if (currentAmmo > 0)
        {
            text.text = ": " + currentAmmo;
        }
        else
        {
            text.text = ": OUT OF AMMO!!";
        }
    }
}
