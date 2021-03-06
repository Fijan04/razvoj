using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFlw : MonoBehaviour
{
    public Transform target;
    Camera camera;

    private void Start()
    {
        camera = GetComponent<Camera>();
    }
    private void Update()
    {
        camera.orthographicSize = (Screen.height / 100f) / 3f;

        if (target)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, 1f);
        }


        transform.position = new Vector3(Mathf.Clamp(target.position.x, -2.8f, 2.8f),
                                         Mathf.Clamp(target.position.y, -1.6f, 5.2f), transform.position.z);
    }
}
