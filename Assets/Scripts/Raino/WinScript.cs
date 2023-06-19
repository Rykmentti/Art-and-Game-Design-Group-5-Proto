using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D colliderObject)
    {
        if (colliderObject.transform.tag == "Player")
        {
            SceneManager.LoadScene("VictoryScene");
        }
    }
}
