using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyingOnKeyboardInput : MonoBehaviour
{
    void Update()
    {
        // Should be placed in the update function. Destroys the game object this script is attached to if Space key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(gameObject);
        }
        
    }
}
