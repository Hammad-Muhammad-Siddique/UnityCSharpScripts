using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningAtMousePosition : MonoBehaviour
{
    // declare all variables
    Vector3 MousePosition; // to store the mouse position 
    Vector3 SpawnPosition; // to store the spawn position
    public GameObject ball; // the object to spawn

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // if the left click is clicked
        {
            // storing the mouse input into mousePosition variable
            MousePosition = Input.mousePosition; 

            // storing the value 10 into the z-coordinate of mouseposition
            MousePosition.z = 10f; 

            // converting screen coordinates into world coordinates and storing into SpawnPosition
            SpawnPosition = Camera.main.ScreenToWorldPoint(MousePosition);

            // spawning the ball by instantiating it
            Instantiate(ball, SpawnPosition, Quaternion.identity);
        }
        
    }
}