using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyLayer : MonoBehaviour
{
    private void Update()
    {
        Physics2D.IgnoreLayerCollision(11, 11);
    }
}
