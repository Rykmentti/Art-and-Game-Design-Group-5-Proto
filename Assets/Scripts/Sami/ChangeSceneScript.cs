using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeSceneScript : MonoBehaviour
{
    [SerializeField] Button changeSceneButton;
    // Start is called before the first frame update
    void Start()
    {
        changeSceneButton.onClick.AddListener(() => ChangeScene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("StartScene");
    }
}
