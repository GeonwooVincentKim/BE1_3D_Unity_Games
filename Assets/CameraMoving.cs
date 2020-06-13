using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoving : MonoBehaviour
{
    Transform playerTransform;
    Vector3 Offset;

    void Awake()
    {
        // Search for Objects by a given tag.
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        // Offset is the Variable to maintain distance between Camera Position 
        // and Ball Position. 
        Offset = transform.position - playerTransform.position;
    }

    // LateUpdate use for UI Update or Camera movement.
    // Calculating in Update function, then go to LateUpdate
    // to update substances objects such as camera and UI.
    void LateUpdate()
    {
        transform.position = playerTransform.position + Offset;
    }
}
