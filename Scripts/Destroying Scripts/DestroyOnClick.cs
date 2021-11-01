using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnClick : MonoBehaviour
{

    // This function is called whenever the mouse is clicked
    private void OnMouseDown()
    {
        // destroys the gameobject this script is attached to
        Destroy(gameObject);
    }
}
