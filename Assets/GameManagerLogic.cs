using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;  // For Import UnityEngine UI System.

public class GameManagerLogic : MonoBehaviour
{
    // Number of Item.
    public int TotalItemCount;
    public int stage;
    public Text stageCountText;
    public Text playerCountText;


    void Awake()
    {
        // When add "/ " with TotalItemCount, 
        // it might be going to use Implicit cast.
        stageCountText.text = "/ " + TotalItemCount;
    }

    // We already bring manager from 'PlayerBall.cs',
    // So we are going to change Function name as 'GetItem'.
    public void GetItem(int count)
    {
        // And show the text how many Item do Player Already got 
        // by using count.ToString().
        playerCountText.text = count.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        // You can put Stage name only.
        // Or you can put "stage" variable only.
        if (other.gameObject.tag == "Player")
            SceneManager.LoadScene(stage);

    }
}
