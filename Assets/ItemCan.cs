using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCan : MonoBehaviour
{
    public float rotateSpeed;
    void Update()
    {
        // A function that rotates by a parameter.
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime, Space.World);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            PlayerBall player = other.GetComponent<PlayerBall>();
            player.itemCount++;

            // Object Activation Function
            gameObject.SetActive(false);
        }
    }
}
