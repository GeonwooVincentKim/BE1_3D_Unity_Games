using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBall : MonoBehaviour
{
    public float JumpPower;
    public int itemCount;
    bool isJump;
    Rigidbody rigid;
    AudioSource Audio;

    void Awake()
    {
        isJump = false;
        rigid = GetComponent<Rigidbody>();

        // It would be better to Initialize Variable in Awake Function.
        Audio = GetComponent<AudioSource>();
        // Audio.Play();

    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && !isJump)
        {
            isJump = true;
            rigid.AddForce(new Vector3(0, JumpPower, 0), ForceMode.Impulse);
        }    
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        rigid.AddForce(new Vector3(h, 0, v), ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Floor")
            isJump = false;
    }

    // 'PlayerBall.cs' will play Music instead of play in 'ItemCan.cs'.
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Item")
        {
            itemCount++;
            Audio.Play();
            other.gameObject.SetActive(false);
        }
    }
}
