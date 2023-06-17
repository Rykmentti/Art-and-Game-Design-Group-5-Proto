using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputCheck : MonoBehaviour
{
    string input;
    public GameObject tree;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadStringInput(string two)
    {
        input = two;
        Debug.Log("text entered");
        
            
    }
}
