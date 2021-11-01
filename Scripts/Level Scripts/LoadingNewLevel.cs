using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingNewLevel : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // loads a new level if the space key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("SceneName"); // write the name of the scene in the quotation marks
        }
    }
}
