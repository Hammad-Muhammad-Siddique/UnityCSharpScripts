using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayingText : MonoBehaviour
{
    // gameobject to store the text
    public GameObject text; // public is used to display it into the Unity Editor

    // Start is called before the first frame update
    void Start()
    {
        // the text is hidden at the start of the game
        text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // the text is display if the space key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            text.SetActive(true);
        }
        
    }
}
