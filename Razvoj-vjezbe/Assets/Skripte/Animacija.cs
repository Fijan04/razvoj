using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animacija : MonoBehaviour
{
    private void FixedUpdate()
    {
        Destroy(gameObject, 1f);
    }
}
