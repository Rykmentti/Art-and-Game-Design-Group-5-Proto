using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeClick : MonoBehaviour
{
    public GameObject canvas;
    public GameObject tree;
    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
    }

    // Update is called once per frame
    public void OnMouseDown()
    {
        Debug.Log("Click detected");
        canvas.SetActive(true);
    }
}
