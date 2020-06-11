using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    Rigidbody rigid;
    // Vector3 vec;

    // Start is called before the first frame update
    void Start()
    {
        // Bring it own Component which is T Type.
        // rigid is Rigidbody Type, so we are going to use Rigidbody 
        // instead of using T.
        // It won't work if puts 3D Component into 2D Component.
        rigid = GetComponent<Rigidbody>();

        /* Object will move to right for itself. */
        // rigid.velocity = Vector3.right;

        /* Or, you can set the way this Object moving way as left. */
        //rigid.velocity = Vector3.left;

        // ForceMode means stress power. Such as Acceleration and Weight.
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /* The code related to RigidBody should write down in FixedUpdate. */
        // You might be can change speed. # 1. Change Speed.
        // rigid.velocity = new Vector3(2, 4, -1);
        //if (Input.GetButtonDown("Jump"))
        //{
        //    rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);
        //    Debug.Log(rigid.velocity);
        //}
        //Vector3 vec = new Vector3(
        //    Input.GetAxisRaw("Horizontal"),
        //    0,
        //    Input.GetAxisRaw("Vertical"));
        //rigid.AddForce(vec, ForceMode.Impulse);

        /* 
         * 3. Rotational Power 
         * Rotational Force occurs in the direction of Vec.
         */
        // rigid.AddTorque(Vector3.down);

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(h, 0, v);

        rigid.AddForce(vec, ForceMode.Impulse);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.name == "Cube")
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
    }

    public void Jump()
    {
        rigid.AddForce(Vector3.up * 20, ForceMode.Impulse);
    }

    // Events caused by actual physical collisions.
    void OnCollisionEnter(Collision collision)
    {
        
    }

    void OnCollisionStay(Collision collision)
    {
        
    }

    void OnCollisionExit(Collision collision)
    {
        
    }

    // Event caused by collider collision.
    void OnTriggerEnter(Collider other)
    {
        
    }

    void OnTriggerExit(Collider other)
    {
        
    }
}
