using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBall : MonoBehaviour
{
    public float JumpPower;
    public int itemCount;
    public GameManagerLogic manager;

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
        if (collision.gameObject.tag == "Floor")
            isJump = false;
    }

    // 'PlayerBall.cs' will play Music instead of play in 'ItemCan.cs'.
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item")
        {
            itemCount++;
            AudioListener.volume = 0.5f;
            Audio.Play();
            other.gameObject.SetActive(false);
        }
        else if(other.tag == "Point")
        {
            // It is better to avoid to use Find Function
            // GameObject.Find();
            if(itemCount == manager.TotalItemCount)
            {
                // Show result as 'Game Clear!'
                SceneManager.LoadScene("Example1_1");
            }
            else
            {
                // Restart the game.
                SceneManager.LoadScene("Example1_0");
            }
        }
    }
}
