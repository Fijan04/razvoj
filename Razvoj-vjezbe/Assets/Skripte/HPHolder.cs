using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPHolder : MonoBehaviour
{
    public Slider healthBar;

    private void Update()
    {
        Vector3 namePos = Camera.main.WorldToScreenPoint(this.transform.position);
        healthBar.transform.position = namePos;
    }
}
