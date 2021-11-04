using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningUsingKeys : MonoBehaviour
{
    public GameObject ball; // the object to spawn
    public Transform spawnPoint; // the point where the object will spawn

    // Update is called once per frame
    void Update()
    {
        // the ball is spawned if the space key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spawnBall();
        }
    }

    // creating a new function to spawn the ball
    void spawnBall()
    {
        Instantiate(ball, spawnPoint.position, Quaternion.identity);
    }
}