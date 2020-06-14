using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerLogic : MonoBehaviour
{
    // Number of Item.
    public int TotalItemCount;
    public int stage;

    void OnTriggerEnter(Collider other)
    {
        // You can put Stage name only.
        // Or you can put "stage" variable only.
        Debug.Log(stage);
        if (other.gameObject.tag == "Player")
            SceneManager.LoadScene(stage);

    }
}
