using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBalls : MonoBehaviour
{
    // Start is called before the first frame update.
    // Material Approach of Object
    MeshRenderer mesh;
    Material mat;

    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    // Call a function when Physical Conflict started.
    private void OnCollisionEnter(Collision collision)
    {
        // Color --> Basic Color Class
        // Color32 --> 255 Color Class
        if (collision.gameObject.name == "Sphere")
            mat.color = new Color(0, 0, 0);
    }

    // Call a function when waiting for Physical Conflict.
    private void OnCollisionStay(Collision collision)
    {

    }

    // Call a function when Physical Conflict finished.
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Sphere")
            mat.color = new Color(1, 1, 1);
    }
}
