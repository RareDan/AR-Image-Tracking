using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    private Transform cameraTransform;

    private void Start()
    {
        cameraTransform = Camera.main.transform;
    }

    void Update()
    {
        transform.LookAt(
            new Vector3(
                cameraTransform.position.x,
                transform.position.y,
                cameraTransform.position.z
            )
       );
    }
}
